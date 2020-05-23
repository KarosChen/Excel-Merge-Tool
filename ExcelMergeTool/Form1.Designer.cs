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
            this.allSheetsListBox = new System.Windows.Forms.ListBox();
            this.mergeButton = new System.Windows.Forms.Button();
            this.sourceExcelTextBox = new System.Windows.Forms.TextBox();
            this.selectedSheetsListBox = new System.Windows.Forms.ListBox();
            this.addSelectedSheetButton = new System.Windows.Forms.Button();
            this.deleteSelectedSheetNutton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.allSheetsLabel = new System.Windows.Forms.Label();
            this.selectedSheetsLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openExcelButton
            // 
            this.openExcelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openExcelButton.Location = new System.Drawing.Point(5, 5);
            this.openExcelButton.Margin = new System.Windows.Forms.Padding(5);
            this.openExcelButton.Name = "openExcelButton";
            this.openExcelButton.Size = new System.Drawing.Size(114, 80);
            this.openExcelButton.TabIndex = 0;
            this.openExcelButton.Text = "打開Excel";
            this.openExcelButton.UseVisualStyleBackColor = true;
            this.openExcelButton.Click += new System.EventHandler(this.addExcelButton_Click);
            // 
            // allSheetsListBox
            // 
            this.allSheetsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allSheetsListBox.FormattingEnabled = true;
            this.allSheetsListBox.ItemHeight = 12;
            this.allSheetsListBox.Location = new System.Drawing.Point(5, 77);
            this.allSheetsListBox.Margin = new System.Windows.Forms.Padding(5);
            this.allSheetsListBox.Name = "allSheetsListBox";
            this.allSheetsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.allSheetsListBox.Size = new System.Drawing.Size(220, 279);
            this.allSheetsListBox.TabIndex = 1;
            // 
            // mergeButton
            // 
            this.mergeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mergeButton.Location = new System.Drawing.Point(5, 275);
            this.mergeButton.Margin = new System.Windows.Forms.Padding(5);
            this.mergeButton.Name = "mergeButton";
            this.mergeButton.Size = new System.Drawing.Size(114, 81);
            this.mergeButton.TabIndex = 3;
            this.mergeButton.Text = "合併";
            this.mergeButton.UseVisualStyleBackColor = true;
            this.mergeButton.Click += new System.EventHandler(this.mergeButton_Click);
            // 
            // sourceExcelTextBox
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.sourceExcelTextBox, 2);
            this.sourceExcelTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sourceExcelTextBox.Location = new System.Drawing.Point(5, 5);
            this.sourceExcelTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.sourceExcelTextBox.Name = "sourceExcelTextBox";
            this.sourceExcelTextBox.Size = new System.Drawing.Size(450, 22);
            this.sourceExcelTextBox.TabIndex = 4;
            this.sourceExcelTextBox.TextChanged += new System.EventHandler(this.sourceExcelTextBox_TextChanged);
            // 
            // selectedSheetsListBox
            // 
            this.selectedSheetsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectedSheetsListBox.FormattingEnabled = true;
            this.selectedSheetsListBox.ItemHeight = 12;
            this.selectedSheetsListBox.Location = new System.Drawing.Point(235, 77);
            this.selectedSheetsListBox.Margin = new System.Windows.Forms.Padding(5);
            this.selectedSheetsListBox.Name = "selectedSheetsListBox";
            this.selectedSheetsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.selectedSheetsListBox.Size = new System.Drawing.Size(220, 279);
            this.selectedSheetsListBox.TabIndex = 5;
            // 
            // addSelectedSheetButton
            // 
            this.addSelectedSheetButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addSelectedSheetButton.Location = new System.Drawing.Point(5, 95);
            this.addSelectedSheetButton.Margin = new System.Windows.Forms.Padding(5);
            this.addSelectedSheetButton.Name = "addSelectedSheetButton";
            this.addSelectedSheetButton.Size = new System.Drawing.Size(114, 80);
            this.addSelectedSheetButton.TabIndex = 6;
            this.addSelectedSheetButton.Text = "加入選擇的表";
            this.addSelectedSheetButton.UseVisualStyleBackColor = true;
            this.addSelectedSheetButton.Click += new System.EventHandler(this.addSelectedSheetButton_Click);
            // 
            // deleteSelectedSheetNutton
            // 
            this.deleteSelectedSheetNutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteSelectedSheetNutton.Location = new System.Drawing.Point(5, 185);
            this.deleteSelectedSheetNutton.Margin = new System.Windows.Forms.Padding(5);
            this.deleteSelectedSheetNutton.Name = "deleteSelectedSheetNutton";
            this.deleteSelectedSheetNutton.Size = new System.Drawing.Size(114, 80);
            this.deleteSelectedSheetNutton.TabIndex = 7;
            this.deleteSelectedSheetNutton.Text = "刪除選擇的表";
            this.deleteSelectedSheetNutton.UseVisualStyleBackColor = true;
            this.deleteSelectedSheetNutton.Click += new System.EventHandler(this.deleteSelectedSheetNutton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel1.Controls.Add(this.openExcelButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.mergeButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.deleteSelectedSheetNutton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.addSelectedSheetButton, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(460, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(124, 361);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.allSheetsListBox, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.selectedSheetsListBox, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.sourceExcelTextBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.allSheetsLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.selectedSheetsLabel, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(460, 361);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // allSheetsLabel
            // 
            this.allSheetsLabel.AutoSize = true;
            this.allSheetsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allSheetsLabel.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.allSheetsLabel.Location = new System.Drawing.Point(3, 36);
            this.allSheetsLabel.Name = "allSheetsLabel";
            this.allSheetsLabel.Size = new System.Drawing.Size(224, 36);
            this.allSheetsLabel.TabIndex = 6;
            this.allSheetsLabel.Text = "Excel中所有的表單";
            this.allSheetsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // selectedSheetsLabel
            // 
            this.selectedSheetsLabel.AutoSize = true;
            this.selectedSheetsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectedSheetsLabel.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.selectedSheetsLabel.Location = new System.Drawing.Point(233, 36);
            this.selectedSheetsLabel.Name = "selectedSheetsLabel";
            this.selectedSheetsLabel.Size = new System.Drawing.Size(224, 36);
            this.selectedSheetsLabel.TabIndex = 7;
            this.selectedSheetsLabel.Text = "選擇合併的表單";
            this.selectedSheetsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.selectedSheetsLabel.Click += new System.EventHandler(this.selectedSheetsLabel_Click);
            // 
            // ExcelMergeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ExcelMergeForm";
            this.Text = "Excel Merge Tool";
            this.Load += new System.EventHandler(this.ExcelMergeForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openExcelButton;
        private System.Windows.Forms.ListBox allSheetsListBox;
        private System.Windows.Forms.Button mergeButton;
        private System.Windows.Forms.TextBox sourceExcelTextBox;
        private System.Windows.Forms.ListBox selectedSheetsListBox;
        private System.Windows.Forms.Button addSelectedSheetButton;
        private System.Windows.Forms.Button deleteSelectedSheetNutton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label allSheetsLabel;
        private System.Windows.Forms.Label selectedSheetsLabel;
    }
}

