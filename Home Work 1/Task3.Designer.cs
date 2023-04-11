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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.RbMesBeep = new System.Windows.Forms.RadioButton();
            this.MesBeepPanel = new System.Windows.Forms.Panel();
            this.LBSeelctSound = new System.Windows.Forms.ListBox();
            this.BeepPanel = new System.Windows.Forms.Panel();
            this.bAddSound = new System.Windows.Forms.Button();
            this.TBDuration = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TBFreq = new System.Windows.Forms.TextBox();
            this.RbBeep = new System.Windows.Forms.RadioButton();
            this.BPlay = new System.Windows.Forms.Button();
            this.dgvListSounds = new System.Windows.Forms.DataGridView();
            this.FreqColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DurationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bPlayPanel = new System.Windows.Forms.Button();
            this.MesBeepPanel.SuspendLayout();
            this.BeepPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListSounds)).BeginInit();
            this.SuspendLayout();
            // 
            // RbMesBeep
            // 
            this.RbMesBeep.AutoSize = true;
            this.RbMesBeep.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RbMesBeep.ForeColor = System.Drawing.Color.White;
            this.RbMesBeep.Location = new System.Drawing.Point(672, 63);
            this.RbMesBeep.Margin = new System.Windows.Forms.Padding(4);
            this.RbMesBeep.Name = "RbMesBeep";
            this.RbMesBeep.Size = new System.Drawing.Size(197, 33);
            this.RbMesBeep.TabIndex = 2;
            this.RbMesBeep.Text = "Message Beep";
            this.RbMesBeep.UseVisualStyleBackColor = true;
            this.RbMesBeep.CheckedChanged += new System.EventHandler(this.check);
            // 
            // MesBeepPanel
            // 
            this.MesBeepPanel.Controls.Add(this.LBSeelctSound);
            this.MesBeepPanel.Location = new System.Drawing.Point(607, 122);
            this.MesBeepPanel.Margin = new System.Windows.Forms.Padding(4);
            this.MesBeepPanel.Name = "MesBeepPanel";
            this.MesBeepPanel.Size = new System.Drawing.Size(367, 191);
            this.MesBeepPanel.TabIndex = 8;
            // 
            // LBSeelctSound
            // 
            this.LBSeelctSound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.LBSeelctSound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LBSeelctSound.ForeColor = System.Drawing.Color.White;
            this.LBSeelctSound.FormattingEnabled = true;
            this.LBSeelctSound.ItemHeight = 25;
            this.LBSeelctSound.Items.AddRange(new object[] {
            "Simple Beep",
            "Windows Asterisk",
            "Windows Critical Stop",
            "Windows Question",
            "Windows Exclamation",
            "Windows Default Beep"});
            this.LBSeelctSound.Location = new System.Drawing.Point(65, 16);
            this.LBSeelctSound.Margin = new System.Windows.Forms.Padding(4);
            this.LBSeelctSound.Name = "LBSeelctSound";
            this.LBSeelctSound.Size = new System.Drawing.Size(228, 129);
            this.LBSeelctSound.TabIndex = 12;
            // 
            // BeepPanel
            // 
            this.BeepPanel.Controls.Add(this.bPlayPanel);
            this.BeepPanel.Controls.Add(this.bAddSound);
            this.BeepPanel.Controls.Add(this.TBDuration);
            this.BeepPanel.Controls.Add(this.label2);
            this.BeepPanel.Controls.Add(this.label1);
            this.BeepPanel.Controls.Add(this.TBFreq);
            this.BeepPanel.Location = new System.Drawing.Point(25, 122);
            this.BeepPanel.Margin = new System.Windows.Forms.Padding(4);
            this.BeepPanel.Name = "BeepPanel";
            this.BeepPanel.Size = new System.Drawing.Size(190, 208);
            this.BeepPanel.TabIndex = 9;
            // 
            // bAddSound
            // 
            this.bAddSound.Location = new System.Drawing.Point(9, 151);
            this.bAddSound.Name = "bAddSound";
            this.bAddSound.Size = new System.Drawing.Size(75, 23);
            this.bAddSound.TabIndex = 4;
            this.bAddSound.Text = "Add";
            this.bAddSound.UseVisualStyleBackColor = true;
            this.bAddSound.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // TBDuration
            // 
            this.TBDuration.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBDuration.Location = new System.Drawing.Point(9, 103);
            this.TBDuration.Margin = new System.Windows.Forms.Padding(4);
            this.TBDuration.Name = "TBDuration";
            this.TBDuration.Size = new System.Drawing.Size(163, 21);
            this.TBDuration.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Duration";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Freq";
            // 
            // TBFreq
            // 
            this.TBFreq.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBFreq.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBFreq.Location = new System.Drawing.Point(9, 48);
            this.TBFreq.Margin = new System.Windows.Forms.Padding(4);
            this.TBFreq.Name = "TBFreq";
            this.TBFreq.Size = new System.Drawing.Size(163, 21);
            this.TBFreq.TabIndex = 0;
            this.TBFreq.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckNumber);
            // 
            // RbBeep
            // 
            this.RbBeep.AutoSize = true;
            this.RbBeep.Checked = true;
            this.RbBeep.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RbBeep.ForeColor = System.Drawing.Color.White;
            this.RbBeep.Location = new System.Drawing.Point(195, 63);
            this.RbBeep.Margin = new System.Windows.Forms.Padding(4);
            this.RbBeep.Name = "RbBeep";
            this.RbBeep.Size = new System.Drawing.Size(92, 33);
            this.RbBeep.TabIndex = 1;
            this.RbBeep.TabStop = true;
            this.RbBeep.Text = "Beep";
            this.RbBeep.UseVisualStyleBackColor = true;
            // 
            // BPlay
            // 
            this.BPlay.Location = new System.Drawing.Point(259, 303);
            this.BPlay.Margin = new System.Windows.Forms.Padding(4);
            this.BPlay.Name = "BPlay";
            this.BPlay.Size = new System.Drawing.Size(164, 42);
            this.BPlay.TabIndex = 10;
            this.BPlay.Text = "Play";
            this.BPlay.UseVisualStyleBackColor = true;
            this.BPlay.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvListSounds
            // 
            this.dgvListSounds.AllowUserToAddRows = false;
            this.dgvListSounds.AllowUserToDeleteRows = false;
            this.dgvListSounds.AllowUserToResizeColumns = false;
            this.dgvListSounds.AllowUserToResizeRows = false;
            this.dgvListSounds.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.dgvListSounds.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListSounds.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvListSounds.ColumnHeadersHeight = 29;
            this.dgvListSounds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvListSounds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FreqColumn,
            this.DurationColumn});
            this.dgvListSounds.Location = new System.Drawing.Point(241, 139);
            this.dgvListSounds.Name = "dgvListSounds";
            this.dgvListSounds.ReadOnly = true;
            this.dgvListSounds.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvListSounds.RowHeadersVisible = false;
            this.dgvListSounds.RowHeadersWidth = 51;
            this.dgvListSounds.RowTemplate.Height = 24;
            this.dgvListSounds.ShowEditingIcon = false;
            this.dgvListSounds.Size = new System.Drawing.Size(197, 157);
            this.dgvListSounds.TabIndex = 11;
            // 
            // FreqColumn
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            this.FreqColumn.DefaultCellStyle = dataGridViewCellStyle13;
            this.FreqColumn.Frozen = true;
            this.FreqColumn.HeaderText = "Freq";
            this.FreqColumn.MinimumWidth = 6;
            this.FreqColumn.Name = "FreqColumn";
            this.FreqColumn.ReadOnly = true;
            this.FreqColumn.ToolTipText = "Частота звука";
            this.FreqColumn.Width = 70;
            // 
            // DurationColumn
            // 
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            this.DurationColumn.DefaultCellStyle = dataGridViewCellStyle14;
            this.DurationColumn.Frozen = true;
            this.DurationColumn.HeaderText = "Duration";
            this.DurationColumn.MinimumWidth = 6;
            this.DurationColumn.Name = "DurationColumn";
            this.DurationColumn.ReadOnly = true;
            this.DurationColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DurationColumn.ToolTipText = "Продолжительность звука";
            this.DurationColumn.Width = 70;
            // 
            // bPlayPanel
            // 
            this.bPlayPanel.Location = new System.Drawing.Point(97, 151);
            this.bPlayPanel.Name = "bPlayPanel";
            this.bPlayPanel.Size = new System.Drawing.Size(75, 23);
            this.bPlayPanel.TabIndex = 5;
            this.bPlayPanel.Text = "Play";
            this.bPlayPanel.UseVisualStyleBackColor = true;
            this.bPlayPanel.Click += new System.EventHandler(this.bPlayPanel_Click);
            // 
            // Task3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dgvListSounds);
            this.Controls.Add(this.BPlay);
            this.Controls.Add(this.BeepPanel);
            this.Controls.Add(this.MesBeepPanel);
            this.Controls.Add(this.RbMesBeep);
            this.Controls.Add(this.RbBeep);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Task3";
            this.Text = "Task3";
            this.Load += new System.EventHandler(this.Task3_Load);
            this.MesBeepPanel.ResumeLayout(false);
            this.BeepPanel.ResumeLayout(false);
            this.BeepPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListSounds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton RbMesBeep;
        private System.Windows.Forms.Panel MesBeepPanel;
        private System.Windows.Forms.Panel BeepPanel;
        private System.Windows.Forms.RadioButton RbBeep;
        private System.Windows.Forms.Button BPlay;
        private System.Windows.Forms.ListBox LBSeelctSound;
        private System.Windows.Forms.TextBox TBFreq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBDuration;
        private System.Windows.Forms.Button bAddSound;
        private System.Windows.Forms.DataGridView dgvListSounds;
        private System.Windows.Forms.DataGridViewTextBoxColumn FreqColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DurationColumn;
        private System.Windows.Forms.Button bPlayPanel;
    }
}