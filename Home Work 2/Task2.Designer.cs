namespace WindowsFormsApp1
{
    partial class Task2
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
            this.label2 = new System.Windows.Forms.Label();
            this.lProcesStatus = new System.Windows.Forms.Label();
            this.lExidCode = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.ckbWaitProcess = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(155, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Запустить процесс";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(176, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Состояние: ";
            // 
            // lProcesStatus
            // 
            this.lProcesStatus.AutoSize = true;
            this.lProcesStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lProcesStatus.ForeColor = System.Drawing.Color.Red;
            this.lProcesStatus.Location = new System.Drawing.Point(292, 85);
            this.lProcesStatus.Name = "lProcesStatus";
            this.lProcesStatus.Size = new System.Drawing.Size(98, 20);
            this.lProcesStatus.TabIndex = 6;
            this.lProcesStatus.Text = "Не запущен";
            // 
            // lExidCode
            // 
            this.lExidCode.AutoSize = true;
            this.lExidCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lExidCode.ForeColor = System.Drawing.Color.White;
            this.lExidCode.Location = new System.Drawing.Point(176, 116);
            this.lExidCode.Name = "lExidCode";
            this.lExidCode.Size = new System.Drawing.Size(85, 20);
            this.lExidCode.TabIndex = 7;
            this.lExidCode.Text = "ExidCode: ";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(378, 256);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 46);
            this.button2.TabIndex = 8;
            this.button2.Text = "Завершить процесс";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ckbWaitProcess
            // 
            this.ckbWaitProcess.AutoSize = true;
            this.ckbWaitProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ckbWaitProcess.ForeColor = System.Drawing.Color.White;
            this.ckbWaitProcess.Location = new System.Drawing.Point(181, 182);
            this.ckbWaitProcess.Name = "ckbWaitProcess";
            this.ckbWaitProcess.Size = new System.Drawing.Size(350, 24);
            this.ckbWaitProcess.TabIndex = 9;
            this.ckbWaitProcess.Text = "Ожидать закрытия запущенного процесса";
            this.ckbWaitProcess.UseVisualStyleBackColor = true;
            this.ckbWaitProcess.CheckedChanged += new System.EventHandler(this.ckbWaitProcess_CheckedChanged);
            // 
            // Task2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ckbWaitProcess);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lExidCode);
            this.Controls.Add(this.lProcesStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Name = "Task2";
            this.Text = "Task2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lProcesStatus;
        private System.Windows.Forms.Label lExidCode;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox ckbWaitProcess;
    }
}