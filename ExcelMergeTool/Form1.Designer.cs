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
            this.addSelectedSheetButton = new System.Windows.Forms.Button();
            this.deleteSelectedSheetButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.addAllSheetsButton = new System.Windows.Forms.Button();
            this.mergeButton = new System.Windows.Forms.Button();
            this.deleteAllSelectedSheetsButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.allSheetsLabel = new System.Windows.Forms.Label();
            this.selectedSheetsLabel = new System.Windows.Forms.Label();
            this.addedExcelComboBox = new System.Windows.Forms.ComboBox();
            this.selectedSheetsTreeView = new System.Windows.Forms.TreeView();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openExcelButton
            // 
            this.openExcelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openExcelButton.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.openExcelButton.Location = new System.Drawing.Point(5, 5);
            this.openExcelButton.Margin = new System.Windows.Forms.Padding(5);
            this.openExcelButton.Name = "openExcelButton";
            this.openExcelButton.Size = new System.Drawing.Size(114, 78);
            this.openExcelButton.TabIndex = 0;
            this.openExcelButton.Text = "加入Excel";
            this.openExcelButton.UseVisualStyleBackColor = true;
            this.openExcelButton.Click += new System.EventHandler(this.addExcelButton_Click);
            // 
            // allSheetsListBox
            // 
            this.allSheetsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.allSheetsListBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.allSheetsListBox.FormattingEnabled = true;
            this.allSheetsListBox.ItemHeight = 20;
            this.allSheetsListBox.Location = new System.Drawing.Point(5, 75);
            this.allSheetsListBox.Margin = new System.Windows.Forms.Padding(5);
            this.allSheetsListBox.Name = "allSheetsListBox";
            this.allSheetsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.allSheetsListBox.Size = new System.Drawing.Size(219, 275);
            this.allSheetsListBox.TabIndex = 1;
            // 
            // addSelectedSheetButton
            // 
            this.addSelectedSheetButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addSelectedSheetButton.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.addSelectedSheetButton.Location = new System.Drawing.Point(5, 146);
            this.addSelectedSheetButton.Margin = new System.Windows.Forms.Padding(5);
            this.addSelectedSheetButton.Name = "addSelectedSheetButton";
            this.addSelectedSheetButton.Size = new System.Drawing.Size(114, 43);
            this.addSelectedSheetButton.TabIndex = 6;
            this.addSelectedSheetButton.Text = "加入選擇的表單";
            this.addSelectedSheetButton.UseVisualStyleBackColor = true;
            this.addSelectedSheetButton.Click += new System.EventHandler(this.addSelectedSheetButton_Click);
            // 
            // deleteSelectedSheetButton
            // 
            this.deleteSelectedSheetButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteSelectedSheetButton.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.deleteSelectedSheetButton.Location = new System.Drawing.Point(5, 252);
            this.deleteSelectedSheetButton.Margin = new System.Windows.Forms.Padding(5);
            this.deleteSelectedSheetButton.Name = "deleteSelectedSheetButton";
            this.deleteSelectedSheetButton.Size = new System.Drawing.Size(114, 43);
            this.deleteSelectedSheetButton.TabIndex = 7;
            this.deleteSelectedSheetButton.Text = "刪除選擇的表單";
            this.deleteSelectedSheetButton.UseVisualStyleBackColor = true;
            this.deleteSelectedSheetButton.Click += new System.EventHandler(this.deleteSelectedSheetButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.openExcelButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.addAllSheetsButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.addSelectedSheetButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.mergeButton, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.deleteSelectedSheetButton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.deleteAllSelectedSheetsButton, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(458, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(124, 355);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // addAllSheetsButton
            // 
            this.addAllSheetsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addAllSheetsButton.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.addAllSheetsButton.Location = new System.Drawing.Point(5, 93);
            this.addAllSheetsButton.Margin = new System.Windows.Forms.Padding(5);
            this.addAllSheetsButton.Name = "addAllSheetsButton";
            this.addAllSheetsButton.Size = new System.Drawing.Size(114, 43);
            this.addAllSheetsButton.TabIndex = 8;
            this.addAllSheetsButton.Text = "加入所有的表單";
            this.addAllSheetsButton.UseVisualStyleBackColor = true;
            this.addAllSheetsButton.Click += new System.EventHandler(this.addAllSheetsButton_Click);
            // 
            // mergeButton
            // 
            this.mergeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mergeButton.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.mergeButton.Location = new System.Drawing.Point(5, 305);
            this.mergeButton.Margin = new System.Windows.Forms.Padding(5);
            this.mergeButton.Name = "mergeButton";
            this.mergeButton.Size = new System.Drawing.Size(114, 45);
            this.mergeButton.TabIndex = 3;
            this.mergeButton.Text = "合併";
            this.mergeButton.UseVisualStyleBackColor = true;
            this.mergeButton.Click += new System.EventHandler(this.mergeButton_Click);
            // 
            // deleteAllSelectedSheetsButton
            // 
            this.deleteAllSelectedSheetsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteAllSelectedSheetsButton.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.deleteAllSelectedSheetsButton.Location = new System.Drawing.Point(5, 199);
            this.deleteAllSelectedSheetsButton.Margin = new System.Windows.Forms.Padding(5);
            this.deleteAllSelectedSheetsButton.Name = "deleteAllSelectedSheetsButton";
            this.deleteAllSelectedSheetsButton.Size = new System.Drawing.Size(114, 43);
            this.deleteAllSelectedSheetsButton.TabIndex = 9;
            this.deleteAllSelectedSheetsButton.Text = "刪除所有的表單";
            this.deleteAllSelectedSheetsButton.UseVisualStyleBackColor = true;
            this.deleteAllSelectedSheetsButton.Click += new System.EventHandler(this.deleteAllSelectedSheetsButton_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.allSheetsLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.selectedSheetsLabel, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.addedExcelComboBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.selectedSheetsTreeView, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.allSheetsListBox, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(458, 355);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // allSheetsLabel
            // 
            this.allSheetsLabel.AutoSize = true;
            this.allSheetsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allSheetsLabel.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.allSheetsLabel.Location = new System.Drawing.Point(5, 40);
            this.allSheetsLabel.Margin = new System.Windows.Forms.Padding(5);
            this.allSheetsLabel.Name = "allSheetsLabel";
            this.allSheetsLabel.Size = new System.Drawing.Size(219, 25);
            this.allSheetsLabel.TabIndex = 6;
            this.allSheetsLabel.Text = "Excel中所有的表單";
            this.allSheetsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // selectedSheetsLabel
            // 
            this.selectedSheetsLabel.AutoSize = true;
            this.selectedSheetsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectedSheetsLabel.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.selectedSheetsLabel.Location = new System.Drawing.Point(234, 40);
            this.selectedSheetsLabel.Margin = new System.Windows.Forms.Padding(5);
            this.selectedSheetsLabel.Name = "selectedSheetsLabel";
            this.selectedSheetsLabel.Size = new System.Drawing.Size(219, 25);
            this.selectedSheetsLabel.TabIndex = 7;
            this.selectedSheetsLabel.Text = "所有選擇的表單";
            this.selectedSheetsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // addedExcelComboBox
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.addedExcelComboBox, 2);
            this.addedExcelComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addedExcelComboBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.addedExcelComboBox.FormattingEnabled = true;
            this.addedExcelComboBox.ItemHeight = 20;
            this.addedExcelComboBox.Location = new System.Drawing.Point(3, 3);
            this.addedExcelComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.addedExcelComboBox.Name = "addedExcelComboBox";
            this.addedExcelComboBox.Size = new System.Drawing.Size(452, 28);
            this.addedExcelComboBox.TabIndex = 8;
            this.addedExcelComboBox.SelectedIndexChanged += new System.EventHandler(this.addedExcelComboBox_SelectedIndexChanged);
            // 
            // selectedSheetsTreeView
            // 
            this.selectedSheetsTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedSheetsTreeView.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.selectedSheetsTreeView.ItemHeight = 12;
            this.selectedSheetsTreeView.Location = new System.Drawing.Point(234, 75);
            this.selectedSheetsTreeView.Margin = new System.Windows.Forms.Padding(5);
            this.selectedSheetsTreeView.Name = "selectedSheetsTreeView";
            this.selectedSheetsTreeView.Size = new System.Drawing.Size(219, 275);
            this.selectedSheetsTreeView.TabIndex = 9;
            // 
            // ExcelMergeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(582, 355);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(598, 394);
            this.Name = "ExcelMergeForm";
            this.ShowIcon = false;
            this.Text = "Excel Merge Tool --------- Directed By KarosChen 仿冒必究";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openExcelButton;
        private System.Windows.Forms.ListBox allSheetsListBox;
        private System.Windows.Forms.Button addSelectedSheetButton;
        private System.Windows.Forms.Button deleteSelectedSheetButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label allSheetsLabel;
        private System.Windows.Forms.Label selectedSheetsLabel;
        private System.Windows.Forms.Button addAllSheetsButton;
        private System.Windows.Forms.ComboBox addedExcelComboBox;
        private System.Windows.Forms.TreeView selectedSheetsTreeView;
        private System.Windows.Forms.Button mergeButton;
        private System.Windows.Forms.Button deleteAllSelectedSheetsButton;
    }
}

