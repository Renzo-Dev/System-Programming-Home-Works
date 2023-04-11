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
            this.BFindWindow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbEntTitleWindow = new System.Windows.Forms.TextBox();
            this.ResultBox = new System.Windows.Forms.PictureBox();
            this.bChTitle = new System.Windows.Forms.Button();
            this.BClose = new System.Windows.Forms.Button();
            this.tbChTitle = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ResultBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BFindWindow
            // 
            this.BFindWindow.Location = new System.Drawing.Point(384, 176);
            this.BFindWindow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BFindWindow.Name = "BFindWindow";
            this.BFindWindow.Size = new System.Drawing.Size(184, 31);
            this.BFindWindow.TabIndex = 0;
            this.BFindWindow.Text = "Найти окно";
            this.BFindWindow.UseVisualStyleBackColor = true;
            this.BFindWindow.Click += new System.EventHandler(this.BFindWindow_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(332, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите Заголовок Окна";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbEntTitleWindow
            // 
            this.tbEntTitleWindow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEntTitleWindow.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbEntTitleWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbEntTitleWindow.Location = new System.Drawing.Point(384, 111);
            this.tbEntTitleWindow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbEntTitleWindow.MaxLength = 300;
            this.tbEntTitleWindow.Name = "tbEntTitleWindow";
            this.tbEntTitleWindow.Size = new System.Drawing.Size(317, 23);
            this.tbEntTitleWindow.TabIndex = 2;
            // 
            // ResultBox
            // 
            this.ResultBox.BackColor = System.Drawing.Color.Red;
            this.ResultBox.Location = new System.Drawing.Point(605, 176);
            this.ResultBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(39, 31);
            this.ResultBox.TabIndex = 3;
            this.ResultBox.TabStop = false;
            // 
            // bChTitle
            // 
            this.bChTitle.Location = new System.Drawing.Point(384, 251);
            this.bChTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bChTitle.Name = "bChTitle";
            this.bChTitle.Size = new System.Drawing.Size(184, 38);
            this.bChTitle.TabIndex = 4;
            this.bChTitle.Text = "Изминить Заголовок";
            this.bChTitle.UseVisualStyleBackColor = true;
            this.bChTitle.Click += new System.EventHandler(this.bChTitle_Click);
            // 
            // BClose
            // 
            this.BClose.Location = new System.Drawing.Point(384, 297);
            this.BClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BClose.Name = "BClose";
            this.BClose.Size = new System.Drawing.Size(184, 38);
            this.BClose.TabIndex = 5;
            this.BClose.Text = "Закрыть Окно";
            this.BClose.UseVisualStyleBackColor = true;
            this.BClose.Click += new System.EventHandler(this.BClose_Click);
            // 
            // tbChTitle
            // 
            this.tbChTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbChTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbChTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbChTitle.Location = new System.Drawing.Point(605, 251);
            this.tbChTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbChTitle.MaxLength = 300;
            this.tbChTitle.Name = "tbChTitle";
            this.tbChTitle.Size = new System.Drawing.Size(317, 23);
            this.tbChTitle.TabIndex = 6;
            // 
            // Task2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1167, 678);
            this.Controls.Add(this.tbChTitle);
            this.Controls.Add(this.BClose);
            this.Controls.Add(this.bChTitle);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.tbEntTitleWindow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BFindWindow);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Task2";
            this.Text = "Task2";
            this.Load += new System.EventHandler(this.Task2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ResultBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BFindWindow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbEntTitleWindow;
        private System.Windows.Forms.PictureBox ResultBox;
        private System.Windows.Forms.Button bChTitle;
        private System.Windows.Forms.Button BClose;
        private System.Windows.Forms.TextBox tbChTitle;
    }
}