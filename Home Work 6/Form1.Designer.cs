namespace Home_Work_6
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
            this.lbWorkedThreads = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbWaitThreads = new System.Windows.Forms.ListBox();
            this.lbCreatedThreads = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbWorkedThreads
            // 
            this.lbWorkedThreads.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.lbWorkedThreads.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbWorkedThreads.ForeColor = System.Drawing.Color.White;
            this.lbWorkedThreads.FormattingEnabled = true;
            this.lbWorkedThreads.Location = new System.Drawing.Point(31, 81);
            this.lbWorkedThreads.Name = "lbWorkedThreads";
            this.lbWorkedThreads.Size = new System.Drawing.Size(225, 143);
            this.lbWorkedThreads.TabIndex = 0;
            this.lbWorkedThreads.DoubleClick += new System.EventHandler(this.lbWorkedThreads_DoubleClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(535, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 52);
            this.button1.TabIndex = 1;
            this.button1.Text = "Создать поток";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Работающие потоки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(42, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Количество мест в семафоре";
            // 
            // lbWaitThreads
            // 
            this.lbWaitThreads.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.lbWaitThreads.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbWaitThreads.ForeColor = System.Drawing.Color.White;
            this.lbWaitThreads.FormattingEnabled = true;
            this.lbWaitThreads.Location = new System.Drawing.Point(281, 81);
            this.lbWaitThreads.Name = "lbWaitThreads";
            this.lbWaitThreads.Size = new System.Drawing.Size(225, 143);
            this.lbWaitThreads.TabIndex = 6;
            // 
            // lbCreatedThreads
            // 
            this.lbCreatedThreads.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.lbCreatedThreads.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbCreatedThreads.ForeColor = System.Drawing.Color.White;
            this.lbCreatedThreads.FormattingEnabled = true;
            this.lbCreatedThreads.Location = new System.Drawing.Point(535, 81);
            this.lbCreatedThreads.Name = "lbCreatedThreads";
            this.lbCreatedThreads.Size = new System.Drawing.Size(225, 143);
            this.lbCreatedThreads.TabIndex = 7;
            this.lbCreatedThreads.DoubleClick += new System.EventHandler(this.lbCreatedThreads_DoubleClick_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(277, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ожидающие потоки";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(531, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Созданные потоки";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(798, 343);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbCreatedThreads);
            this.Controls.Add(this.lbWaitThreads);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbWorkedThreads);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AbortThreadsOnClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbWorkedThreads;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbWaitThreads;
        private System.Windows.Forms.ListBox lbCreatedThreads;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

