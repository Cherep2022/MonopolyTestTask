using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyTestTask.ExcelReaderWriter
{
    internal class ReaderExcelFileIntoArray
    {
        string[,] mytable = null;
        int raw = 0;
        int col = 0;

        public string[,] ExcelToMassiv(string PathTofile)
        {
            try
            {
                using (var stream = File.Open(PathTofile, FileMode.Open, FileAccess.Read))
                {
                    using (var reader = ExcelReaderFactory.CreateReader(stream))
                    {
                        while (reader.NextResult()) ;
                        return GetTables(reader.AsDataSet().Tables);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Не удалось открыть excel файл. " + ex.Message);
            }

        }

        string[,] GetTables(DataTableCollection dataSet)
        {
            foreach (DataTable tables in dataSet)
            {
                mytable = new string[tables.Rows.Count, tables.Columns.Count];
                foreach (DataRow row in tables.Rows)
                {
                    foreach (DataColumn column in tables.Columns)
                    {
                        if (row[column] != null)
                            mytable.SetValue(row[column].ToString(), raw, col);
                        col++;
                    }
                    col = 0;
                    raw++;
                }
            }
            return mytable;
        }
    }
}
