using MonopolyTestTask.ExcelReaderWriter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyTestTask
{
    internal class CreatBox
    {
        public readonly List<Box> box;
        readonly string pathToBoxExcelFIle;
        public CreatBox(string pathToBoxExcelFIle)
        {
            this.pathToBoxExcelFIle = pathToBoxExcelFIle;
            box = new List<Box>();
        }

        string[,] ReadBoxFile(string path)
        {
            var ReaderExcel = new ReaderExcelFileIntoArray();
            return ReaderExcel.ExcelToMassiv(path);
        }
        public void addBoxIntoPallet(List<Pallet> pallets)
        {
            var boxArray = ReadBoxFile(pathToBoxExcelFIle);
            for (int i = 1; i < boxArray.Length / boxArray.GetLength(1); i++)
            {
                int palletId = Convert.ToInt32(boxArray[i, 0]);
                int boxId = Convert.ToInt32(boxArray[i, 1]);
                int boxHeight = Convert.ToInt32(boxArray[i, 2]);
                int boxWidth = Convert.ToInt32(boxArray[i, 3]);
                int boxDepth = Convert.ToInt32(boxArray[i, 4]);
                int boxWeight = Convert.ToInt32(boxArray[i, 5]);
                DateTime boxDateofProduction = new DateTime();
                if (!string.IsNullOrEmpty(boxArray[i, 6]))
                {
                    boxDateofProduction = Convert.ToDateTime(boxArray[i, 6]);
                }
                DateTime boxdateShelfLife = new DateTime();
                if (!string.IsNullOrEmpty(boxArray[i, 7]))
                {
                    boxdateShelfLife = Convert.ToDateTime((boxArray[i, 7]));
                }

                Box box = new Box(boxId, boxHeight, boxWidth, boxDepth) { weight = boxWeight, dateOfProduction = boxDateofProduction, dateShelfLife = boxdateShelfLife };

                foreach (var item in pallets)
                {
                    if (palletId == item.id)
                    {
                        item.AddBox(box);
                    }
                }
            }

        }

    }
}
