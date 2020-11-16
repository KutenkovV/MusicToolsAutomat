namespace MusicTools
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnReffil = new System.Windows.Forms.Button();
            this.txtinfo = new System.Windows.Forms.RichTextBox();
            this.btnGet = new System.Windows.Forms.Button();
            this.txtout = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Музыкальные инструменты";
            // 
            // btnReffil
            // 
            this.btnReffil.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReffil.Location = new System.Drawing.Point(129, 64);
            this.btnReffil.Name = "btnReffil";
            this.btnReffil.Size = new System.Drawing.Size(239, 71);
            this.btnReffil.TabIndex = 1;
            this.btnReffil.Text = "Обновить инструменты в автомате";
            this.btnReffil.UseVisualStyleBackColor = true;
            this.btnReffil.Click += new System.EventHandler(this.btnReffil_Click);
            // 
            // txtinfo
            // 
            this.txtinfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtinfo.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtinfo.Location = new System.Drawing.Point(47, 141);
            this.txtinfo.Name = "txtinfo";
            this.txtinfo.ReadOnly = true;
            this.txtinfo.Size = new System.Drawing.Size(404, 59);
            this.txtinfo.TabIndex = 2;
            this.txtinfo.Text = "";
            // 
            // btnGet
            // 
            this.btnGet.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGet.Location = new System.Drawing.Point(311, 394);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(141, 115);
            this.btnGet.TabIndex = 3;
            this.btnGet.Text = "Взять случайный инструмент";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // txtout
            // 
            this.txtout.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtout.Location = new System.Drawing.Point(44, 394);
            this.txtout.Name = "txtout";
            this.txtout.ReadOnly = true;
            this.txtout.Size = new System.Drawing.Size(261, 115);
            this.txtout.TabIndex = 4;
            this.txtout.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.txtout);
            this.panel1.Controls.Add(this.btnGet);
            this.panel1.Controls.Add(this.txtinfo);
            this.panel1.Controls.Add(this.btnReffil);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(117, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(698, 576);
            this.panel1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(483, 206);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(178, 303);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = global::MusicTools.Properties.Resources._1;
            this.pictureBox1.Location = new System.Drawing.Point(47, 206);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(404, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.button1.Location = new System.Drawing.Point(43, 515);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(408, 48);
            this.button1.TabIndex = 8;
            this.button1.Text = "Информация о задании";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.label2.Location = new System.Drawing.Point(492, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ассортимент автомата";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(920, 611);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReffil;
        private System.Windows.Forms.RichTextBox txtinfo;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.RichTextBox txtout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

