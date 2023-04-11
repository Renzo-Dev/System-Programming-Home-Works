using System.Threading;

namespace Home_Work_5
{
    partial class Task1_2_3
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.DGV_FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_PathToFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.ckbWord = new System.Windows.Forms.CheckBox();
            this.ckbSymbol = new System.Windows.Forms.CheckBox();
            this.ckbSentence = new System.Windows.Forms.CheckBox();
            this.task123BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.task123BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbText
            // 
            this.tbText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tbText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbText.ForeColor = System.Drawing.Color.White;
            this.tbText.Location = new System.Drawing.Point(296, 41);
            this.tbText.Margin = new System.Windows.Forms.Padding(1);
            this.tbText.Multiline = true;
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(635, 268);
            this.tbText.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(305, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "ТЕКСТ";
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.AllowUserToResizeColumns = false;
            this.DGV.AllowUserToResizeRows = false;
            this.DGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.DGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGV.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.DGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGV_FileName,
            this.DGV_PathToFile});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGV.EnableHeadersVisualStyles = false;
            this.DGV.Location = new System.Drawing.Point(12, 41);
            this.DGV.MultiSelect = false;
            this.DGV.Name = "DGV";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV.RowHeadersVisible = false;
            this.DGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DGV.Size = new System.Drawing.Size(241, 268);
            this.DGV.TabIndex = 2;
            // 
            // DGV_FileName
            // 
            this.DGV_FileName.HeaderText = "Тип";
            this.DGV_FileName.Name = "DGV_FileName";
            this.DGV_FileName.ReadOnly = true;
            this.DGV_FileName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_FileName.Width = 150;
            // 
            // DGV_PathToFile
            // 
            this.DGV_PathToFile.HeaderText = "количество";
            this.DGV_PathToFile.Name = "DGV_PathToFile";
            this.DGV_PathToFile.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_PathToFile.Width = 90;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(27, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "Анализировать";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ckbWord
            // 
            this.ckbWord.AutoSize = true;
            this.ckbWord.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ckbWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ckbWord.ForeColor = System.Drawing.Color.White;
            this.ckbWord.Location = new System.Drawing.Point(27, 391);
            this.ckbWord.Name = "ckbWord";
            this.ckbWord.Size = new System.Drawing.Size(71, 24);
            this.ckbWord.TabIndex = 5;
            this.ckbWord.Text = "слова";
            this.ckbWord.UseVisualStyleBackColor = true;
            // 
            // ckbSymbol
            // 
            this.ckbSymbol.AutoSize = true;
            this.ckbSymbol.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ckbSymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ckbSymbol.ForeColor = System.Drawing.Color.White;
            this.ckbSymbol.Location = new System.Drawing.Point(27, 414);
            this.ckbSymbol.Name = "ckbSymbol";
            this.ckbSymbol.Size = new System.Drawing.Size(93, 24);
            this.ckbSymbol.TabIndex = 6;
            this.ckbSymbol.Text = "символы";
            this.ckbSymbol.UseVisualStyleBackColor = true;
            // 
            // ckbSentence
            // 
            this.ckbSentence.AutoSize = true;
            this.ckbSentence.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ckbSentence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ckbSentence.ForeColor = System.Drawing.Color.White;
            this.ckbSentence.Location = new System.Drawing.Point(27, 437);
            this.ckbSentence.Name = "ckbSentence";
            this.ckbSentence.Size = new System.Drawing.Size(199, 24);
            this.ckbSentence.TabIndex = 7;
            this.ckbSentence.Text = "воп/воск.предложения";
            this.ckbSentence.UseVisualStyleBackColor = true;
            // 
            // task123BindingSource
            // 
            this.task123BindingSource.DataSource = typeof(Home_Work_5.Task1_2_3);
            // 
            // Task1_2_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(966, 570);
            this.Controls.Add(this.ckbSentence);
            this.Controls.Add(this.ckbSymbol);
            this.Controls.Add(this.ckbWord);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbText);
            this.Name = "Task1_2_3";
            this.Text = "Task1_2_3";
            this.Load += new System.EventHandler(this.Task123_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.task123BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.BindingSource task123BindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox ckbWord;
        private System.Windows.Forms.CheckBox ckbSymbol;
        private System.Windows.Forms.CheckBox ckbSentence;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_PathToFile;
    }
}