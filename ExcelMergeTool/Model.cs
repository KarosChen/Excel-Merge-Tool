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
using Word = Microsoft.Office.Interop.Word;


namespace ExcelMergeTool
{
    class Model
    {
        private List<string> fileNames = new List<string>();
        private List<string> srcImagesPath = new List<string>();
        
        public void AddNewFileName (string fileName)
        {
            fileNames.Add(fileName);
        }
        
        public void DeleteFileName (string fileName)
        {
            fileNames.Remove(fileName);
        }

        public void MergeAllFile ()
        {
            Workbook srcBook = new Workbook();
            srcBook.LoadFromFile(fileNames[0]);

            int sheetCount = srcBook.Worksheets.Count;
            for (int i = 0; i < sheetCount; i++)
            {
                string fileName = "D:\\Desktop\\" + i + ".jpeg";
                srcBook.Worksheets[i].SaveToImage(fileName);
                Bitmap srcImage = Image.FromFile(fileName) as Bitmap;
                int start_x = 0;
                int start_y = srcImage.Height - Convert.ToInt32(srcImage.Height * 0.9);
                System.Drawing.Rectangle cropArea = new System.Drawing.Rectangle(start_x, start_y, srcImage.Width, Convert.ToInt32(srcImage.Height * 0.9));
                Bitmap desImage = srcImage.Clone(cropArea, srcImage.PixelFormat);
                desImage.Save("D:\\Desktop\\" + i + "a.jpeg");
                srcImagesPath.Add("D:\\Desktop\\" + i + "a.jpeg");
            }
            AddImageToWord(@"D:\\Desktop\test.docx");
            
        }

        public void AddImageToWord(string savePath)
        {
            Word.Application wordApp = new Word.Application();
            Word.Document wordDoc = wordApp.Documents.Add();
            Word.Range docRange = wordDoc.Range();

            foreach (string imagePath in srcImagesPath)
            {
                // Create an InlineShape in the InlineShapes collection where the picture should be added later
                // It is used to get automatically scaled sizes.
                Word.InlineShape autoScaledInlineShape = docRange.InlineShapes.AddPicture(imagePath, false, false, docRange); ;
                float scaledWidth = autoScaledInlineShape.Width;
                float scaledHeight = autoScaledInlineShape.Height;
                autoScaledInlineShape.Delete();

                // Create a new Shape and fill it with the picture
                Word.Shape newShape = wordDoc.Shapes.AddShape(1, 0, 0, scaledWidth, scaledHeight);
                newShape.Fill.UserPicture(imagePath);

                // Convert the Shape to an InlineShape and optional disable Border
                Word.InlineShape finalInlineShape = newShape.ConvertToInlineShape();
                finalInlineShape.Line.Visible = Microsoft.Office.Core.MsoTriState.msoFalse;

                // Cut the range of the InlineShape to clipboard
                finalInlineShape.Range.Cut();

                // And paste it to the target Range
                docRange.Paste();
            }

            wordDoc.SaveAs2(savePath);
            wordApp.Quit();
        }
    }
}
