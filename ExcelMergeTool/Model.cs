using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelMergeTool
{
    class Model
    {
        private List<string> fileNames = new List<string>();
        
        public void AddNewFileName (string fileName)
        {
            fileNames.Add(fileName);
        }

    }
}
