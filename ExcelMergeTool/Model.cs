using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Microsoft.Office.Interop.Word;
using Spire.Xls;
using WordLib = Microsoft.Office.Interop.Word;
using ExcelLib = Microsoft.Office.Interop.Excel;

namespace ExcelMergeTool
{
    class Model
    {
        //private List<string> fileNames = new List<string>();
        private string _srcFilePath = "";
        private List<Workbook> _srcBooksList = new List<Workbook>();
        private List<string> _addedImagesPath = new List<string>();
        private List<string> _allSheetsNameList = new List<string>();
        private ImageList _allSheetsImageList = new ImageList();
        private Dictionary<Tuple<string, string>, Worksheet> _selectedSheetsDict = new Dictionary<Tuple<string, string>, Worksheet>();

        public void OpenSourceFileName (string fileName)
        {
            _srcFilePath = fileName;
            Workbook srcBook = new Workbook();
            srcBook.LoadFromFile(_srcFilePath);
            _srcBooksList.Add(srcBook);
        }

        public void RemoveSourceFileName (string fileName)
        {
            _srcBooksList.Remove(_srcBooksList.Find(x => x.FileName == fileName));
        }

        public Tuple<List<string>, ImageList> GetAllSheetsFromExcel(int index)
        {
            if (_allSheetsNameList.Count != 0)
            {
                _allSheetsNameList.Clear();
                _allSheetsImageList.Images.Clear();
            }
            _allSheetsImageList.ImageSize = new Size(125, 125);
            Workbook srcBook = _srcBooksList[index];
            foreach (Worksheet sheet in srcBook.Worksheets)
            {
                _allSheetsNameList.Add(sheet.Name);    
                _allSheetsImageList.Images.Add(sheet.Pictures[0].Picture);
            }
            return new Tuple<List<string>, ImageList>(_allSheetsNameList, _allSheetsImageList);
        }

        public void DeleteAllSheetsFromExcelName(string fileName)
        {
            if (_allSheetsNameList.Count != 0)
            {
                _allSheetsNameList.Clear();
                _allSheetsImageList.Images.Clear();
            }

            foreach (KeyValuePair<Tuple<string, string>, Worksheet> sheet in _selectedSheetsDict.ToArray())
            {
                if (sheet.Key.Item1 == fileName)
                {
                    _selectedSheetsDict.Remove(sheet.Key);
                }
            }
        }

        public void AddSelectedSheets(int bookIndex, List<string> sheetNames)
        {
            Workbook selectedBook = _srcBooksList[bookIndex];
            foreach (string sheetName in sheetNames)
            {
                foreach (Worksheet sheet in selectedBook.Worksheets)
                {
                    if (sheet.Name == sheetName)
                    {
                        Tuple<string, string> selectedKey = new Tuple<string, string>(selectedBook.FileName, sheet.Name);
                        Worksheet selectedValue = sheet;
                        _selectedSheetsDict.Add(selectedKey, selectedValue);
                        break;
                    }
                }
            }
        }

        public void DeleteSelectedSheet(string bookName, string sheetName)
        {
            Tuple<string, string> selectedSheet = new Tuple<string, string>(bookName, sheetName);
            if (_selectedSheetsDict.ContainsKey(selectedSheet))
            {
                _selectedSheetsDict.Remove(selectedSheet);
            }
        }

        public void DeleteAllSelectedSheet()
        {
            _selectedSheetsDict.Clear();
        }

        public bool CheckSelectedDictIsEmpty()
        {
            if (_selectedSheetsDict.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void MergeSelectedSheets (string currentDirectory, string savePath)
        {
            string imagePath = "";
            if (_addedImagesPath.Count != 0)
            {
                _addedImagesPath.Clear();
            }

            int i = 0;

            foreach (KeyValuePair<Tuple<string, string>, Worksheet> sheet in _selectedSheetsDict)
            {
                i++;
                imagePath = currentDirectory + "\\"  + i + ".jpeg";
                using (MemoryStream memStream = new MemoryStream())
                {
                    sheet.Value.SaveToStream(memStream, "\n");
                    using (StreamWriter sw = new StreamWriter(imagePath))
                    {
                        memStream.CopyTo(sw.BaseStream);
                        sw.Flush();
                        sw.Close();
                    }
                }
                sheet.Value.SaveToImage(imagePath);
                _addedImagesPath.Add(imagePath);
            }

            AddImageToWord(savePath);
        }

        public void AddImageToWord(string savePath)
        {
            WordLib.Application wordApp = new WordLib.Application();
            WordLib.Document newWordDoc = wordApp.Documents.Add();
            WordLib.Range docRange = newWordDoc.Content;
            object oCollapseEnd = WordLib.WdCollapseDirection.wdCollapseEnd;
            newWordDoc.PageSetup.TopMargin = newWordDoc.Application.CentimetersToPoints((float)1.5);
            newWordDoc.PageSetup.BottomMargin = newWordDoc.Application.CentimetersToPoints((float)1.5);
            newWordDoc.PageSetup.LeftMargin = newWordDoc.Application.CentimetersToPoints((float)1.5);
            newWordDoc.PageSetup.RightMargin = newWordDoc.Application.CentimetersToPoints((float)1.5);

            foreach (string imagePath in _addedImagesPath)
            {
                using (Bitmap srcImage = Image.FromFile(imagePath) as Bitmap)
                {
                    int start_x = 40;
                    //int start_y = srcImage.Height - Convert.ToInt32(srcImage.Height * 0.9);
                    //System.Drawing.Rectangle cropArea = new System.Drawing.Rectangle(start_x, start_y, srcImage.Width, Convert.ToInt32(srcImage.Height * 0.9));
                    int start_y = 40;
                    System.Drawing.Rectangle cropArea = new System.Drawing.Rectangle(start_x, start_y, srcImage.Width - 2 * start_x, srcImage.Height - 2 * start_y);
                    Bitmap desImage = srcImage.Clone(cropArea, srcImage.PixelFormat);
                    Bitmap resizedImage = new Bitmap((Image)desImage, (int)(newWordDoc.PageSetup.PageWidth / 1.8), (int)(newWordDoc.PageSetup.PageHeight / 3.5));
                    //Put image in Clipboard
                    Clipboard.SetImage(resizedImage);
                    docRange.Collapse(ref oCollapseEnd);
                    docRange.Paste();

                }
            }
            newWordDoc.SaveAs2(savePath);
            wordApp.Quit();

            DeleteAllImageOnComputer();
        }

        public void DeleteAllImageOnComputer()
        {
            foreach (string imagePath in _addedImagesPath)
            {
                File.Delete(imagePath);
            }
        }

    }
}
