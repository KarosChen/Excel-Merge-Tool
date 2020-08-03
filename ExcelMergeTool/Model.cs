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


namespace ExcelMergeTool
{
    class Model
    {
        //private List<string> fileNames = new List<string>();
        private string _srcFilePath = "";
        private List<Workbook> _srcBooksList = new List<Workbook>();
        private List<string> _addedImagesPath = new List<string>();
        private List<string> _allSheetsList = new List<string>();
        private List<Worksheet> _selectedSheetsList = new List<Worksheet>();

        public void openSourceFileName (string fileName)
        {
            _srcFilePath = fileName;
            Workbook srcBook = new Workbook();
            srcBook.LoadFromFile(_srcFilePath);
            _srcBooksList.Add(srcBook);
        }

        public List<string> GetAllSheetsFromExcel(int index)
        {
            if (_allSheetsList.Count != 0)
            {
                _allSheetsList.Clear();
            }
            Workbook srcBook = _srcBooksList[index];
            foreach (Worksheet sheet in srcBook.Worksheets)
            {
                _allSheetsList.Add(sheet.Name);
            }
            return _allSheetsList;
        }

        public void addSelectedSheets(int bookIndex, List<string> sheetNames)
        {
            Workbook selectedBook = _srcBooksList[bookIndex];
            foreach (string sheetName in sheetNames)
            {
                foreach (Worksheet sheet in selectedBook.Worksheets)
                {
                    if (sheet.Name == sheetName)
                    {
                        _selectedSheetsList.Add(sheet);
                        break;
                    }
                }
            }
        }

        public void deleteSelectedSheet(int bookIndex, string sheetName)
        {
            Workbook selectedBook = _srcBooksList[bookIndex];
            foreach (Worksheet sheet in selectedBook.Worksheets)
            {
                if (sheet.Name == sheetName)
                {
                    _selectedSheetsList.Remove(sheet);
                    break;
                }
            }
        }

        public void MergeSelectedSheets (string currentDirectory, string savePath)
        {
            int sheetCount = _selectedSheetsList.Count;
            string imagePath = "";
            if (_addedImagesPath.Count != 0)
            {
                _addedImagesPath.Clear();
            }
            
            for (int i = 0; i < sheetCount; i++)
            {
                Worksheet sheet = _selectedSheetsList[i];
                imagePath = currentDirectory + "\\" + i + ".jpeg";
                using (MemoryStream memStream = new MemoryStream())
                {
                    sheet.SaveToStream(memStream, "\n");
                    using (StreamWriter sw = new StreamWriter(imagePath))
                    {
                        memStream.CopyTo(sw.BaseStream);
                        sw.Flush();
                        sw.Close();
                    }
                }
                sheet.SaveToImage(imagePath);
                _addedImagesPath.Add(imagePath);
                /*
                foreach (Worksheet sheet in _selectedSheetsList)
                {
                    imagePath = currentDirectory + "\\" + i + ".jpeg";
                    using (MemoryStream memStream = new MemoryStream())
                    {
                        sheet.SaveToStream(memStream, "\n");
                        using (StreamWriter sw = new StreamWriter(imagePath))
                        {
                            memStream.CopyTo(sw.BaseStream);
                            sw.Flush();
                            sw.Close();
                        }
                    }
                    sheet.SaveToImage(imagePath);
                    break;
                }
                _addedImagesPath.Add(imagePath);*/
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
