namespace ExcelMergeTool
{
    partial class ExcelMergeForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.openExcelButton = new System.Windows.Forms.Button();
            this.allSheetsListBox = new System.Windows.Forms.ListBox();
            this.mergeButton = new System.Windows.Forms.Button();
            this.sourceExcelTextBox = new System.Windows.Forms.TextBox();
            this.selectedSheetsListBox = new System.Windows.Forms.ListBox();
            this.addSelectedSheetButton = new System.Windows.Forms.Button();
            this.deleteSelectedSheetNutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openExcelButton
            // 
            this.openExcelButton.Location = new System.Drawing.Point(918, 12);
            this.openExcelButton.Name = "openExcelButton";
            this.openExcelButton.Size = new System.Drawing.Size(153, 59);
            this.openExcelButton.TabIndex = 0;
            this.openExcelButton.Text = "打開Excel";
            this.openExcelButton.UseVisualStyleBackColor = true;
            this.openExcelButton.Click += new System.EventHandler(this.addExcelButton_Click);
            // 
            // allSheetsListBox
            // 
            this.allSheetsListBox.FormattingEnabled = true;
            this.allSheetsListBox.ItemHeight = 18;
            this.allSheetsListBox.Location = new System.Drawing.Point(12, 47);
            this.allSheetsListBox.Name = "allSheetsListBox";
            this.allSheetsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.allSheetsListBox.Size = new System.Drawing.Size(350, 310);
            this.allSheetsListBox.TabIndex = 1;
            // 
            // mergeButton
            // 
            this.mergeButton.Location = new System.Drawing.Point(920, 216);
            this.mergeButton.Name = "mergeButton";
            this.mergeButton.Size = new System.Drawing.Size(151, 61);
            this.mergeButton.TabIndex = 3;
            this.mergeButton.Text = "合併";
            this.mergeButton.UseVisualStyleBackColor = true;
            this.mergeButton.Click += new System.EventHandler(this.mergeButton_Click);
            // 
            // sourceExcelTextBox
            // 
            this.sourceExcelTextBox.Location = new System.Drawing.Point(11, 12);
            this.sourceExcelTextBox.Name = "sourceExcelTextBox";
            this.sourceExcelTextBox.Size = new System.Drawing.Size(748, 29);
            this.sourceExcelTextBox.TabIndex = 4;
            // 
            // selectedSheetsListBox
            // 
            this.selectedSheetsListBox.FormattingEnabled = true;
            this.selectedSheetsListBox.ItemHeight = 18;
            this.selectedSheetsListBox.Location = new System.Drawing.Point(379, 47);
            this.selectedSheetsListBox.Name = "selectedSheetsListBox";
            this.selectedSheetsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.selectedSheetsListBox.Size = new System.Drawing.Size(380, 310);
            this.selectedSheetsListBox.TabIndex = 5;
            // 
            // addSelectedSheetButton
            // 
            this.addSelectedSheetButton.Location = new System.Drawing.Point(918, 77);
            this.addSelectedSheetButton.Name = "addSelectedSheetButton";
            this.addSelectedSheetButton.Size = new System.Drawing.Size(151, 59);
            this.addSelectedSheetButton.TabIndex = 6;
            this.addSelectedSheetButton.Text = "加入選擇的表";
            this.addSelectedSheetButton.UseVisualStyleBackColor = true;
            this.addSelectedSheetButton.Click += new System.EventHandler(this.addSelectedSheetButton_Click);
            // 
            // deleteSelectedSheetNutton
            // 
            this.deleteSelectedSheetNutton.Location = new System.Drawing.Point(916, 142);
            this.deleteSelectedSheetNutton.Name = "deleteSelectedSheetNutton";
            this.deleteSelectedSheetNutton.Size = new System.Drawing.Size(153, 68);
            this.deleteSelectedSheetNutton.TabIndex = 7;
            this.deleteSelectedSheetNutton.Text = "刪除選擇的表";
            this.deleteSelectedSheetNutton.UseVisualStyleBackColor = true;
            this.deleteSelectedSheetNutton.Click += new System.EventHandler(this.deleteSelectedSheetNutton_Click);
            // 
            // ExcelMergeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 439);
            this.Controls.Add(this.deleteSelectedSheetNutton);
            this.Controls.Add(this.addSelectedSheetButton);
            this.Controls.Add(this.selectedSheetsListBox);
            this.Controls.Add(this.sourceExcelTextBox);
            this.Controls.Add(this.mergeButton);
            this.Controls.Add(this.allSheetsListBox);
            this.Controls.Add(this.openExcelButton);
            this.Name = "ExcelMergeForm";
            this.Text = "Excel Merge Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openExcelButton;
        private System.Windows.Forms.ListBox allSheetsListBox;
        private System.Windows.Forms.Button mergeButton;
        private System.Windows.Forms.TextBox sourceExcelTextBox;
        private System.Windows.Forms.ListBox selectedSheetsListBox;
        private System.Windows.Forms.Button addSelectedSheetButton;
        private System.Windows.Forms.Button deleteSelectedSheetNutton;
    }
}

