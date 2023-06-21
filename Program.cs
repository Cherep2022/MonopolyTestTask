

namespace MonopolyTestTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var pallets = new InputData().AddTestDate();

           var printData = new PrintData();
           printData.PrintOneTask(pallets);
           printData.PrintTwoTask(pallets);

        }
    }
}