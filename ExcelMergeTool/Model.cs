using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spire.Xls;
namespace ExcelMergeTool
{
    class Model
    {
        private List<string> fileNames = new List<string>();
        
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
            Workbook newBook = new Workbook();
            newBook.LoadFromFile(fileNames[0]);
            Worksheet firstSheet = newBook.Worksheets[0];
            Workbook tempBook;
            
            for(int i = 0; i < fileNames.Count; i++)
            {
                if (i != 0)
                {
                    tempBook = new Workbook();
                    tempBook.LoadFromFile(fileNames[i]);
                    for (int j = 0; j < tempBook.Worksheets.Count; j++)
                    {
                        DataTable tempTable = tempBook.Worksheets[j].ExportDataTable();
                        firstSheet.InsertDataTable(tempTable, true, firstSheet.LastRow + 2, 1);
                    }
                }
                else
                {
                    for (int j = 1; j < newBook.Worksheets.Count; j++)
                    {
                        DataTable tempTable = newBook.Worksheets[j].ExportDataTable();
                        firstSheet.InsertDataTable(tempTable, true, firstSheet.LastRow + 2, 1);
                    }
                }
            }
            newBook.SaveToFile("D:\\Desktop\\MergeFile.xlsx");
        }
    }
}
