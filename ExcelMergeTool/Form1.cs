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
        private string _currentDirectory = "";
        private Model _model;
        public ExcelMergeForm()
        {
            InitializeComponent();
            _model = new Model();
            _currentDirectory = System.IO.Directory.GetCurrentDirectory();
        }

        private void addExcelButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = _currentDirectory;
                openFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
                openFileDialog.RestoreDirectory = true;
                openFileDialog.Multiselect = true;
                openFileDialog.Title = "選擇要合併的Excel檔案";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (string fileName in openFileDialog.FileNames)
                    {
                        _model.AddNewFileName(fileName);
                        fileNameListBox.Items.Add(fileName);
                        _currentDirectory = Path.GetDirectoryName(fileName);
                    }
                }

            }
        }

        private void deleteExcelButton_Click(object sender, EventArgs e)
        {
            List<string> fileNames = fileNameListBox.SelectedItems.Cast<string>().ToList();
            foreach (string fileName in fileNames)
            {
                _model.DeleteFileName(fileName);
                fileNameListBox.Items.Remove(fileName);
            }
        }

        private void mergeButton_Click(object sender, EventArgs e)
        {
            _model.MergeAllFile();

        }
    }
}
