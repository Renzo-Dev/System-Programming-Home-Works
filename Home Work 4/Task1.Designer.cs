namespace Home_Work_4
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
            this.FLPBars = new System.Windows.Forms.FlowLayoutPanel();
            this.bStart = new System.Windows.Forms.Button();
            this.tbNumBars = new System.Windows.Forms.TextBox();
            this.lbNumBars = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FLPBars
            // 
            this.FLPBars.AutoScroll = true;
            this.FLPBars.Location = new System.Drawing.Point(148, 9);
            this.FLPBars.Margin = new System.Windows.Forms.Padding(0);
            this.FLPBars.Name = "FLPBars";
            this.FLPBars.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.FLPBars.Size = new System.Drawing.Size(557, 463);
            this.FLPBars.TabIndex = 0;
            // 
            // bStart
            // 
            this.bStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.bStart.FlatAppearance.BorderSize = 0;
            this.bStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bStart.ForeColor = System.Drawing.Color.White;
            this.bStart.Location = new System.Drawing.Point(12, 173);
            this.bStart.Name = "bStart";
            this.bStart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bStart.Size = new System.Drawing.Size(122, 48);
            this.bStart.TabIndex = 1;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = false;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // tbNumBars
            // 
            this.tbNumBars.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tbNumBars.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNumBars.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbNumBars.ForeColor = System.Drawing.Color.White;
            this.tbNumBars.Location = new System.Drawing.Point(12, 132);
            this.tbNumBars.Name = "tbNumBars";
            this.tbNumBars.Size = new System.Drawing.Size(122, 22);
            this.tbNumBars.TabIndex = 2;
            this.tbNumBars.TextChanged += new System.EventHandler(this.tbNumBars_TextChanged);
            // 
            // lbNumBars
            // 
            this.lbNumBars.AutoSize = true;
            this.lbNumBars.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbNumBars.ForeColor = System.Drawing.Color.White;
            this.lbNumBars.Location = new System.Drawing.Point(23, 94);
            this.lbNumBars.Name = "lbNumBars";
            this.lbNumBars.Size = new System.Drawing.Size(94, 22);
            this.lbNumBars.TabIndex = 3;
            this.lbNumBars.Text = "кол баров";
            // 
            // Task1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(714, 481);
            this.Controls.Add(this.lbNumBars);
            this.Controls.Add(this.tbNumBars);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.FLPBars);
            this.Name = "Task1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FLPBars;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.TextBox tbNumBars;
        private System.Windows.Forms.Label lbNumBars;
    }
}