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
            this.buttonLoad = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(6, 19);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(150, 27);
            this.buttonLoad.TabIndex = 0;
            this.buttonLoad.Text = "Load Capitol One";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "Load Bank of America";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox_Bank
            // 
            this.comboBox_Bank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Bank.FormattingEnabled = true;
            this.comboBox_Bank.Location = new System.Drawing.Point(6, 85);
            this.comboBox_Bank.Name = "comboBox_Bank";
            this.comboBox_Bank.Size = new System.Drawing.Size(147, 21);
            this.comboBox_Bank.TabIndex = 2;
            this.comboBox_Bank.SelectedIndexChanged += new System.EventHandler(this.comboBox_Bank_SelectedIndexChanged);
            // 
            // textBox_RootFolder
            // 
            this.textBox_RootFolder.Location = new System.Drawing.Point(173, 23);
            this.textBox_RootFolder.Name = "textBox_RootFolder";
            this.textBox_RootFolder.Size = new System.Drawing.Size(474, 20);
            this.textBox_RootFolder.TabIndex = 3;
            // 
            // buttonSelectSourceFile
            // 
            this.buttonSelectSourceFile.Location = new System.Drawing.Point(173, 49);
            this.buttonSelectSourceFile.Name = "buttonSelectSourceFile";
            this.buttonSelectSourceFile.Size = new System.Drawing.Size(38, 28);
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
            this.textBoxFileName.Location = new System.Drawing.Point(217, 54);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(431, 20);
            this.textBoxFileName.TabIndex = 5;
            // 
            // comboBox_Filter
            // 
            this.comboBox_Filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Filter.FormattingEnabled = true;
            this.comboBox_Filter.Location = new System.Drawing.Point(6, 112);
            this.comboBox_Filter.Name = "comboBox_Filter";
            this.comboBox_Filter.Size = new System.Drawing.Size(147, 21);
            this.comboBox_Filter.TabIndex = 6;
            this.comboBox_Filter.SelectedIndexChanged += new System.EventHandler(this.comboBox_Filter_SelectedIndexChanged);
            // 
            // listBoxFilterKeywords
            // 
            this.listBoxFilterKeywords.FormattingEnabled = true;
            this.listBoxFilterKeywords.Location = new System.Drawing.Point(173, 95);
            this.listBoxFilterKeywords.Name = "listBoxFilterKeywords";
            this.listBoxFilterKeywords.Size = new System.Drawing.Size(112, 56);
            this.listBoxFilterKeywords.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonLoad);
            this.groupBox1.Controls.Add(this.listBoxFilterKeywords);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboBox_Filter);
            this.groupBox1.Controls.Add(this.comboBox_Bank);
            this.groupBox1.Controls.Add(this.textBoxFileName);
            this.groupBox1.Controls.Add(this.textBox_RootFolder);
            this.groupBox1.Controls.Add(this.buttonSelectSourceFile);
            this.groupBox1.Location = new System.Drawing.Point(18, 594);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 173);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Obsolete";
            // 
            // groupBox_LoadFiles
            // 
            this.groupBox_LoadFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_LoadFiles.Controls.Add(this.loadFilesCtrl1);
            this.groupBox_LoadFiles.Location = new System.Drawing.Point(12, 18);
            this.groupBox_LoadFiles.Name = "groupBox_LoadFiles";
            this.groupBox_LoadFiles.Size = new System.Drawing.Size(749, 179);
            this.groupBox_LoadFiles.TabIndex = 9;
            this.groupBox_LoadFiles.TabStop = false;
            this.groupBox_LoadFiles.Text = "Load Files";
            // 
            // loadFilesCtrl1
            // 
            this.loadFilesCtrl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loadFilesCtrl1.Location = new System.Drawing.Point(6, 19);
            this.loadFilesCtrl1.Name = "loadFilesCtrl1";
            this.loadFilesCtrl1.Size = new System.Drawing.Size(737, 154);
            this.loadFilesCtrl1.TabIndex = 0;
            // 
            // groupBox_FilterTranx
            // 
            this.groupBox_FilterTranx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_FilterTranx.Controls.Add(this.filterTranxCtrl1);
            this.groupBox_FilterTranx.Enabled = false;
            this.groupBox_FilterTranx.Location = new System.Drawing.Point(12, 212);
            this.groupBox_FilterTranx.Name = "groupBox_FilterTranx";
            this.groupBox_FilterTranx.Size = new System.Drawing.Size(749, 167);
            this.groupBox_FilterTranx.TabIndex = 10;
            this.groupBox_FilterTranx.TabStop = false;
            this.groupBox_FilterTranx.Text = "Filter Transactions";
            // 
            // filterTranxCtrl1
            // 
            this.filterTranxCtrl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterTranxCtrl1.Location = new System.Drawing.Point(6, 19);
            this.filterTranxCtrl1.Name = "filterTranxCtrl1";
            this.filterTranxCtrl1.Size = new System.Drawing.Size(737, 142);
            this.filterTranxCtrl1.TabIndex = 0;
            // 
            // groupBox_SummarizeTranx
            // 
            this.groupBox_SummarizeTranx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_SummarizeTranx.Controls.Add(this.summarizeTranxCtrl1);
            this.groupBox_SummarizeTranx.Enabled = false;
            this.groupBox_SummarizeTranx.Location = new System.Drawing.Point(12, 385);
            this.groupBox_SummarizeTranx.Name = "groupBox_SummarizeTranx";
            this.groupBox_SummarizeTranx.Size = new System.Drawing.Size(749, 103);
            this.groupBox_SummarizeTranx.TabIndex = 12;
            this.groupBox_SummarizeTranx.TabStop = false;
            this.groupBox_SummarizeTranx.Text = "Summarize Transactions";
            // 
            // summarizeTranxCtrl1
            // 
            this.summarizeTranxCtrl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.summarizeTranxCtrl1.Location = new System.Drawing.Point(6, 19);
            this.summarizeTranxCtrl1.Name = "summarizeTranxCtrl1";
            this.summarizeTranxCtrl1.Size = new System.Drawing.Size(737, 78);
            this.summarizeTranxCtrl1.TabIndex = 11;
            // 
            // groupBox_Save
            // 
            this.groupBox_Save.Controls.Add(this.saveSummaryDataCtrl1);
            this.groupBox_Save.Enabled = false;
            this.groupBox_Save.Location = new System.Drawing.Point(12, 494);
            this.groupBox_Save.Name = "groupBox_Save";
            this.groupBox_Save.Size = new System.Drawing.Size(740, 94);
            this.groupBox_Save.TabIndex = 13;
            this.groupBox_Save.TabStop = false;
            this.groupBox_Save.Text = "Save Summary Transactions";
            // 
            // saveSummaryDataCtrl1
            // 
            this.saveSummaryDataCtrl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveSummaryDataCtrl1.Location = new System.Drawing.Point(6, 19);
            this.saveSummaryDataCtrl1.Name = "saveSummaryDataCtrl1";
            this.saveSummaryDataCtrl1.Size = new System.Drawing.Size(728, 69);
            this.saveSummaryDataCtrl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 609);
            this.Controls.Add(this.groupBox_Save);
            this.Controls.Add(this.groupBox_SummarizeTranx);
            this.Controls.Add(this.groupBox_FilterTranx);
            this.Controls.Add(this.groupBox_LoadFiles);
            this.Controls.Add(this.groupBox1);
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

        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button button1;
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

