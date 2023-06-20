using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MonopolyTestTask
{
    internal class Pallet : Box
    {
        readonly List<Box> BoxList;

        public Pallet(int palletHeight, int palletWidth, int palletDepth)
        {
            BoxList = new List<Box>();

            this.id = GetId();            
            this.width = palletWidth;
            this.depth = palletDepth;
            this.height = palletHeight;
            this.weight = GetPalletWeight();
            this.size = getSizeAllBoxAndPallet();
        }

        public DateTime PalletShelfLife()
        {
            DateTime minDateTime = DateTime.Now;
            foreach (Box box in BoxList)
            {
                if (box.dateShelfLife < minDateTime)
                {
                    minDateTime = box.dateShelfLife;
                }
            }
            return minDateTime;
        }
        public int getSizeAllBoxAndPallet()
        {
            int sizeAllBox = 0;
            foreach (Box box in BoxList)
            {
                sizeAllBox += box.GetSizeBox();
            }

            int palletSize = GetSizePallet();

            return sizeAllBox + palletSize;
        }
        public void addBox(Box box)
        {
            Exception? exception = null;

            if (CheckBox(ref exception,box))
            {
                BoxList.Add(box);
                this.weight = GetPalletWeight();
                this.dateShelfLife = PalletShelfLife();
                this.size = getSizeAllBoxAndPallet();
            } 
            else
            {
                Console.WriteLine("Не удалось добавить ящик в паллет.");
                Console.WriteLine(exception.Message);
            }
        }
        bool CheckBox(ref Exception typeException,Box box)
        {

            if (box.id <= 0)
            {
                typeException = new Exception("ID коробки не может быть отрицательным или равным нулю.");
                return false;
            }

            if (box.height <= 0)
            {
                typeException = new Exception("Высота коробки не может быть отрицательной или равной нулю.");
                return false;
            }

            if (box.width > 0)
            {
                if (box.width > this.width)
                {
                    typeException = new Exception("Ширина коробки не может быть больше ширины паллета.");
                    return false;
                }
            }
            else
            {
                typeException = new Exception("Ширина коробки не может быть отрицательной или равной нулю.");
                return false;
            }

            if (box.depth > 0)
            {
                if (box.depth > depth)
                {
                    typeException = new Exception("Длина коробки не может быть больше длины паллета.");
                    return false;
                }
            }
            else
            {
                typeException = new Exception("Глубина коробки не может быть отрицательной или равной нулю.");
                return false;
            }

            if (box.weight <= 0)
            {
                typeException = new Exception("Вес коробки не может быть отрицательным или равным нулю.");
                return false;
            }

            if (box.dateShelfLife ==  new DateTime())
            {
                if (box.dateOfProduction != new DateTime())
                {
                    box.dateShelfLife = box.dateOfProduction.AddDays(100);
                }
                else
                {
                    typeException = new Exception("Должна быть указана дата производства или срок годности коробки.");
                    return false;
                }
            }

            return true;
        }
        int GetSizePallet()
        {
            if (width > 0 && height > 0 && depth > 0)
                return width * height * depth;
            else throw new Exception("Не удалось посчитать объем паллета, ширина глубина и высота должны быть больше нуля.");
        }
        int GetPalletWeight()
        {
            int palletWeight = 30;
            foreach (var box in BoxList)
            {
                palletWeight += box.weight;
            }
            return palletWeight;
        }
        int GetId()
        {
            PalletIdIncrement.getInstance().palletId++;
            return PalletIdIncrement.getInstance().palletId;
        }
    }
}
