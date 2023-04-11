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
            this.BTask1 = new System.Windows.Forms.Button();
            this.BTask2 = new System.Windows.Forms.Button();
            this.BTask3 = new System.Windows.Forms.Button();
            this.BTask4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.panel1.Location = new System.Drawing.Point(248, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1225, 704);
            this.panel1.TabIndex = 0;
            // 
            // BTask1
            // 
            this.BTask1.Location = new System.Drawing.Point(16, 15);
            this.BTask1.Margin = new System.Windows.Forms.Padding(4);
            this.BTask1.Name = "BTask1";
            this.BTask1.Size = new System.Drawing.Size(212, 62);
            this.BTask1.TabIndex = 1;
            this.BTask1.Text = "Task 1";
            this.BTask1.UseVisualStyleBackColor = true;
            this.BTask1.Click += new System.EventHandler(this.BTask1_Click);
            // 
            // BTask2
            // 
            this.BTask2.Location = new System.Drawing.Point(16, 84);
            this.BTask2.Margin = new System.Windows.Forms.Padding(4);
            this.BTask2.Name = "BTask2";
            this.BTask2.Size = new System.Drawing.Size(212, 62);
            this.BTask2.TabIndex = 2;
            this.BTask2.Text = "Task 2";
            this.BTask2.UseVisualStyleBackColor = true;
            this.BTask2.Click += new System.EventHandler(this.BTask2_Click);
            // 
            // BTask3
            // 
            this.BTask3.Location = new System.Drawing.Point(16, 153);
            this.BTask3.Margin = new System.Windows.Forms.Padding(4);
            this.BTask3.Name = "BTask3";
            this.BTask3.Size = new System.Drawing.Size(212, 62);
            this.BTask3.TabIndex = 3;
            this.BTask3.Text = "Task 3";
            this.BTask3.UseVisualStyleBackColor = true;
            this.BTask3.Click += new System.EventHandler(this.BTask3_Click);
            // 
            // BTask4
            // 
            this.BTask4.Location = new System.Drawing.Point(16, 222);
            this.BTask4.Margin = new System.Windows.Forms.Padding(4);
            this.BTask4.Name = "BTask4";
            this.BTask4.Size = new System.Drawing.Size(212, 62);
            this.BTask4.TabIndex = 4;
            this.BTask4.Text = "Task 4";
            this.BTask4.UseVisualStyleBackColor = true;
            this.BTask4.Click += new System.EventHandler(this.BTask4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1473, 703);
            this.Controls.Add(this.BTask4);
            this.Controls.Add(this.BTask3);
            this.Controls.Add(this.BTask2);
            this.Controls.Add(this.BTask1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BTask1;
        private System.Windows.Forms.Button BTask2;
        private System.Windows.Forms.Button BTask3;
        private System.Windows.Forms.Button BTask4;
    }
}

