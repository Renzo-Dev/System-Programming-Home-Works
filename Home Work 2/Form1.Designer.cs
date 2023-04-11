namespace WindowsFormsApp1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bTask1 = new System.Windows.Forms.Button();
            this.bTask2 = new System.Windows.Forms.Button();
            this.bTask3 = new System.Windows.Forms.Button();
            this.bTask4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Location = new System.Drawing.Point(215, -4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1121, 657);
            this.panel1.TabIndex = 1;
            // 
            // bTask1
            // 
            this.bTask1.Location = new System.Drawing.Point(29, 47);
            this.bTask1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bTask1.Name = "bTask1";
            this.bTask1.Size = new System.Drawing.Size(153, 66);
            this.bTask1.TabIndex = 2;
            this.bTask1.Text = "Task 1";
            this.bTask1.UseVisualStyleBackColor = true;
            this.bTask1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // bTask2
            // 
            this.bTask2.Location = new System.Drawing.Point(29, 140);
            this.bTask2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bTask2.Name = "bTask2";
            this.bTask2.Size = new System.Drawing.Size(153, 66);
            this.bTask2.TabIndex = 3;
            this.bTask2.Text = "Task 2";
            this.bTask2.UseVisualStyleBackColor = true;
            this.bTask2.Click += new System.EventHandler(this.bTask2_Click);
            // 
            // bTask3
            // 
            this.bTask3.Location = new System.Drawing.Point(29, 231);
            this.bTask3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bTask3.Name = "bTask3";
            this.bTask3.Size = new System.Drawing.Size(153, 66);
            this.bTask3.TabIndex = 4;
            this.bTask3.Text = "Task 3";
            this.bTask3.UseVisualStyleBackColor = true;
            this.bTask3.Click += new System.EventHandler(this.bTask3_Click);
            // 
            // bTask4
            // 
            this.bTask4.Location = new System.Drawing.Point(29, 320);
            this.bTask4.Margin = new System.Windows.Forms.Padding(4);
            this.bTask4.Name = "bTask4";
            this.bTask4.Size = new System.Drawing.Size(153, 66);
            this.bTask4.TabIndex = 5;
            this.bTask4.Text = "Task 4";
            this.bTask4.UseVisualStyleBackColor = true;
            this.bTask4.Click += new System.EventHandler(this.bTask4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1337, 650);
            this.Controls.Add(this.bTask4);
            this.Controls.Add(this.bTask3);
            this.Controls.Add(this.bTask2);
            this.Controls.Add(this.bTask1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bTask1;
        private System.Windows.Forms.Button bTask2;
        private System.Windows.Forms.Button bTask3;
        private System.Windows.Forms.Button bTask4;
    }
}

