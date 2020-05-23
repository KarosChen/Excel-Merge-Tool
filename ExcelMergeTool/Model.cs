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
using Spire.Xls;
using WordLib = Microsoft.Office.Interop.Word;


namespace ExcelMergeTool
{
    class Model
    {
        //private List<string> fileNames = new List<string>();
        private string srcFilePath = "";
        private List<string> addedImagesPath = new List<string>();
        private List<string> allSheetsList = new List<string>();
        private Workbook srcBook;

        public void openSourceFileName (string fileName)
        {
            srcFilePath = fileName;
            srcBook = new Workbook();
            srcBook.LoadFromFile(srcFilePath);
        }
        
        public void MergeSelectedSheets (List<string> selectedSheets, string currentDirectory, string savePath)
        {
            int sheetCount = selectedSheets.Count;
            string imagePath = "";
            if (addedImagesPath.Count != 0)
            {
                addedImagesPath.Clear();
            }

            for (int i = 0; i < sheetCount; i++)
            {
                foreach (Worksheet sheet in srcBook.Worksheets)
                {
                    if (sheet.Name == selectedSheets[i])
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
                }
                addedImagesPath.Add(imagePath);
            }
            AddImageToWord(savePath);
        }

        public void AddImageToWord(string savePath)
        {
            WordLib.Application wordApp = new WordLib.Application();
            WordLib.Document newWordDoc = wordApp.Documents.Add();
            WordLib.Range docRange = newWordDoc.Content;
            object oCollapseEnd = WordLib.WdCollapseDirection.wdCollapseEnd;

            foreach (string imagePath in addedImagesPath)
            {
                using (Bitmap srcImage = Image.FromFile(imagePath) as Bitmap)
                {
                    int start_x = 0;
                    int start_y = srcImage.Height - Convert.ToInt32(srcImage.Height * 0.9);
                    System.Drawing.Rectangle cropArea = new System.Drawing.Rectangle(start_x, start_y, srcImage.Width, Convert.ToInt32(srcImage.Height * 0.9));
                    Bitmap desImage = srcImage.Clone(cropArea, srcImage.PixelFormat);
                    //Put image in Clipboard
                    Clipboard.SetImage(desImage);
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
            foreach (string imagePath in addedImagesPath)
            {
                File.Delete(imagePath);
            }
        }

        public List<string> GetAllSheetsFromExcel()
        {
            if(allSheetsList.Count != 0)
            {
                allSheetsList.Clear();
            }
            foreach(Worksheet sheet in srcBook.Worksheets)
            {
                allSheetsList.Add(sheet.Name);
            }
            return allSheetsList;
        }
    }
}
