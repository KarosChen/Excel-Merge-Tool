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
        private List<string> _allSheetsNameList;
        private ImageList _allSheetsImageList;
        int _isShowingFile = -1;
        private ListViewItem clickedItem;

        public ExcelMergeForm()
        {
            InitializeComponent();
            _model = new Model();
            _currentDirectory = System.IO.Directory.GetCurrentDirectory();
            setButtonEnableProperty();
        }

        private void addExcelButton_Click(object sender, EventArgs e)
        {
            bool _isExisted = false;
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
                            try
                            {
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
                            catch
                            {
                                addedExcelComboBox.Items.Remove(fileName);
                                addedExcelComboBox.Text = "";
                                _model.RemoveSourceFileName(fileName);
                                MessageBox.Show("請確認加入的Excel中每一個表單都有樣式圖!");
                            }
                        }
                        catch
                        {
                            MessageBox.Show("請確認要加入的檔案是否關閉了!");
                        }
                    }
                }
            }
        }

        private void deleteExcelButton_Click(object sender, EventArgs e)
        {
            string deletedFileName = addedExcelComboBox.SelectedItem.ToString();
            _model.DeleteAllSheetsFromExcelName(deletedFileName);
            _model.RemoveSourceFileName(deletedFileName);
            addedExcelComboBox.Items.Remove(addedExcelComboBox.SelectedItem);
            addedExcelComboBox.Text = "";
            TreeNode[] fileNodes = selectedSheetsTreeView.Nodes.Find(deletedFileName, false);
            selectedSheetsTreeView.Nodes.Remove(fileNodes[0]);
            _isShowingFile = -1;
            allSheetsListView.Items.Clear();
            _allSheetsNameList.Clear();
            _allSheetsImageList.Images.Clear();
            setButtonEnableProperty();
        }

        private void addSelectedSheetButton_Click(object sender, EventArgs e)
        {
            List<string> selectedSheetNames = new List<string>();
            
            for (int i = 0; i < allSheetsListView.SelectedItems.Count; i++)
            {
                selectedSheetNames.Add(allSheetsListView.SelectedItems[i].Text);
            }

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
            foreach (string sheetName in _allSheetsNameList)
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
            try
            {
                if (selectedSheetsTreeView.SelectedNode.Level == 1)
                {
                    _model.DeleteSelectedSheet(selectedSheetsTreeView.SelectedNode.Parent.Name, selectedSheetsTreeView.SelectedNode.Name);
                    selectedSheetsTreeView.SelectedNode.Remove();
                }
                setButtonEnableProperty();
            }
            catch
            {
                MessageBox.Show("請先選擇要刪除的項目!");
            }
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

            if (allSheetsListView.Items.Count != 0)
            {
                allSheetsListView.Items.Clear();
                _allSheetsNameList.Clear();
                _allSheetsImageList.Images.Clear();
            }

            if (addedExcelComboBox.SelectedIndex > -1)
            {
                putAllSheetsInListBox(addedExcelComboBox.SelectedIndex);
                _isShowingFile = addedExcelComboBox.SelectedIndex;
                setButtonEnableProperty();
            }
        }

        private void putAllSheetsInListBox(int index)
        {

            Tuple<List<string>, ImageList> _allSheetsTuple = _model.GetAllSheetsFromExcel(index);
            _allSheetsNameList = _allSheetsTuple.Item1;
            _allSheetsImageList = _allSheetsTuple.Item2;
            allSheetsListView.LargeImageList = _allSheetsImageList;
            allSheetsListView.BeginUpdate();
            for (int i = 0; i < _allSheetsNameList.Count; i++)
            {
                allSheetsListView.Items.Add(_allSheetsNameList[i], i);
            }
            allSheetsListView.EndUpdate();
        }

        private void allSheetsListView_DrawItem(object sender, DrawListViewItemEventArgs item)
        {
            item.DrawDefault = true;
            using (SolidBrush itemBrush = new SolidBrush(Color.WhiteSmoke))
            {
                item.Graphics.DrawRectangle(Pens.Red, item.Bounds);
                item.Graphics.FillRectangle(itemBrush, item.Bounds);
            }
        }

        private void setButtonEnableProperty()
        {
            if (_isShowingFile > -1)
            {
                addSelectedSheetButton.Enabled = true;
                addAllSheetsButton.Enabled = true;
                deleteExcelButton.Enabled = true;
            }
            else
            {
                addSelectedSheetButton.Enabled = false;
                addAllSheetsButton.Enabled = false;
                deleteExcelButton.Enabled = false;
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
