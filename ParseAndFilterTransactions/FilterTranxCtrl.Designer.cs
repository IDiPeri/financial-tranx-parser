namespace ParseAndFilterTransactions
{
    partial class FilterTranxCtrl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox_Food = new System.Windows.Forms.ListBox();
            this.radioButton_Food = new System.Windows.Forms.RadioButton();
            this.radioButton_Utility = new System.Windows.Forms.RadioButton();
            this.listBox_Utility = new System.Windows.Forms.ListBox();
            this.radioButton_Gas = new System.Windows.Forms.RadioButton();
            this.listBox_Gas = new System.Windows.Forms.ListBox();
            this.label_TranxCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonFilterAll = new System.Windows.Forms.Button();
            this.radioButton_Amazon = new System.Windows.Forms.RadioButton();
            this.listBox_Amazon = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_TranxNetValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox_Food
            // 
            this.listBox_Food.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox_Food.FormattingEnabled = true;
            this.listBox_Food.Location = new System.Drawing.Point(0, 23);
            this.listBox_Food.Name = "listBox_Food";
            this.listBox_Food.Size = new System.Drawing.Size(138, 121);
            this.listBox_Food.TabIndex = 0;
            // 
            // radioButton_Food
            // 
            this.radioButton_Food.AutoSize = true;
            this.radioButton_Food.Checked = true;
            this.radioButton_Food.Location = new System.Drawing.Point(3, 0);
            this.radioButton_Food.Name = "radioButton_Food";
            this.radioButton_Food.Size = new System.Drawing.Size(49, 17);
            this.radioButton_Food.TabIndex = 3;
            this.radioButton_Food.TabStop = true;
            this.radioButton_Food.Text = "Food";
            this.radioButton_Food.UseVisualStyleBackColor = true;
            // 
            // radioButton_Utility
            // 
            this.radioButton_Utility.AutoSize = true;
            this.radioButton_Utility.Location = new System.Drawing.Point(149, 0);
            this.radioButton_Utility.Name = "radioButton_Utility";
            this.radioButton_Utility.Size = new System.Drawing.Size(50, 17);
            this.radioButton_Utility.TabIndex = 5;
            this.radioButton_Utility.Text = "Utility";
            this.radioButton_Utility.UseVisualStyleBackColor = true;
            // 
            // listBox_Utility
            // 
            this.listBox_Utility.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox_Utility.FormattingEnabled = true;
            this.listBox_Utility.Location = new System.Drawing.Point(146, 23);
            this.listBox_Utility.Name = "listBox_Utility";
            this.listBox_Utility.Size = new System.Drawing.Size(138, 121);
            this.listBox_Utility.TabIndex = 4;
            // 
            // radioButton_Gas
            // 
            this.radioButton_Gas.AutoSize = true;
            this.radioButton_Gas.Location = new System.Drawing.Point(297, 0);
            this.radioButton_Gas.Name = "radioButton_Gas";
            this.radioButton_Gas.Size = new System.Drawing.Size(44, 17);
            this.radioButton_Gas.TabIndex = 7;
            this.radioButton_Gas.Text = "Gas";
            this.radioButton_Gas.UseVisualStyleBackColor = true;
            // 
            // listBox_Gas
            // 
            this.listBox_Gas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox_Gas.FormattingEnabled = true;
            this.listBox_Gas.Location = new System.Drawing.Point(294, 23);
            this.listBox_Gas.Name = "listBox_Gas";
            this.listBox_Gas.Size = new System.Drawing.Size(138, 121);
            this.listBox_Gas.TabIndex = 6;
            // 
            // label_TranxCount
            // 
            this.label_TranxCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_TranxCount.AutoSize = true;
            this.label_TranxCount.Location = new System.Drawing.Point(693, 44);
            this.label_TranxCount.Name = "label_TranxCount";
            this.label_TranxCount.Size = new System.Drawing.Size(10, 13);
            this.label_TranxCount.TabIndex = 14;
            this.label_TranxCount.Text = "-";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(611, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Filtered Tranx:";
            // 
            // buttonFilterAll
            // 
            this.buttonFilterAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFilterAll.Location = new System.Drawing.Point(604, 3);
            this.buttonFilterAll.Name = "buttonFilterAll";
            this.buttonFilterAll.Size = new System.Drawing.Size(144, 31);
            this.buttonFilterAll.TabIndex = 12;
            this.buttonFilterAll.Text = "Filter All";
            this.buttonFilterAll.UseVisualStyleBackColor = true;
            this.buttonFilterAll.Click += new System.EventHandler(this.buttonFilterAll_Click);
            // 
            // radioButton_Amazon
            // 
            this.radioButton_Amazon.AutoSize = true;
            this.radioButton_Amazon.Location = new System.Drawing.Point(444, 0);
            this.radioButton_Amazon.Name = "radioButton_Amazon";
            this.radioButton_Amazon.Size = new System.Drawing.Size(63, 17);
            this.radioButton_Amazon.TabIndex = 15;
            this.radioButton_Amazon.Text = "Amazon";
            this.radioButton_Amazon.UseVisualStyleBackColor = true;
            // 
            // listBox_Amazon
            // 
            this.listBox_Amazon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox_Amazon.FormattingEnabled = true;
            this.listBox_Amazon.Location = new System.Drawing.Point(444, 23);
            this.listBox_Amazon.Name = "listBox_Amazon";
            this.listBox_Amazon.Size = new System.Drawing.Size(138, 121);
            this.listBox_Amazon.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(611, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Net value ($):";
            // 
            // label_TranxNetValue
            // 
            this.label_TranxNetValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_TranxNetValue.AutoSize = true;
            this.label_TranxNetValue.Location = new System.Drawing.Point(693, 69);
            this.label_TranxNetValue.Name = "label_TranxNetValue";
            this.label_TranxNetValue.Size = new System.Drawing.Size(10, 13);
            this.label_TranxNetValue.TabIndex = 18;
            this.label_TranxNetValue.Text = "-";
            // 
            // FilterTranxCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_TranxNetValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_Amazon);
            this.Controls.Add(this.radioButton_Amazon);
            this.Controls.Add(this.label_TranxCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonFilterAll);
            this.Controls.Add(this.radioButton_Gas);
            this.Controls.Add(this.listBox_Gas);
            this.Controls.Add(this.radioButton_Utility);
            this.Controls.Add(this.listBox_Utility);
            this.Controls.Add(this.radioButton_Food);
            this.Controls.Add(this.listBox_Food);
            this.Name = "FilterTranxCtrl";
            this.Size = new System.Drawing.Size(751, 153);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Food;
        private System.Windows.Forms.RadioButton radioButton_Food;
        private System.Windows.Forms.RadioButton radioButton_Utility;
        private System.Windows.Forms.ListBox listBox_Utility;
        private System.Windows.Forms.RadioButton radioButton_Gas;
        private System.Windows.Forms.ListBox listBox_Gas;
        private System.Windows.Forms.Label label_TranxCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonFilterAll;
        private System.Windows.Forms.RadioButton radioButton_Amazon;
        private System.Windows.Forms.ListBox listBox_Amazon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_TranxNetValue;
    }
}
