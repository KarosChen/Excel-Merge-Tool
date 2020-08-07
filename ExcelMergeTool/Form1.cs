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
        bool _isExisted = false;
        int _isShowingFile = -1;
        private Model _model;
        private List<string> _allSheetsList = new List<string>();
        public ExcelMergeForm()
        {
            InitializeComponent();
            _model = new Model();
            _currentDirectory = System.IO.Directory.GetCurrentDirectory();
            setButtonEnableProperty();
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
                    //check file is not existed
                    string fileName = openFileDialog.FileName;
                    foreach (string existedFile in addedExcelComboBox.Items)
                    {
                        if(existedFile == fileName)
                        {
                            _isExisted = true;
                            break;
                        }
                    }

                    if (!_isExisted)
                    {
                        try
                        {
                            _model.OpenSourceFileName(fileName);
                            //When combox is added new item, it will execute addedExcelComboBox_SelectedIndexChanged function
                            addedExcelComboBox.Items.Add(fileName);
                            addedExcelComboBox.Text = fileName;
                            _currentDirectory = Path.GetDirectoryName(fileName);

                            //add class node in TreeView
                            TreeNode fileNode = new TreeNode(fileName);
                            fileNode.Name = fileName;
                            fileNode.ForeColor = Color.Red;
                            selectedSheetsTreeView.Nodes.Add(fileNode);
                            setButtonEnableProperty();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("請確認要加入的檔案是否關閉了!");
                        }
                    }
                }
            }
        }

        private void addSelectedSheetButton_Click(object sender, EventArgs e)
        {
            List<string> selectedSheetNames = allSheetsListBox.SelectedItems.Cast<string>().ToList();
            List<string> notDuplicatedSheetNames = new List<string>();
            TreeNode[] findedFileNodes = selectedSheetsTreeView.Nodes.Find(addedExcelComboBox.Text, false);
            foreach (string sheetName in selectedSheetNames)
            {
                TreeNode[] findedSheetNodes = findedFileNodes[0].Nodes.Find(sheetName, false);

                if (findedSheetNodes.Length == 0)
                {
                    TreeNode sheetNode = new TreeNode(sheetName);
                    sheetNode.Name = sheetName;
                    findedFileNodes[0].Nodes.Add(sheetNode);
                    notDuplicatedSheetNames.Add(sheetName);
                }
            }
            _model.AddSelectedSheets(_isShowingFile, notDuplicatedSheetNames);
            setButtonEnableProperty();
        }

        private void addAllSheetsButton_Click(object sender, EventArgs e)
        {
            List<string> notDuplicatedSheetNames = new List<string>();
            TreeNode[] findedFileNodes = selectedSheetsTreeView.Nodes.Find(addedExcelComboBox.Text, false);
            foreach (string sheetName in _allSheetsList)
            {
                TreeNode[] findedSheetNodes = findedFileNodes[0].Nodes.Find(sheetName, false);

                if (findedSheetNodes.Length == 0)
                {
                    TreeNode sheetNode = new TreeNode(sheetName);
                    sheetNode.Name = sheetName;
                    findedFileNodes[0].Nodes.Add(sheetNode);
                    notDuplicatedSheetNames.Add(sheetName);
                }
            }
            _model.AddSelectedSheets(_isShowingFile, notDuplicatedSheetNames);
            setButtonEnableProperty();
        }

        private void deleteSelectedSheetButton_Click(object sender, EventArgs e)
        {
            if (selectedSheetsTreeView.SelectedNode.Level == 1)
            {
                _model.DeleteSelectedSheet(selectedSheetsTreeView.SelectedNode.Parent.Name, selectedSheetsTreeView.SelectedNode.Name);
                selectedSheetsTreeView.SelectedNode.Remove();
            }
            setButtonEnableProperty();
        }

        private void deleteAllSelectedSheetsButton_Click(object sender, EventArgs e)
        {
            TreeNodeCollection fileNodeCollection = selectedSheetsTreeView.Nodes;
            foreach (TreeNode fileNode in fileNodeCollection)
            {
                fileNode.Nodes.Clear();
            }
            _model.DeleteAllSelectedSheet();
            setButtonEnableProperty();
        }

        private void mergeButton_Click(object sender, EventArgs e)
        {
            mergeButton.Enabled = false;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Word Documents | *.doc";
            saveFileDialog1.Title = "選擇文件的存取位置";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                _savePath = saveFileDialog1.FileName;
                _model.MergeSelectedSheets(_currentDirectory, _savePath);
            }
            mergeButton.Enabled = true;
        }

        private void addedExcelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (allSheetsListBox.Items.Count != 0)
            {
                allSheetsListBox.Items.Clear();
                _allSheetsList.Clear();
            }

            if (addedExcelComboBox.SelectedIndex > -1)
            {
                putAllSheetsInListBox(addedExcelComboBox.SelectedIndex);
                _isShowingFile = addedExcelComboBox.SelectedIndex;
            }
        }

        private void putAllSheetsInListBox(int index)
        {
            _allSheetsList = _model.GetAllSheetsFromExcel(index);
            foreach (string sheet in _allSheetsList)
            {
                allSheetsListBox.Items.Add(sheet);
            }
        }

        private void setButtonEnableProperty()
        {
            if (_isShowingFile > -1)
            {
                addSelectedSheetButton.Enabled = true;
                addAllSheetsButton.Enabled = true;
            }
            else
            {
                addSelectedSheetButton.Enabled = false;
                addAllSheetsButton.Enabled = false;
            }

            if (_model.CheckSelectedDictIsEmpty())
            {
                deleteSelectedSheetButton.Enabled = false;
                deleteAllSelectedSheetsButton.Enabled = false;
                mergeButton.Enabled = false;
            }
            else
            {
                deleteSelectedSheetButton.Enabled = true;
                deleteAllSelectedSheetsButton.Enabled = true;
                mergeButton.Enabled = true;
            }
        }
    }
}
