namespace MonopolyTestTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Box box = new Box() {height = 100, depth = 100, weight = 100, width = 100, dateOfProduction = DateTime.Now };

            var Pallet = new Pallet(500,500,500);
            Pallet.addBox(box);

            Box box2 = new Box() { height = 100, depth = 100, weight = 100, width = 100, dateOfProduction = DateTime.Now };

            var Pallet2 = new Pallet(500, 500, 500);
            Pallet2.addBox(box2);

            Box box3 = new Box() { height = 100, depth = 100, weight = 100, width = 100, dateOfProduction = DateTime.Now };

            var Pallet3 = new Pallet(500, 500, 500);
            Pallet3.addBox(box3);

            Box box4 = new Box() { height = 100, depth = 100, weight = 100, width = 100, dateOfProduction = DateTime.Now };

            var Pallet4 = new Pallet(500, 500, 500);
            Pallet4.addBox(box4);


        }
    }
}