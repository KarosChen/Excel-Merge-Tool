﻿namespace ExcelMergeTool
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
            this.addSelectedSheetButton = new System.Windows.Forms.Button();
            this.deleteSelectedSheetButton = new System.Windows.Forms.Button();
            this.buttonTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.addAllSheetsButton = new System.Windows.Forms.Button();
            this.mergeButton = new System.Windows.Forms.Button();
            this.deleteAllSelectedSheetsButton = new System.Windows.Forms.Button();
            this.fileTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.allSheetsLabel = new System.Windows.Forms.Label();
            this.addedExcelComboBox = new System.Windows.Forms.ComboBox();
            this.selectedSheetsLabel = new System.Windows.Forms.Label();
            this.selectedSheetsTreeView = new System.Windows.Forms.TreeView();
            this.allSheetsListView = new System.Windows.Forms.ListView();
            this.imageColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.showTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.sheetTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.outerTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.buttonTableLayoutPanel.SuspendLayout();
            this.fileTableLayoutPanel.SuspendLayout();
            this.showTableLayoutPanel.SuspendLayout();
            this.sheetTableLayoutPanel.SuspendLayout();
            this.outerTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // openExcelButton
            // 
            this.openExcelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openExcelButton.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.openExcelButton.Location = new System.Drawing.Point(5, 5);
            this.openExcelButton.Margin = new System.Windows.Forms.Padding(5);
            this.openExcelButton.Name = "openExcelButton";
            this.openExcelButton.Size = new System.Drawing.Size(130, 128);
            this.openExcelButton.TabIndex = 0;
            this.openExcelButton.Text = "加入Excel";
            this.openExcelButton.UseVisualStyleBackColor = true;
            this.openExcelButton.Click += new System.EventHandler(this.addExcelButton_Click);
            // 
            // addSelectedSheetButton
            // 
            this.addSelectedSheetButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addSelectedSheetButton.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.addSelectedSheetButton.Location = new System.Drawing.Point(5, 225);
            this.addSelectedSheetButton.Margin = new System.Windows.Forms.Padding(5);
            this.addSelectedSheetButton.Name = "addSelectedSheetButton";
            this.addSelectedSheetButton.Size = new System.Drawing.Size(130, 72);
            this.addSelectedSheetButton.TabIndex = 6;
            this.addSelectedSheetButton.Text = "加入選擇的表單";
            this.addSelectedSheetButton.UseVisualStyleBackColor = true;
            this.addSelectedSheetButton.Click += new System.EventHandler(this.addSelectedSheetButton_Click);
            // 
            // deleteSelectedSheetButton
            // 
            this.deleteSelectedSheetButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteSelectedSheetButton.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.deleteSelectedSheetButton.Location = new System.Drawing.Point(5, 389);
            this.deleteSelectedSheetButton.Margin = new System.Windows.Forms.Padding(5);
            this.deleteSelectedSheetButton.Name = "deleteSelectedSheetButton";
            this.deleteSelectedSheetButton.Size = new System.Drawing.Size(130, 72);
            this.deleteSelectedSheetButton.TabIndex = 7;
            this.deleteSelectedSheetButton.Text = "刪除選擇的表單";
            this.deleteSelectedSheetButton.UseVisualStyleBackColor = true;
            this.deleteSelectedSheetButton.Click += new System.EventHandler(this.deleteSelectedSheetButton_Click);
            // 
            // buttonTableLayoutPanel
            // 
            this.buttonTableLayoutPanel.ColumnCount = 1;
            this.buttonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonTableLayoutPanel.Controls.Add(this.openExcelButton, 0, 0);
            this.buttonTableLayoutPanel.Controls.Add(this.addAllSheetsButton, 0, 1);
            this.buttonTableLayoutPanel.Controls.Add(this.addSelectedSheetButton, 0, 2);
            this.buttonTableLayoutPanel.Controls.Add(this.mergeButton, 0, 5);
            this.buttonTableLayoutPanel.Controls.Add(this.deleteSelectedSheetButton, 0, 4);
            this.buttonTableLayoutPanel.Controls.Add(this.deleteAllSelectedSheetsButton, 0, 3);
            this.buttonTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonTableLayoutPanel.Location = new System.Drawing.Point(840, 4);
            this.buttonTableLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTableLayoutPanel.Name = "buttonTableLayoutPanel";
            this.buttonTableLayoutPanel.RowCount = 6;
            this.buttonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.buttonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.buttonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.buttonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.buttonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.buttonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.buttonTableLayoutPanel.Size = new System.Drawing.Size(140, 553);
            this.buttonTableLayoutPanel.TabIndex = 8;
            // 
            // addAllSheetsButton
            // 
            this.addAllSheetsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addAllSheetsButton.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.addAllSheetsButton.Location = new System.Drawing.Point(5, 143);
            this.addAllSheetsButton.Margin = new System.Windows.Forms.Padding(5);
            this.addAllSheetsButton.Name = "addAllSheetsButton";
            this.addAllSheetsButton.Size = new System.Drawing.Size(130, 72);
            this.addAllSheetsButton.TabIndex = 8;
            this.addAllSheetsButton.Text = "加入所有的表單";
            this.addAllSheetsButton.UseVisualStyleBackColor = true;
            this.addAllSheetsButton.Click += new System.EventHandler(this.addAllSheetsButton_Click);
            // 
            // mergeButton
            // 
            this.mergeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mergeButton.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.mergeButton.Location = new System.Drawing.Point(5, 471);
            this.mergeButton.Margin = new System.Windows.Forms.Padding(5);
            this.mergeButton.Name = "mergeButton";
            this.mergeButton.Size = new System.Drawing.Size(130, 77);
            this.mergeButton.TabIndex = 3;
            this.mergeButton.Text = "合併";
            this.mergeButton.UseVisualStyleBackColor = true;
            this.mergeButton.Click += new System.EventHandler(this.mergeButton_Click);
            // 
            // deleteAllSelectedSheetsButton
            // 
            this.deleteAllSelectedSheetsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteAllSelectedSheetsButton.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.deleteAllSelectedSheetsButton.Location = new System.Drawing.Point(5, 307);
            this.deleteAllSelectedSheetsButton.Margin = new System.Windows.Forms.Padding(5);
            this.deleteAllSelectedSheetsButton.Name = "deleteAllSelectedSheetsButton";
            this.deleteAllSelectedSheetsButton.Size = new System.Drawing.Size(130, 72);
            this.deleteAllSelectedSheetsButton.TabIndex = 9;
            this.deleteAllSelectedSheetsButton.Text = "刪除所有的表單";
            this.deleteAllSelectedSheetsButton.UseVisualStyleBackColor = true;
            this.deleteAllSelectedSheetsButton.Click += new System.EventHandler(this.deleteAllSelectedSheetsButton_Click);
            // 
            // fileTableLayoutPanel
            // 
            this.fileTableLayoutPanel.ColumnCount = 2;
            this.fileTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.fileTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.fileTableLayoutPanel.Controls.Add(this.allSheetsLabel, 0, 1);
            this.fileTableLayoutPanel.Controls.Add(this.addedExcelComboBox, 0, 0);
            this.fileTableLayoutPanel.Controls.Add(this.selectedSheetsLabel, 1, 1);
            this.fileTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileTableLayoutPanel.Location = new System.Drawing.Point(6, 5);
            this.fileTableLayoutPanel.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.fileTableLayoutPanel.Name = "fileTableLayoutPanel";
            this.fileTableLayoutPanel.RowCount = 2;
            this.fileTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.fileTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.fileTableLayoutPanel.Size = new System.Drawing.Size(818, 73);
            this.fileTableLayoutPanel.TabIndex = 9;
            // 
            // allSheetsLabel
            // 
            this.allSheetsLabel.AutoSize = true;
            this.allSheetsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allSheetsLabel.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.allSheetsLabel.Location = new System.Drawing.Point(5, 48);
            this.allSheetsLabel.Margin = new System.Windows.Forms.Padding(5);
            this.allSheetsLabel.Name = "allSheetsLabel";
            this.allSheetsLabel.Size = new System.Drawing.Size(562, 20);
            this.allSheetsLabel.TabIndex = 6;
            this.allSheetsLabel.Text = "所有的表單(壓住Ctrl可多重選擇)";
            this.allSheetsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // addedExcelComboBox
            // 
            this.fileTableLayoutPanel.SetColumnSpan(this.addedExcelComboBox, 2);
            this.addedExcelComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addedExcelComboBox.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.addedExcelComboBox.FormattingEnabled = true;
            this.addedExcelComboBox.ItemHeight = 27;
            this.addedExcelComboBox.Location = new System.Drawing.Point(5, 5);
            this.addedExcelComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.addedExcelComboBox.Name = "addedExcelComboBox";
            this.addedExcelComboBox.Size = new System.Drawing.Size(808, 35);
            this.addedExcelComboBox.TabIndex = 8;
            this.addedExcelComboBox.SelectedIndexChanged += new System.EventHandler(this.addedExcelComboBox_SelectedIndexChanged);
            // 
            // selectedSheetsLabel
            // 
            this.selectedSheetsLabel.AutoSize = true;
            this.selectedSheetsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectedSheetsLabel.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.selectedSheetsLabel.Location = new System.Drawing.Point(577, 48);
            this.selectedSheetsLabel.Margin = new System.Windows.Forms.Padding(5);
            this.selectedSheetsLabel.Name = "selectedSheetsLabel";
            this.selectedSheetsLabel.Size = new System.Drawing.Size(236, 20);
            this.selectedSheetsLabel.TabIndex = 7;
            this.selectedSheetsLabel.Text = "所有選擇的表單";
            this.selectedSheetsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // selectedSheetsTreeView
            // 
            this.selectedSheetsTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectedSheetsTreeView.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.selectedSheetsTreeView.ItemHeight = 25;
            this.selectedSheetsTreeView.Location = new System.Drawing.Point(581, 5);
            this.selectedSheetsTreeView.Margin = new System.Windows.Forms.Padding(5);
            this.selectedSheetsTreeView.Name = "selectedSheetsTreeView";
            this.selectedSheetsTreeView.Size = new System.Drawing.Size(238, 456);
            this.selectedSheetsTreeView.TabIndex = 9;
            // 
            // allSheetsListView
            // 
            this.allSheetsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.imageColumnHeader});
            this.allSheetsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allSheetsListView.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.allSheetsListView.ForeColor = System.Drawing.SystemColors.WindowText;
            this.allSheetsListView.FullRowSelect = true;
            this.allSheetsListView.GridLines = true;
            this.allSheetsListView.HideSelection = false;
            this.allSheetsListView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.allSheetsListView.Location = new System.Drawing.Point(5, 5);
            this.allSheetsListView.Margin = new System.Windows.Forms.Padding(5);
            this.allSheetsListView.Name = "allSheetsListView";
            this.allSheetsListView.OwnerDraw = true;
            this.allSheetsListView.Size = new System.Drawing.Size(566, 456);
            this.allSheetsListView.TabIndex = 10;
            this.allSheetsListView.UseCompatibleStateImageBehavior = false;
            this.allSheetsListView.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.allSheetsListView_DrawItem);
            // 
            // imageColumnHeader
            // 
            this.imageColumnHeader.Text = "樣式";
            this.imageColumnHeader.Width = 120;
            // 
            // showTableLayoutPanel
            // 
            this.showTableLayoutPanel.ColumnCount = 1;
            this.showTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.showTableLayoutPanel.Controls.Add(this.sheetTableLayoutPanel, 0, 1);
            this.showTableLayoutPanel.Controls.Add(this.fileTableLayoutPanel, 0, 0);
            this.showTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.showTableLayoutPanel.Name = "showTableLayoutPanel";
            this.showTableLayoutPanel.RowCount = 2;
            this.showTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.showTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.showTableLayoutPanel.Size = new System.Drawing.Size(830, 555);
            this.showTableLayoutPanel.TabIndex = 10;
            // 
            // sheetTableLayoutPanel
            // 
            this.sheetTableLayoutPanel.ColumnCount = 2;
            this.sheetTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.sheetTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.sheetTableLayoutPanel.Controls.Add(this.selectedSheetsTreeView, 1, 0);
            this.sheetTableLayoutPanel.Controls.Add(this.allSheetsListView, 0, 0);
            this.sheetTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sheetTableLayoutPanel.Location = new System.Drawing.Point(3, 86);
            this.sheetTableLayoutPanel.Name = "sheetTableLayoutPanel";
            this.sheetTableLayoutPanel.RowCount = 1;
            this.sheetTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sheetTableLayoutPanel.Size = new System.Drawing.Size(824, 466);
            this.sheetTableLayoutPanel.TabIndex = 0;
            // 
            // outerTableLayoutPanel
            // 
            this.outerTableLayoutPanel.ColumnCount = 2;
            this.outerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.outerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.outerTableLayoutPanel.Controls.Add(this.buttonTableLayoutPanel, 1, 0);
            this.outerTableLayoutPanel.Controls.Add(this.showTableLayoutPanel, 0, 0);
            this.outerTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outerTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.outerTableLayoutPanel.Name = "outerTableLayoutPanel";
            this.outerTableLayoutPanel.RowCount = 1;
            this.outerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.outerTableLayoutPanel.Size = new System.Drawing.Size(984, 561);
            this.outerTableLayoutPanel.TabIndex = 11;
            // 
            // ExcelMergeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.outerTableLayoutPanel);
            this.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "ExcelMergeForm";
            this.ShowIcon = false;
            this.Text = "Excel Merge Tool --------- Directed By KarosChen 仿冒必究";
            this.buttonTableLayoutPanel.ResumeLayout(false);
            this.fileTableLayoutPanel.ResumeLayout(false);
            this.fileTableLayoutPanel.PerformLayout();
            this.showTableLayoutPanel.ResumeLayout(false);
            this.sheetTableLayoutPanel.ResumeLayout(false);
            this.outerTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openExcelButton;
        private System.Windows.Forms.Button addSelectedSheetButton;
        private System.Windows.Forms.Button deleteSelectedSheetButton;
        private System.Windows.Forms.TableLayoutPanel buttonTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel fileTableLayoutPanel;
        private System.Windows.Forms.Label allSheetsLabel;
        private System.Windows.Forms.Label selectedSheetsLabel;
        private System.Windows.Forms.Button addAllSheetsButton;
        private System.Windows.Forms.ComboBox addedExcelComboBox;
        private System.Windows.Forms.TreeView selectedSheetsTreeView;
        private System.Windows.Forms.Button mergeButton;
        private System.Windows.Forms.Button deleteAllSelectedSheetsButton;
        private System.Windows.Forms.ListView allSheetsListView;
        private System.Windows.Forms.ColumnHeader imageColumnHeader;
        private System.Windows.Forms.TableLayoutPanel showTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel sheetTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel outerTableLayoutPanel;
    }
}

