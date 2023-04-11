namespace Home_Work_4
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
            this.tbMaxF = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbFibonacchi1 = new System.Windows.Forms.ListBox();
            this.lbFibonacchi2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(108, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 67);
            this.button1.TabIndex = 1;
            this.button1.Text = "Запустить генерацию";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbMaxF
            // 
            this.tbMaxF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tbMaxF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMaxF.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbMaxF.ForeColor = System.Drawing.Color.White;
            this.tbMaxF.Location = new System.Drawing.Point(42, 125);
            this.tbMaxF.Name = "tbMaxF";
            this.tbMaxF.Size = new System.Drawing.Size(317, 23);
            this.tbMaxF.TabIndex = 2;
            this.tbMaxF.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(37, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Максимальное число Фибоначчи";
            // 
            // lbFibonacchi1
            // 
            this.lbFibonacchi1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.lbFibonacchi1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbFibonacchi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbFibonacchi1.ForeColor = System.Drawing.Color.White;
            this.lbFibonacchi1.FormattingEnabled = true;
            this.lbFibonacchi1.ItemHeight = 25;
            this.lbFibonacchi1.Location = new System.Drawing.Point(389, 12);
            this.lbFibonacchi1.Name = "lbFibonacchi1";
            this.lbFibonacchi1.Size = new System.Drawing.Size(155, 452);
            this.lbFibonacchi1.TabIndex = 0;
            // 
            // lbFibonacchi2
            // 
            this.lbFibonacchi2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.lbFibonacchi2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbFibonacchi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbFibonacchi2.ForeColor = System.Drawing.Color.White;
            this.lbFibonacchi2.FormattingEnabled = true;
            this.lbFibonacchi2.ItemHeight = 25;
            this.lbFibonacchi2.Location = new System.Drawing.Point(550, 12);
            this.lbFibonacchi2.Name = "lbFibonacchi2";
            this.lbFibonacchi2.Size = new System.Drawing.Size(155, 452);
            this.lbFibonacchi2.TabIndex = 4;
            // 
            // Task3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(714, 481);
            this.Controls.Add(this.lbFibonacchi2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMaxF);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbFibonacchi1);
            this.Name = "Task3";
            this.Text = "Task3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbMaxF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbFibonacchi1;
        private System.Windows.Forms.ListBox lbFibonacchi2;
    }
}