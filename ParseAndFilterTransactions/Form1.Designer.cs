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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox_LoadFiles = new System.Windows.Forms.GroupBox();
            this.loadFilesCtrl1 = new ParseAndFilterTransactions.LoadFilesCtrl();
            this.groupBox_FilterTranx = new System.Windows.Forms.GroupBox();
            this.filterTranxCtrl1 = new ParseAndFilterTransactions.FilterTranxCtrl();
            this.groupBox_SummarizeTranx = new System.Windows.Forms.GroupBox();
            this.summarizeTranxCtrl1 = new ParseAndFilterTransactions.SummarizeTranxCtrl();
            this.groupBox_Save = new System.Windows.Forms.GroupBox();
            this.saveSummaryDataCtrl1 = new ParseAndFilterTransactions.SaveSummaryDataCtrl();
            this.groupBox_LoadFiles.SuspendLayout();
            this.groupBox_FilterTranx.SuspendLayout();
            this.groupBox_SummarizeTranx.SuspendLayout();
            this.groupBox_Save.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox_LoadFiles
            // 
            this.groupBox_LoadFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_LoadFiles.Controls.Add(this.loadFilesCtrl1);
            this.groupBox_LoadFiles.Location = new System.Drawing.Point(16, 22);
            this.groupBox_LoadFiles.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_LoadFiles.Name = "groupBox_LoadFiles";
            this.groupBox_LoadFiles.Padding = new System.Windows.Forms.Padding(4);
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
            this.loadFilesCtrl1.Margin = new System.Windows.Forms.Padding(5);
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
            this.groupBox_FilterTranx.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_FilterTranx.Name = "groupBox_FilterTranx";
            this.groupBox_FilterTranx.Padding = new System.Windows.Forms.Padding(4);
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
            this.filterTranxCtrl1.Margin = new System.Windows.Forms.Padding(5);
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
            this.groupBox_SummarizeTranx.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_SummarizeTranx.Name = "groupBox_SummarizeTranx";
            this.groupBox_SummarizeTranx.Padding = new System.Windows.Forms.Padding(4);
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
            this.summarizeTranxCtrl1.Margin = new System.Windows.Forms.Padding(5);
            this.summarizeTranxCtrl1.Name = "summarizeTranxCtrl1";
            this.summarizeTranxCtrl1.Size = new System.Drawing.Size(983, 96);
            this.summarizeTranxCtrl1.TabIndex = 11;
            // 
            // groupBox_Save
            // 
            this.groupBox_Save.Controls.Add(this.saveSummaryDataCtrl1);
            this.groupBox_Save.Enabled = false;
            this.groupBox_Save.Location = new System.Drawing.Point(16, 608);
            this.groupBox_Save.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_Save.Name = "groupBox_Save";
            this.groupBox_Save.Padding = new System.Windows.Forms.Padding(4);
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
            this.saveSummaryDataCtrl1.Margin = new System.Windows.Forms.Padding(5);
            this.saveSummaryDataCtrl1.Name = "saveSummaryDataCtrl1";
            this.saveSummaryDataCtrl1.Size = new System.Drawing.Size(971, 85);
            this.saveSummaryDataCtrl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 750);
            this.Controls.Add(this.groupBox_Save);
            this.Controls.Add(this.groupBox_SummarizeTranx);
            this.Controls.Add(this.groupBox_FilterTranx);
            this.Controls.Add(this.groupBox_LoadFiles);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox_LoadFiles.ResumeLayout(false);
            this.groupBox_FilterTranx.ResumeLayout(false);
            this.groupBox_SummarizeTranx.ResumeLayout(false);
            this.groupBox_Save.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
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

