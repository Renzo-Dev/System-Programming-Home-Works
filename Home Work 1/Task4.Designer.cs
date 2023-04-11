namespace WindowsFormsApp1
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
            this.bFindWindow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbEntTitleWnd = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picResultFind = new System.Windows.Forms.PictureBox();
            this.lsbStyles = new System.Windows.Forms.ListBox();
            this.lsbStylesEx = new System.Windows.Forms.ListBox();
            this.LwndStyles = new System.Windows.Forms.Label();
            this.LwndStylesEx = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picResultFind)).BeginInit();
            this.SuspendLayout();
            // 
            // bFindWindow
            // 
            this.bFindWindow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bFindWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bFindWindow.Location = new System.Drawing.Point(36, 114);
            this.bFindWindow.Name = "bFindWindow";
            this.bFindWindow.Size = new System.Drawing.Size(156, 36);
            this.bFindWindow.TabIndex = 2;
            this.bFindWindow.Text = "Найти";
            this.bFindWindow.UseVisualStyleBackColor = true;
            this.bFindWindow.Click += new System.EventHandler(this.bFindWindow_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 52);
            this.label1.TabIndex = 3;
            this.label1.Text = "     Поиск по      \r\nзаголовку окна";
            // 
            // tbEntTitleWnd
            // 
            this.tbEntTitleWnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEntTitleWnd.Location = new System.Drawing.Point(7, 68);
            this.tbEntTitleWnd.Name = "tbEntTitleWnd";
            this.tbEntTitleWnd.Size = new System.Drawing.Size(200, 22);
            this.tbEntTitleWnd.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.picResultFind);
            this.panel1.Controls.Add(this.tbEntTitleWnd);
            this.panel1.Controls.Add(this.bFindWindow);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 202);
            this.panel1.TabIndex = 5;
            // 
            // picResultFind
            // 
            this.picResultFind.BackColor = System.Drawing.Color.Red;
            this.picResultFind.Location = new System.Drawing.Point(53, 172);
            this.picResultFind.Name = "picResultFind";
            this.picResultFind.Size = new System.Drawing.Size(126, 27);
            this.picResultFind.TabIndex = 5;
            this.picResultFind.TabStop = false;
            // 
            // lsbStyles
            // 
            this.lsbStyles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lsbStyles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsbStyles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lsbStyles.ForeColor = System.Drawing.Color.White;
            this.lsbStyles.FormattingEnabled = true;
            this.lsbStyles.ItemHeight = 20;
            this.lsbStyles.Location = new System.Drawing.Point(307, 68);
            this.lsbStyles.Name = "lsbStyles";
            this.lsbStyles.Size = new System.Drawing.Size(337, 422);
            this.lsbStyles.TabIndex = 6;
            this.lsbStyles.Visible = false;
            this.lsbStyles.DoubleClick += new System.EventHandler(this.lsbStyles_MouseDoubleClick);
            // 
            // lsbStylesEx
            // 
            this.lsbStylesEx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lsbStylesEx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsbStylesEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lsbStylesEx.ForeColor = System.Drawing.Color.White;
            this.lsbStylesEx.FormattingEnabled = true;
            this.lsbStylesEx.ItemHeight = 20;
            this.lsbStylesEx.Location = new System.Drawing.Point(682, 68);
            this.lsbStylesEx.Name = "lsbStylesEx";
            this.lsbStylesEx.Size = new System.Drawing.Size(337, 422);
            this.lsbStylesEx.TabIndex = 7;
            this.lsbStylesEx.Visible = false;
            this.lsbStylesEx.DoubleClick += new System.EventHandler(this.lsbStylesEx_DoubleClick);
            // 
            // LwndStyles
            // 
            this.LwndStyles.AutoSize = true;
            this.LwndStyles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LwndStyles.ForeColor = System.Drawing.Color.White;
            this.LwndStyles.Location = new System.Drawing.Point(304, 31);
            this.LwndStyles.Name = "LwndStyles";
            this.LwndStyles.Size = new System.Drawing.Size(122, 25);
            this.LwndStyles.TabIndex = 9;
            this.LwndStyles.Text = "Стили Окна";
            this.LwndStyles.Visible = false;
            // 
            // LwndStylesEx
            // 
            this.LwndStylesEx.AutoSize = true;
            this.LwndStylesEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LwndStylesEx.ForeColor = System.Drawing.Color.White;
            this.LwndStylesEx.Location = new System.Drawing.Point(677, 23);
            this.LwndStylesEx.Name = "LwndStylesEx";
            this.LwndStylesEx.Size = new System.Drawing.Size(248, 25);
            this.LwndStylesEx.TabIndex = 10;
            this.LwndStylesEx.Text = "Расширенные стили окна";
            this.LwndStylesEx.Visible = false;
            // 
            // Task4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.LwndStylesEx);
            this.Controls.Add(this.LwndStyles);
            this.Controls.Add(this.lsbStylesEx);
            this.Controls.Add(this.lsbStyles);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Task4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task4";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picResultFind)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bFindWindow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbEntTitleWnd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picResultFind;
        private System.Windows.Forms.ListBox lsbStyles;
        private System.Windows.Forms.ListBox lsbStylesEx;
        private System.Windows.Forms.Label LwndStyles;
        private System.Windows.Forms.Label LwndStylesEx;
    }
}