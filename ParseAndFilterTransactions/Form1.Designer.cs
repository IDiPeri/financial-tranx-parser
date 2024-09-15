namespace ParseAndFilterTransactions
{
    partial class Form1
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
            this.comboBox_Bank = new System.Windows.Forms.ComboBox();
            this.textBox_RootFolder = new System.Windows.Forms.TextBox();
            this.buttonSelectSourceFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.comboBox_Filter = new System.Windows.Forms.ComboBox();
            this.listBoxFilterKeywords = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox_LoadFiles = new System.Windows.Forms.GroupBox();
            this.loadFilesCtrl1 = new ParseAndFilterTransactions.LoadFilesCtrl();
            this.groupBox_FilterTranx = new System.Windows.Forms.GroupBox();
            this.filterTranxCtrl1 = new ParseAndFilterTransactions.FilterTranxCtrl();
            this.groupBox_SummarizeTranx = new System.Windows.Forms.GroupBox();
            this.summarizeTranxCtrl1 = new ParseAndFilterTransactions.SummarizeTranxCtrl();
            this.groupBox_Save = new System.Windows.Forms.GroupBox();
            this.saveSummaryDataCtrl1 = new ParseAndFilterTransactions.SaveSummaryDataCtrl();
            this.groupBox1.SuspendLayout();
            this.groupBox_LoadFiles.SuspendLayout();
            this.groupBox_FilterTranx.SuspendLayout();
            this.groupBox_SummarizeTranx.SuspendLayout();
            this.groupBox_Save.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_Bank
            // 
            this.comboBox_Bank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Bank.FormattingEnabled = true;
            this.comboBox_Bank.Location = new System.Drawing.Point(8, 105);
            this.comboBox_Bank.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_Bank.Name = "comboBox_Bank";
            this.comboBox_Bank.Size = new System.Drawing.Size(195, 24);
            this.comboBox_Bank.TabIndex = 2;
            this.comboBox_Bank.SelectedIndexChanged += new System.EventHandler(this.comboBox_Bank_SelectedIndexChanged);
            // 
            // textBox_RootFolder
            // 
            this.textBox_RootFolder.Location = new System.Drawing.Point(231, 28);
            this.textBox_RootFolder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_RootFolder.Name = "textBox_RootFolder";
            this.textBox_RootFolder.Size = new System.Drawing.Size(631, 22);
            this.textBox_RootFolder.TabIndex = 3;
            // 
            // buttonSelectSourceFile
            // 
            this.buttonSelectSourceFile.Location = new System.Drawing.Point(231, 60);
            this.buttonSelectSourceFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSelectSourceFile.Name = "buttonSelectSourceFile";
            this.buttonSelectSourceFile.Size = new System.Drawing.Size(51, 34);
            this.buttonSelectSourceFile.TabIndex = 4;
            this.buttonSelectSourceFile.Text = "...";
            this.buttonSelectSourceFile.UseVisualStyleBackColor = true;
            this.buttonSelectSourceFile.Click += new System.EventHandler(this.buttonSelectSourceFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(289, 66);
            this.textBoxFileName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(573, 22);
            this.textBoxFileName.TabIndex = 5;
            // 
            // comboBox_Filter
            // 
            this.comboBox_Filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Filter.FormattingEnabled = true;
            this.comboBox_Filter.Location = new System.Drawing.Point(8, 138);
            this.comboBox_Filter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_Filter.Name = "comboBox_Filter";
            this.comboBox_Filter.Size = new System.Drawing.Size(195, 24);
            this.comboBox_Filter.TabIndex = 6;
            this.comboBox_Filter.SelectedIndexChanged += new System.EventHandler(this.comboBox_Filter_SelectedIndexChanged);
            // 
            // listBoxFilterKeywords
            // 
            this.listBoxFilterKeywords.FormattingEnabled = true;
            this.listBoxFilterKeywords.ItemHeight = 16;
            this.listBoxFilterKeywords.Location = new System.Drawing.Point(231, 117);
            this.listBoxFilterKeywords.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxFilterKeywords.Name = "listBoxFilterKeywords";
            this.listBoxFilterKeywords.Size = new System.Drawing.Size(148, 68);
            this.listBoxFilterKeywords.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxFilterKeywords);
            this.groupBox1.Controls.Add(this.comboBox_Filter);
            this.groupBox1.Controls.Add(this.comboBox_Bank);
            this.groupBox1.Controls.Add(this.textBoxFileName);
            this.groupBox1.Controls.Add(this.textBox_RootFolder);
            this.groupBox1.Controls.Add(this.buttonSelectSourceFile);
            this.groupBox1.Location = new System.Drawing.Point(3, 468);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(880, 213);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Obsolete";
            // 
            // groupBox_LoadFiles
            // 
            this.groupBox_LoadFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_LoadFiles.Controls.Add(this.loadFilesCtrl1);
            this.groupBox_LoadFiles.Location = new System.Drawing.Point(16, 22);
            this.groupBox_LoadFiles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_LoadFiles.Name = "groupBox_LoadFiles";
            this.groupBox_LoadFiles.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_LoadFiles.Size = new System.Drawing.Size(999, 220);
            this.groupBox_LoadFiles.TabIndex = 9;
            this.groupBox_LoadFiles.TabStop = false;
            this.groupBox_LoadFiles.Text = "Load Files";
            // 
            // loadFilesCtrl1
            // 
            this.loadFilesCtrl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loadFilesCtrl1.Location = new System.Drawing.Point(8, 23);
            this.loadFilesCtrl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.loadFilesCtrl1.Name = "loadFilesCtrl1";
            this.loadFilesCtrl1.Size = new System.Drawing.Size(983, 190);
            this.loadFilesCtrl1.TabIndex = 0;
            // 
            // groupBox_FilterTranx
            // 
            this.groupBox_FilterTranx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_FilterTranx.Controls.Add(this.filterTranxCtrl1);
            this.groupBox_FilterTranx.Enabled = false;
            this.groupBox_FilterTranx.Location = new System.Drawing.Point(16, 261);
            this.groupBox_FilterTranx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_FilterTranx.Name = "groupBox_FilterTranx";
            this.groupBox_FilterTranx.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_FilterTranx.Size = new System.Drawing.Size(999, 206);
            this.groupBox_FilterTranx.TabIndex = 10;
            this.groupBox_FilterTranx.TabStop = false;
            this.groupBox_FilterTranx.Text = "Filter Transactions";
            // 
            // filterTranxCtrl1
            // 
            this.filterTranxCtrl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterTranxCtrl1.Location = new System.Drawing.Point(8, 23);
            this.filterTranxCtrl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.filterTranxCtrl1.Name = "filterTranxCtrl1";
            this.filterTranxCtrl1.Size = new System.Drawing.Size(983, 175);
            this.filterTranxCtrl1.TabIndex = 0;
            // 
            // groupBox_SummarizeTranx
            // 
            this.groupBox_SummarizeTranx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_SummarizeTranx.Controls.Add(this.summarizeTranxCtrl1);
            this.groupBox_SummarizeTranx.Enabled = false;
            this.groupBox_SummarizeTranx.Location = new System.Drawing.Point(16, 474);
            this.groupBox_SummarizeTranx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_SummarizeTranx.Name = "groupBox_SummarizeTranx";
            this.groupBox_SummarizeTranx.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_SummarizeTranx.Size = new System.Drawing.Size(999, 127);
            this.groupBox_SummarizeTranx.TabIndex = 12;
            this.groupBox_SummarizeTranx.TabStop = false;
            this.groupBox_SummarizeTranx.Text = "Summarize Transactions";
            // 
            // summarizeTranxCtrl1
            // 
            this.summarizeTranxCtrl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.summarizeTranxCtrl1.Location = new System.Drawing.Point(8, 23);
            this.summarizeTranxCtrl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.summarizeTranxCtrl1.Name = "summarizeTranxCtrl1";
            this.summarizeTranxCtrl1.Size = new System.Drawing.Size(983, 96);
            this.summarizeTranxCtrl1.TabIndex = 11;
            // 
            // groupBox_Save
            // 
            this.groupBox_Save.Controls.Add(this.saveSummaryDataCtrl1);
            this.groupBox_Save.Enabled = false;
            this.groupBox_Save.Location = new System.Drawing.Point(16, 608);
            this.groupBox_Save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_Save.Name = "groupBox_Save";
            this.groupBox_Save.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_Save.Size = new System.Drawing.Size(987, 116);
            this.groupBox_Save.TabIndex = 13;
            this.groupBox_Save.TabStop = false;
            this.groupBox_Save.Text = "Save Summary Transactions";
            // 
            // saveSummaryDataCtrl1
            // 
            this.saveSummaryDataCtrl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveSummaryDataCtrl1.Location = new System.Drawing.Point(8, 23);
            this.saveSummaryDataCtrl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.saveSummaryDataCtrl1.Name = "saveSummaryDataCtrl1";
            this.saveSummaryDataCtrl1.Size = new System.Drawing.Size(971, 85);
            this.saveSummaryDataCtrl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 750);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox_Save);
            this.Controls.Add(this.groupBox_SummarizeTranx);
            this.Controls.Add(this.groupBox_FilterTranx);
            this.Controls.Add(this.groupBox_LoadFiles);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_LoadFiles.ResumeLayout(false);
            this.groupBox_FilterTranx.ResumeLayout(false);
            this.groupBox_SummarizeTranx.ResumeLayout(false);
            this.groupBox_Save.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox_Bank;
        private System.Windows.Forms.TextBox textBox_RootFolder;
        private System.Windows.Forms.Button buttonSelectSourceFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.ComboBox comboBox_Filter;
        private System.Windows.Forms.ListBox listBoxFilterKeywords;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox_LoadFiles;
        private LoadFilesCtrl loadFilesCtrl1;
        private System.Windows.Forms.GroupBox groupBox_FilterTranx;
        private FilterTranxCtrl filterTranxCtrl1;
        private SummarizeTranxCtrl summarizeTranxCtrl1;
        private System.Windows.Forms.GroupBox groupBox_SummarizeTranx;
        private System.Windows.Forms.GroupBox groupBox_Save;
        private SaveSummaryDataCtrl saveSummaryDataCtrl1;
    }
}

