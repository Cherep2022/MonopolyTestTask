

namespace MonopolyTestTask
{
    internal class PrintData
    {
        public void PrintOneTask(List<Pallet> pallets)
        {
            Console.WriteLine("Сгруппировать все паллеты по сроку годности, отсортировать по возрастанию срока годности, в каждой группе отсортировать паллеты по весу.");
            Console.WriteLine("------------------");

            var grouppedAndSorByDateShelfLife = pallets
                .OrderBy(pallet => pallet.dateShelfLife)
                .ThenBy(pallet => pallet.weight)
                .GroupBy(pallet => pallet.dateShelfLife)
                .ToList();

            int counterGroup = 1;
            int counterPallet = 1;
            foreach (var group in grouppedAndSorByDateShelfLife)
            {
                Console.WriteLine($"Группа № {counterGroup} срок годности до {group.ElementAt(0).dateShelfLife.ToString("dd.MM.yyyy")}");
                Console.WriteLine("------------------");

                foreach (var pallet in group)
                {
                    Console.WriteLine();
                    Console.WriteLine("Паллет №" + counterPallet);
                    Console.WriteLine("Вес: " + pallet.weight);
                    Console.WriteLine();

                    counterPallet++;
                }

                Console.WriteLine("------------------");

                counterPallet = 1;
                counterGroup++;
            }
        }
        public void PrintTwoTask(List<Pallet> pallets)
        {
            Console.WriteLine("3 паллеты, которые содержат коробки с наибольшим сроком годности, отсортированные по возрастанию объема.");
            Console.WriteLine("------------------");
            Console.WriteLine();

            var sortByDateShelfLifeDescending = pallets
                .OrderByDescending(pallet => pallet.dateShelfLife)
                .ToList();

            int counerBox = 1;
            int counterPallet = 1;
            for (int i = 0; i < 3; i++)
            {
                var pallet = sortByDateShelfLifeDescending.ElementAt(i).BoxList.OrderBy(box => box.size);
                DateTime dateTime = sortByDateShelfLifeDescending.ElementAt(i).dateShelfLife;

                Console.WriteLine($"Паллет № {counterPallet} срок годности до {dateTime.ToString("dd.MM.yyyy")}");
                Console.WriteLine("------------------");
                Console.WriteLine();

                foreach (var box in pallet)
                {
                    Console.WriteLine($"Коробка № {counerBox} объем {box.size}");
                    counerBox++;
                }

                Console.WriteLine();
                Console.WriteLine("------------------");

                counterPallet++;
            }
        }
    }
}
