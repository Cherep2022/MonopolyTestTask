
namespace MonopolyTestTask
{
    internal class InputData
    {
        public List<Pallet> AddTestDate()
        {
            List<Pallet> pallets = new List<Pallet>();

            var Pallet = new Pallet(1,100, 500, 500);
            Box box = new Box(13,20,100,60) { weight = 352, dateOfProduction = DateTime.Now.AddDays(-30).Date };
            Box box2 = new Box(14,30,200,70) { weight = 675, dateOfProduction = DateTime.Now.AddDays(-20).Date };
            Box box3 = new Box(15,40,300,80) { weight = 456, dateOfProduction = DateTime.Now.AddDays(-10).Date };
            Box box4 = new Box(16,6,8,3) { weight = 12223, dateOfProduction = DateTime.Now.AddDays(-90).Date };

            Pallet.AddBox(box);
            Pallet.AddBox(box2);
            Pallet.AddBox(box3);
            Pallet.AddBox(box4);

            var Pallet2 = new Pallet(2,100, 700, 300);
            Box box5 = new Box(1,90,130,20) { weight = 97, dateOfProduction = DateTime.Now.AddDays(-90).Date };
            Box box6 = new Box(2,30,240,50) { weight = 78, dateOfProduction = DateTime.Now.AddDays(-15).Date };
            Box box7 = new Box(3,50,380,30) { weight = 2345, dateOfProduction = DateTime.Now.AddDays(-66).Date };
            Box box8 = new Box(4,10,45,10) { weight = 11, dateOfProduction = DateTime.Now.AddDays(-53).Date };

            Pallet2.AddBox(box5);
            Pallet2.AddBox(box6);
            Pallet2.AddBox(box7);
            Pallet2.AddBox(box8);

            var Pallet3 = new Pallet(3,100, 777, 666);
            Box box9 = new Box(5, 97,110,24) { weight = 768, dateOfProduction = DateTime.Now.AddDays(-77).Date };
            Box box10 = new Box(6, 32,270,55) { weight = 567, dateOfProduction = DateTime.Now.AddDays(-44).Date };
            Box box11 = new Box(7,  4,45,11) { weight = 345, dateOfProduction = DateTime.Now.AddDays(-89).Date };
            Box box12 = new Box(8, 82,410,18) { weight = 1231, dateOfProduction = DateTime.Now.AddDays(-69).Date };

            Pallet3.AddBox(box9);
            Pallet3.AddBox(box10);
            Pallet3.AddBox(box11);
            Pallet3.AddBox(box12);

            var Pallet4 = new Pallet(4,100, 363, 752);
            Box box13 = new Box(9,23,50, 24) { weight = 5678, dateOfProduction = DateTime.Now.AddDays(-23).Date };
            Box box14 = new Box(10,53,312,55) { weight = 6456, dateOfProduction = DateTime.Now.AddDays(-61).Date };
            Box box15 = new Box(11,33,123,36) { weight = 345, dateOfProduction = DateTime.Now.AddDays(-31).Date };
            Box box16 = new Box(12,1,2,3) { weight = 44444, dateOfProduction = DateTime.Now.AddDays(-44).Date };

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
