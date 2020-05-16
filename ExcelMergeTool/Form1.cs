using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelMergeTool
{
    public partial class ExcelMergeForm : Form
    {
        private Model model;
        public ExcelMergeForm()
        {
            InitializeComponent();
            model = new Model();
        }

        private void addExcelButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = System.IO.Directory.GetCurrentDirectory();
                openFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
                openFileDialog.RestoreDirectory = false;
                openFileDialog.Multiselect = true;
                openFileDialog.Title = "選擇要合併的Excel檔案";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (string fileName in openFileDialog.FileNames)
                    {
                        model.AddNewFileName(fileName);
                        fileNameListBox.Items.Add(fileName);
                    }
                }

            }
        }

        private void deleteExcelButton_Click(object sender, EventArgs e)
        {
            List<string> fileNames = fileNameListBox.SelectedItems.Cast<string>().ToList();
            foreach (string fileName in fileNames)
            {
                fileNameListBox.Items.Remove(fileName);
            }
        }
    }
}
