namespace Home_Work_4
{
    partial class Task4
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
            this.bOpen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbWord1 = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tbPathToFile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lCount1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbWord2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lCount2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bOpen
            // 
            this.bOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.bOpen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bOpen.ForeColor = System.Drawing.Color.White;
            this.bOpen.Location = new System.Drawing.Point(156, 54);
            this.bOpen.Name = "bOpen";
            this.bOpen.Size = new System.Drawing.Size(117, 23);
            this.bOpen.TabIndex = 0;
            this.bOpen.Text = "Выбрать";
            this.bOpen.UseVisualStyleBackColor = false;
            this.bOpen.Click += new System.EventHandler(this.bOpen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Путь к файлу";
            // 
            // tbWord1
            // 
            this.tbWord1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tbWord1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbWord1.Enabled = false;
            this.tbWord1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbWord1.ForeColor = System.Drawing.Color.White;
            this.tbWord1.Location = new System.Drawing.Point(23, 226);
            this.tbWord1.Name = "tbWord1";
            this.tbWord1.Size = new System.Drawing.Size(405, 25);
            this.tbWord1.TabIndex = 3;
            this.tbWord1.TextChanged += new System.EventHandler(this.tbWord_TextChanged);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            this.openFileDialog.InitialDirectory = "C:\\";
            // 
            // tbPathToFile
            // 
            this.tbPathToFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tbPathToFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPathToFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPathToFile.ForeColor = System.Drawing.Color.White;
            this.tbPathToFile.Location = new System.Drawing.Point(23, 90);
            this.tbPathToFile.Multiline = true;
            this.tbPathToFile.Name = "tbPathToFile";
            this.tbPathToFile.ReadOnly = true;
            this.tbPathToFile.Size = new System.Drawing.Size(405, 80);
            this.tbPathToFile.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Слово для поиска в файле";
            // 
            // lCount1
            // 
            this.lCount1.AutoSize = true;
            this.lCount1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lCount1.ForeColor = System.Drawing.Color.White;
            this.lCount1.Location = new System.Drawing.Point(172, 254);
            this.lCount1.Name = "lCount1";
            this.lCount1.Size = new System.Drawing.Size(18, 20);
            this.lCount1.TabIndex = 5;
            this.lCount1.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(19, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Кол.слов в тексте: ";
            // 
            // tbWord2
            // 
            this.tbWord2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tbWord2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbWord2.Enabled = false;
            this.tbWord2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbWord2.ForeColor = System.Drawing.Color.White;
            this.tbWord2.Location = new System.Drawing.Point(23, 287);
            this.tbWord2.Name = "tbWord2";
            this.tbWord2.Size = new System.Drawing.Size(405, 25);
            this.tbWord2.TabIndex = 7;
            this.tbWord2.TextChanged += new System.EventHandler(this.tbWord2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(19, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Кол.слов в тексте: ";
            // 
            // lCount2
            // 
            this.lCount2.AutoSize = true;
            this.lCount2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lCount2.ForeColor = System.Drawing.Color.White;
            this.lCount2.Location = new System.Drawing.Point(172, 315);
            this.lCount2.Name = "lCount2";
            this.lCount2.Size = new System.Drawing.Size(18, 20);
            this.lCount2.TabIndex = 8;
            this.lCount2.Text = "0";
            // 
            // Task4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(714, 481);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lCount2);
            this.Controls.Add(this.tbWord2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lCount1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbWord1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPathToFile);
            this.Controls.Add(this.bOpen);
            this.Name = "Task4";
            this.Text = "Task4";
            this.Load += new System.EventHandler(this.Task4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bOpen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbWord1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox tbPathToFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lCount1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbWord2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lCount2;
    }
}