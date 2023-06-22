
namespace MonopolyTestTask
{
    internal class InputData
    {
        public List<Pallet> AddTestDate()
        {
            List<Pallet> pallets = new List<Pallet>();
            
            Random random = new Random();

            var Pallet = new Pallet(1, random.Next(100,300), random.Next(100,300), random.Next(100, 300));
            Box box = new Box(13, random.Next(50,100), random.Next(50, 100), random.Next(50,100)) { weight = random.Next(50,100), dateOfProduction = DateTime.Now.AddDays(-30).Date };
            Box box2 = new Box(14, random.Next(50 , 100), random.Next(50 , 100), random.Next(50 , 100)) { weight = random.Next(50 , 100), dateOfProduction = DateTime.Now.AddDays(-20).Date };
            Box box3 = new Box(15, random.Next(50 , 100), random.Next(50 , 100), random.Next(50 , 100)) { weight = random.Next(50 , 100), dateOfProduction = DateTime.Now.AddDays(-10).Date };
            Box box4 = new Box(16, random.Next(50 , 100), random.Next(50 , 100), random.Next(50 , 100)) { weight = random.Next(50 , 100), dateOfProduction = DateTime.Now.AddDays(-90).Date };

            Pallet.AddBox(box);
            Pallet.AddBox(box2);
            Pallet.AddBox(box3);
            Pallet.AddBox(box4);

            var Pallet2 = new Pallet(2, random.Next(500 , 1000), random.Next(500 , 1000), random.Next(500 , 1000));
            Box box5 = new Box(1, random.Next(50 , 100), random.Next(50 , 100), random.Next(50 , 100)) { weight = random.Next(50 , 100), dateOfProduction = DateTime.Now.AddDays(-90).Date };
            Box box6 = new Box(2, random.Next(50 , 100), random.Next(50 , 100), random.Next(50 , 100)) { weight = random.Next(50 , 100), dateOfProduction = DateTime.Now.AddDays(-15).Date };
            Box box7 = new Box(3, random.Next(50 , 100), random.Next(50 , 100), random.Next(50 , 100)) { weight = random.Next(50 , 100), dateOfProduction = DateTime.Now.AddDays(-66).Date };
            Box box8 = new Box(4, random.Next(50 , 100), random.Next(50 , 100), random.Next(50 , 100)) { weight = random.Next(50 , 100), dateOfProduction = DateTime.Now.AddDays(-53).Date };

            Pallet2.AddBox(box5);
            Pallet2.AddBox(box6);
            Pallet2.AddBox(box7);
            Pallet2.AddBox(box8);

            var Pallet3 = new Pallet(3, random.Next(500 , 1000), random.Next(500 , 1000), random.Next(500 , 1000));
            Box box9 = new Box(5, random.Next(50 , 100), random.Next(50 , 100), random.Next(50 , 100)) { weight = random.Next(50 , 100), dateOfProduction = DateTime.Now.AddDays(-77).Date };
            Box box10 = new Box(6, random.Next(50 , 100), random.Next(50 , 100), random.Next(50 , 100)) { weight = random.Next(50 , 100), dateOfProduction = DateTime.Now.AddDays(-44).Date };
            Box box11 = new Box(7, random.Next(50 , 100), random.Next(50 , 100), random.Next(50 , 100)) { weight = random.Next(50 , 100), dateOfProduction = DateTime.Now.AddDays(-89).Date };
            Box box12 = new Box (8, random.Next(50 , 100), random.Next(50 , 100), random.Next(50 , 100)) { weight = random.Next(50 , 100), dateOfProduction = DateTime.Now.AddDays(-69).Date };

            Pallet3.AddBox(box9);
            Pallet3.AddBox(box10);
            Pallet3.AddBox(box11);
            Pallet3.AddBox(box12);

            var Pallet4 = new Pallet(4, random.Next(500 , 1000), random.Next(500 , 1000), random.Next(500 , 1000));
            Box box13 = new Box(9, random.Next(50 , 100), random.Next(50 , 100), random.Next(50 , 100)) { weight = random.Next(50 , 100), dateOfProduction = DateTime.Now.AddDays(-23).Date };
            Box box14 = new Box(10, random.Next(50 , 100), random.Next(50 , 100), random.Next(50 , 100)) { weight = random.Next(50 , 100), dateOfProduction = DateTime.Now.AddDays(-61).Date };
            Box box15 = new Box(11, random.Next(50 , 100), random.Next(50 , 100), random.Next(50 , 100)) { weight = random.Next(50 , 100), dateOfProduction = DateTime.Now.AddDays(-31).Date };
            Box box16 = new Box(12, random.Next(50 , 100), random.Next(50 , 100), random.Next(50 , 100)) { weight = random.Next(50 , 100), dateOfProduction = DateTime.Now.AddDays(-44).Date };

            Pallet4.AddBox(box13);
            Pallet4.AddBox(box14);
            Pallet4.AddBox(box15);
            Pallet4.AddBox(box16);

            pallets.Add(Pallet);
            pallets.Add(Pallet2);
            pallets.Add(Pallet3);
            pallets.Add(Pallet4);

            return pallets;
        }
    }
}
