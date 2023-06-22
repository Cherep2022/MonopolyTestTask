using MonopolyTestTask.ExcelReaderWriter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyTestTask
{
    internal class CreatPallets
    {
        public readonly List<Pallet> pallets;
        readonly string pathToPalletsExcelFIle;
        public CreatPallets(string pathToPalletsExcelFIle)
        {
            this.pathToPalletsExcelFIle = pathToPalletsExcelFIle;
            pallets = new List<Pallet>();
            CreatClass();
        }
        string[,] ReadPalletsFile(string path)
        {
            var ReaderExcel = new ReaderExcelFileIntoArray();
            return ReaderExcel.ExcelToMassiv(path);
        }

        public void CreatClass()
        {
            var palletArray = ReadPalletsFile(pathToPalletsExcelFIle);
            for (int i = 1; i < palletArray.Length / palletArray.GetLength(1); i++)
            {
                int palletId = Convert.ToInt32(palletArray[i, 0]);
                int palletHeight = Convert.ToInt32(palletArray[i, 1]);
                int palletWidth = Convert.ToInt32(palletArray[i, 2]);
                int palletDepth = Convert.ToInt32(palletArray[i, 3]);

                var pallet = new Pallet(palletId, palletHeight,palletWidth,palletDepth);
                pallets.Add(pallet);
            }
        }
    }
}
