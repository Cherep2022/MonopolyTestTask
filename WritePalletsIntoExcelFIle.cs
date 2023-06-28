using MonopolyTestTask.ExcelReaderWriter;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Office.Core;
using Excel = Microsoft.Office.Core;

namespace MonopolyTestTask
{
    internal class WritePalletsIntoExcelFIle
    {
        string excelFilePath;
        public WritePalletsIntoExcelFIle(string excelFilePath)
        {
            this.excelFilePath = excelFilePath;
        }


        public void WritePallets(List<Pallet> pallets)
        {
            int counterRow = 2;
            int counterCol = 1;
            using (ExcelWriter excel = new ExcelWriter("Result.xlsx"))
            {
                foreach (Pallet pallet in pallets)
                {
                    excel.xlSht.Cells[counterRow, counterCol] = 234234;
                    excel.xlSht.Cells[counterRow, counterCol+1] = 345345;
                    excel.xlSht.Cells[counterRow, counterCol+2] = 234234;
                    counterRow++;
                    counterCol++;
                }
            }
        }
    }
}
