using Microsoft.Office.Core;
using Excel = Microsoft.Office.Core;

namespace MonopolyTestTask.ExcelReaderWriter
{
    internal class ExcelWriter : IDisposable
    {
        public Worksheet xlSht { get; }
        Application xlApp = null;
        Workbooks workBooks = null;
        Workbook xlWb = null;
        Sheets sheets = null;

        public ExcelWriter(string pathToExcel)
        {
            xlApp = new Excel.Application();
            workBooks = xlApp.Workbooks;
            xlWb = workBooks.Open(pathToExcel);
            sheets = xlWb.Worksheets;
            xlSht = (Worksheet)sheets[1];
        }

        public void Dispose()
        {
            xlWb.Close(true);
            xlApp.Application.Quit();
            xlApp.Quit();

            sheets = null;
            xlWb = null;
            workBooks = null;
            xlApp = null;

            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
