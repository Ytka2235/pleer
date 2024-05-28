using System;
using System.IO;
using System.Windows.Forms;
using System.Windows.Media;

namespace pleer
{
    public partial class Form1 : Form
    {
        public MediaPlayer media; // объект плеера
        public string[] audio; // массив путей к песням
        public int playAudio; // id текущей песни
        public bool isPlay; // флаг, идет ли песни(на паузе тоже true) или нет

        public bool play; // флаг режим кнопки пуск/пауза
        public void set_play(bool b) // изменение картинки
        {
            if (b) but_PS.Image = System.Drawing.Image.FromFile("stop.png");
            if (!b) but_PS.Image = System.Drawing.Image.FromFile("pysk.png");
            play = b;
        }

        public bool rnd; // флаг режима кнопки случайнок песни
        public void set_rnd(bool b) // изменение картинки
        {
            if (b) but_rnd.Image = System.Drawing.Image.FromFile("rnd1.png");
            if (!b) but_rnd.Image = System.Drawing.Image.FromFile("rnd0.png");
            rnd = b;
        }

        public int reset; // флаг режима кнопки повторения

        public void set_reset(int k) // изменение картинки
        {
            if (k == 0) but_ref.Image = System.Drawing.Image.FromFile("ref0.png"); // повторени нет
            if (k == 1) but_ref.Image = System.Drawing.Image.FromFile("ref1.png"); // зациклина 1 песня
            if (k == 2) but_ref.Image = System.Drawing.Image.FromFile("ref_all.png"); // песнни будут идти подряд
            reset = k;
        }

        // инициализация и установка ночальных значений
        public Form1()
        {
            InitializeComponent();
            media = new MediaPlayer();
            set_rnd(false);
            set_play(false);
            set_reset(2);
        }

        // кнопка выбора папки
        private void but_get_mp3_Click(object sender, EventArgs e)
        {
            // вызываем окно выбора папки
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK) // если папка выбрана
                {
                    string folderPath = dialog.SelectedPath; // путь выбранной папки
                    audio = Directory.GetFiles(folderPath, "*.mp3"); // загружам пути песен в массив audio
                    name_audio.Text = "";
                    listBox.Items.Clear(); // чистим лист
                    foreach (string s in audio) listBox.Items.Add(s.Substring(s.LastIndexOf("\\")).Trim('\\')); //заполняем список
                    play = false; // установка флагов
                    isPlay = false; // установка флагов
                }
            }
        }

        // вызывается при клике на элемент списка, запускае выбраннную песню
        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            play_audio(listBox.SelectedIndex);
            set_play(true);
            name_audio.Text = audio[listBox.SelectedIndex].Substring(audio[listBox.SelectedIndex].LastIndexOf("\\")).Trim('\\');
        }

        // запускает песню по id в массиве audio
        public void play_audio(int id)
        {
            playAudio = id; // устанавливаем id играющей песни
            media.Open(new Uri(audio[id])); // загружаем песню, переводим из string в Uri чтоб работала
            media.Play(); // запускаем песню
            media.MediaEnded += play_end; // делегирум метод, что бы обработать событие когда песня заканчивается
            if (trackBar.Value == 0) media.Volume = 0; // устанавливаем громкость
            else media.Volume = (double)trackBar.Value / 10; // устанавливаем громкость
            play = true; // 
            isPlay = true;
        }

        // метод для обработки завершения песни
        private void play_end(object sender, EventArgs e)
        {
            if (reset == 1) play_audio(playAudio); // если reset = 1 песня повторяется
            else if (rnd) // если rnd = true следующая песня случайная
            {
                Random random = new Random();
                play_audio(random.Next(0, audio.Length));
            }
            else if (reset == 2) //если reset = 2 будет играть следующая песня 
            {
                if (playAudio == audio.Length - 1) play_audio(0);
                else play_audio(playAudio + 1);
            }
            else  // иначе никакая песня дальше идти не будет
            {
                isPlay = false;
                play = false;
            }
            throw new NotImplementedException();

        }

        // обработка нажатия на кнопку пуск/пауза
        private void but_PS_Click(object sender, EventArgs e)
        {
            if (isPlay)
            {
                if (play)
                {
                    media.Pause();
                    set_play(false);
                }
                else if (!play)
                {
                    media.Play();
                    set_play(true);
                }
            }
            else
            {
                media.Play();
                set_play(true);
            }
        }

        // установка громкости при перемещении ползунка
        private void trackBar_Scroll(object sender, EventArgs e)
        {
            if (trackBar.Value == 0) media.Volume = 0;
            else media.Volume = (double)trackBar.Value / 10;
        }

        // кнопка следующей песни
        private void but_next_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex >= 0)
            {
                if (rnd)
                {
                    Random random = new Random();
                    play_audio(random.Next(0, audio.Length));
                }
                else if (playAudio == audio.Length - 1) listBox.SelectedIndex = 0;
                else listBox.SelectedIndex = playAudio + 1;
            }
        }

        // изменения режима кнопки рандома
        private void but_rnd_Click(object sender, EventArgs e)
        {
            set_rnd(!rnd);
        }

        // изменения режима кнопки повторения
        private void but_ref_Click(object sender, EventArgs e)
        {
            if (reset == 2) set_reset(0);
            else set_reset(reset + 1);
        }

        // кнпка предыдущей песни
        private void but_prev_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex >= 0)
            {
                if (playAudio == 0) listBox.SelectedIndex = audio.Length - 1;
                else listBox.SelectedIndex = playAudio - 1;
            }
        }
    }
}
