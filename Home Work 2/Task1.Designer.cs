namespace WindowsFormsApp1
{
    partial class Task1
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.lExidCode = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lProcesStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(269, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 74);
            this.button1.TabIndex = 0;
            this.button1.Text = "Запустить процесс";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lExidCode
            // 
            this.lExidCode.AutoSize = true;
            this.lExidCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lExidCode.ForeColor = System.Drawing.Color.White;
            this.lExidCode.Location = new System.Drawing.Point(226, 100);
            this.lExidCode.Name = "lExidCode";
            this.lExidCode.Size = new System.Drawing.Size(85, 20);
            this.lExidCode.TabIndex = 3;
            this.lExidCode.Text = "ExidCode: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(226, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Состояние: ";
            // 
            // lProcesStatus
            // 
            this.lProcesStatus.AutoSize = true;
            this.lProcesStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lProcesStatus.ForeColor = System.Drawing.Color.Red;
            this.lProcesStatus.Location = new System.Drawing.Point(331, 58);
            this.lProcesStatus.Name = "lProcesStatus";
            this.lProcesStatus.Size = new System.Drawing.Size(98, 20);
            this.lProcesStatus.TabIndex = 5;
            this.lProcesStatus.Text = "Не запущен";
            // 
            // Task1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lProcesStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lExidCode);
            this.Controls.Add(this.button1);
            this.Name = "Task1";
            this.Text = "Task1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label lExidCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lProcesStatus;
    }
}