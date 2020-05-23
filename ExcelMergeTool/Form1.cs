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
        private string _savePath = "";
        private Model _model;
        private List<string> _allSheetsList = new List<string>();
        private List<string> _selectedSheetsList = new List<string>();
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
                openFileDialog.Multiselect = false;
                openFileDialog.Title = "選擇要合併的Excel檔案";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (allSheetsListBox.Items.Count != 0)
                    {
                        allSheetsListBox.Items.Clear();
                        _allSheetsList.Clear();
                        selectedSheetsListBox.Items.Clear();
                        _selectedSheetsList.Clear();
                    }

                    sourceExcelTextBox.Text = openFileDialog.FileName;
                    _model.openSourceFileName(openFileDialog.FileName);
                    _currentDirectory = Path.GetDirectoryName(openFileDialog.FileName);
                    putAllSheetsInListBox();
                }
            }
        }

        private void putAllSheetsInListBox()
        {
            _allSheetsList = _model.GetAllSheetsFromExcel();
            foreach (string sheet in _allSheetsList)
            {
                allSheetsListBox.Items.Add(sheet);
            }
        }

        private void mergeButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Word Documents | *.doc";
            saveFileDialog1.Title = "選擇文件的存取位置";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                _savePath = saveFileDialog1.FileName;
                _model.MergeSelectedSheets(_selectedSheetsList, _currentDirectory, _savePath);
            }
        }

        private void addSelectedSheetButton_Click(object sender, EventArgs e)
        {
            List<string> selectedSheetNames = allSheetsListBox.SelectedItems.Cast<string>().ToList();
            foreach (string sheetName in selectedSheetNames)
            {
                int index = selectedSheetsListBox.FindString(sheetName);
                if (index == -1)
                {
                    selectedSheetsListBox.Items.Add(sheetName);
                    _selectedSheetsList.Add(sheetName);
                }
            }
        }

        private void deleteSelectedSheetNutton_Click(object sender, EventArgs e)
        {
            List<string> selectedSheetNames = selectedSheetsListBox.SelectedItems.Cast<string>().ToList();
            foreach (string sheetName in selectedSheetNames)
            {
                selectedSheetsListBox.Items.Remove(sheetName);
                _selectedSheetsList.Remove(sheetName);
            }
        }
    }
}
