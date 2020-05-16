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
            this.addExcelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addExcelButton
            // 
            this.addExcelButton.Location = new System.Drawing.Point(613, 12);
            this.addExcelButton.Name = "addExcelButton";
            this.addExcelButton.Size = new System.Drawing.Size(153, 59);
            this.addExcelButton.TabIndex = 0;
            this.addExcelButton.Text = "加入Excel";
            this.addExcelButton.UseVisualStyleBackColor = true;
            this.addExcelButton.Click += new System.EventHandler(this.addExcelButton_Click);
            // 
            // ExcelMergeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.Controls.Add(this.addExcelButton);
            this.Name = "ExcelMergeForm";
            this.Text = "Excel Merge Tool";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addExcelButton;
    }
}

