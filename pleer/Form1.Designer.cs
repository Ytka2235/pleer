namespace pleer
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox = new System.Windows.Forms.ListBox();
            this.but_get_mp3 = new System.Windows.Forms.Button();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.name_audio = new System.Windows.Forms.Label();
            this.but_ref = new System.Windows.Forms.PictureBox();
            this.but_prev = new System.Windows.Forms.PictureBox();
            this.but_next = new System.Windows.Forms.PictureBox();
            this.but_PS = new System.Windows.Forms.PictureBox();
            this.but_rnd = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.but_ref)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.but_prev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.but_next)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.but_PS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.but_rnd)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(12, 204);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(281, 388);
            this.listBox.TabIndex = 0;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // but_get_mp3
            // 
            this.but_get_mp3.Location = new System.Drawing.Point(12, 12);
            this.but_get_mp3.Name = "but_get_mp3";
            this.but_get_mp3.Size = new System.Drawing.Size(281, 23);
            this.but_get_mp3.TabIndex = 1;
            this.but_get_mp3.Text = "выбор папки";
            this.but_get_mp3.UseVisualStyleBackColor = true;
            this.but_get_mp3.Click += new System.EventHandler(this.but_get_mp3_Click);
            // 
            // trackBar
            // 
            this.trackBar.Location = new System.Drawing.Point(12, 141);
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(281, 56);
            this.trackBar.TabIndex = 9;
            this.trackBar.Value = 10;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "0%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "100%";
            // 
            // name_audio
            // 
            this.name_audio.AutoSize = true;
            this.name_audio.Location = new System.Drawing.Point(12, 54);
            this.name_audio.Name = "name_audio";
            this.name_audio.Size = new System.Drawing.Size(0, 16);
            this.name_audio.TabIndex = 17;
            // 
            // but_ref
            // 
            this.but_ref.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.but_ref.Image = global::pleer.Properties.Resources.ref_all;
            this.but_ref.Location = new System.Drawing.Point(249, 96);
            this.but_ref.Name = "but_ref";
            this.but_ref.Size = new System.Drawing.Size(40, 40);
            this.but_ref.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.but_ref.TabIndex = 16;
            this.but_ref.TabStop = false;
            this.but_ref.Click += new System.EventHandler(this.but_ref_Click);
            // 
            // but_prev
            // 
            this.but_prev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.but_prev.Image = global::pleer.Properties.Resources.prev1;
            this.but_prev.Location = new System.Drawing.Point(68, 96);
            this.but_prev.Name = "but_prev";
            this.but_prev.Size = new System.Drawing.Size(40, 40);
            this.but_prev.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.but_prev.TabIndex = 15;
            this.but_prev.TabStop = false;
            this.but_prev.Click += new System.EventHandler(this.but_prev_Click);
            // 
            // but_next
            // 
            this.but_next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.but_next.Image = global::pleer.Properties.Resources.next1;
            this.but_next.InitialImage = null;
            this.but_next.Location = new System.Drawing.Point(190, 96);
            this.but_next.Name = "but_next";
            this.but_next.Size = new System.Drawing.Size(40, 40);
            this.but_next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.but_next.TabIndex = 14;
            this.but_next.TabStop = false;
            this.but_next.WaitOnLoad = true;
            this.but_next.Click += new System.EventHandler(this.but_next_Click);
            // 
            // but_PS
            // 
            this.but_PS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.but_PS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.but_PS.Image = global::pleer.Properties.Resources.pysk;
            this.but_PS.Location = new System.Drawing.Point(127, 96);
            this.but_PS.Margin = new System.Windows.Forms.Padding(0);
            this.but_PS.Name = "but_PS";
            this.but_PS.Size = new System.Drawing.Size(40, 40);
            this.but_PS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.but_PS.TabIndex = 13;
            this.but_PS.TabStop = false;
            this.but_PS.Click += new System.EventHandler(this.but_PS_Click);
            // 
            // but_rnd
            // 
            this.but_rnd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.but_rnd.Image = global::pleer.Properties.Resources.rnd0;
            this.but_rnd.Location = new System.Drawing.Point(12, 96);
            this.but_rnd.Name = "but_rnd";
            this.but_rnd.Size = new System.Drawing.Size(40, 40);
            this.but_rnd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.but_rnd.TabIndex = 12;
            this.but_rnd.TabStop = false;
            this.but_rnd.Click += new System.EventHandler(this.but_rnd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 605);
            this.Controls.Add(this.name_audio);
            this.Controls.Add(this.but_ref);
            this.Controls.Add(this.but_prev);
            this.Controls.Add(this.but_next);
            this.Controls.Add(this.but_PS);
            this.Controls.Add(this.but_rnd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.but_get_mp3);
            this.Controls.Add(this.listBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.but_ref)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.but_prev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.but_next)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.but_PS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.but_rnd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button but_get_mp3;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox but_ref;
        private System.Windows.Forms.PictureBox but_next;
        private System.Windows.Forms.PictureBox but_PS;
        private System.Windows.Forms.PictureBox but_prev;
        private System.Windows.Forms.PictureBox but_rnd;
        private System.Windows.Forms.Label name_audio;
    }
}

