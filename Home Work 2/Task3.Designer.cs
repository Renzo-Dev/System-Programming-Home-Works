namespace WindowsFormsApp1
{
    partial class Task3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.lArg3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lArg2 = new System.Windows.Forms.Label();
            this.lArg1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(361, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 51);
            this.button1.TabIndex = 8;
            this.button1.Text = "Запустить с агрументами";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lArg3
            // 
            this.lArg3.AutoSize = true;
            this.lArg3.ForeColor = System.Drawing.Color.White;
            this.lArg3.Location = new System.Drawing.Point(558, 172);
            this.lArg3.Name = "lArg3";
            this.lArg3.Size = new System.Drawing.Size(80, 16);
            this.lArg3.TabIndex = 7;
            this.lArg3.Text = "Аргумент 3";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(422, 203);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(561, 203);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 4;
            // 
            // lArg2
            // 
            this.lArg2.AutoSize = true;
            this.lArg2.ForeColor = System.Drawing.Color.White;
            this.lArg2.Location = new System.Drawing.Point(419, 172);
            this.lArg2.Name = "lArg2";
            this.lArg2.Size = new System.Drawing.Size(80, 16);
            this.lArg2.TabIndex = 6;
            this.lArg2.Text = "Аргумент 2";
            // 
            // lArg1
            // 
            this.lArg1.AutoSize = true;
            this.lArg1.ForeColor = System.Drawing.Color.White;
            this.lArg1.Location = new System.Drawing.Point(263, 172);
            this.lArg1.Name = "lArg1";
            this.lArg1.Size = new System.Drawing.Size(80, 16);
            this.lArg1.TabIndex = 5;
            this.lArg1.Text = "Аргумент 1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(266, 203);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            // 
            // Task3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1096, 574);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lArg3);
            this.Controls.Add(this.lArg2);
            this.Controls.Add(this.lArg1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Task3";
            this.Text = "Task3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lArg3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lArg2;
        private System.Windows.Forms.Label lArg1;
        private System.Windows.Forms.TextBox textBox1;
    }
}