
namespace MonopolyTestTask
{
    internal class Pallet : Box
    {
        public readonly List<Box> BoxList;

        public Pallet(int id, int height, int width, int depth) : base()
        {
            BoxList = new List<Box>();

            this.id = id;            
            this.width = width;
            this.depth = depth;
            this.height = height;
            this.weight = GetWeightAllBoxAndPallet();
            this.size = getSizeAllBoxAndPallet();
            this.dateOfProduction = DateTime.Now;
        }

        public void AddBox(Box box)
        {
            if (CheckBox(box))
            {
                BoxList.Add(box);
                this.weight = GetWeightAllBoxAndPallet();
                this.dateShelfLife = PalletShelfLife();
                this.size = getSizeAllBoxAndPallet();
            }
            else
            {
                Console.WriteLine("Не удалось добавить коробку в паллет.");
            }
        }
        DateTime PalletShelfLife()
        {
            DateTime minDateTime = BoxList.ElementAt(0).dateShelfLife;
            foreach (Box box in BoxList)
            {
                if (box.dateShelfLife < minDateTime)
                {
                    minDateTime = box.dateShelfLife;
                }
            }

            return minDateTime;
        }
        int GetSizePallet()
        {
            if (this.width > 0 && this.height > 0 && this.depth > 0)
                return this.width * this.height * this.depth;
            else throw new Exception("Не удалось посчитать объем паллета, ширина глубина и высота должны быть больше нуля.");
        }
        int getSizeAllBoxAndPallet()
        {
            int sizeAllBox = 0;
            foreach (Box box in BoxList)
            {
                sizeAllBox += box.size;
            }

            int palletSize = GetSizePallet();

            return sizeAllBox + palletSize;
        }      
        bool CheckBox(Box box)
        {

            if (box.id <= 0)
            {
                Console.WriteLine("ID коробки не может быть отрицательным или равным нулю.");
                return false;
            }

            if (box.height <= 0)
            {
                Console.WriteLine("Высота коробки не может быть отрицательной или равной нулю.");
                return false;
            }


            if (box.width <= 0)
            {
                Console.WriteLine("Ширина коробки не может быть отрицательной или равной нулю.");
                return false;
            }
            else
            {
                if (box.width > this.width)
                {
                    Console.WriteLine("Ширина коробки не может быть больше ширины паллета.");
                    return false;
                }
            }

            if (box.depth <= 0)
            {
                Console.WriteLine("Длина коробки не может быть отрицательной или равной нулю.");
                return false;
            }
            else
            {
                if (box.depth > this.depth)
                {
                    Console.WriteLine("Длина коробки не может быть больше длины паллета.");
                    return false;
                }
            }

            if (box.weight <= 0)
            {
                Console.WriteLine("Вес коробки не может быть отрицательным или равным нулю.");
                return false;
            }

            DateTime minDate = new DateTime();
            if (box.dateShelfLife == minDate)
            {
                if (box.dateOfProduction != minDate)
                {
                    box.dateShelfLife = box.dateOfProduction.AddDays(100);
                }
                else
                {
                    Console.WriteLine("Должна быть указана дата производства или срок годности коробки.");
                    return false;
                }
            }

            return true;
        }        
        int GetWeightAllBoxAndPallet()
        {
            int palletWeight = 30;
            foreach (var box in BoxList)
            {
                palletWeight += box.weight;
            }

            return palletWeight;
        }
    }
}
