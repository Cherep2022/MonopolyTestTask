

using System.IO;
using System.Text;

namespace MonopolyTestTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Чтение входных данных из файла");
            Console.WriteLine( );
            Console.ResetColor();

            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            CreatPallets creatPallets = new CreatPallets(Path.GetFullPath("Pallet.xlsx"));
            CreatBox creatBox = new CreatBox(Path.GetFullPath("Box.xlsx"));
            creatBox.addBoxIntoPallet(creatPallets.pallets);

            var printData = new PrintData();
            printData.PrintOneTask(creatPallets.pallets);
            printData.PrintTwoTask(creatPallets.pallets);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Генерация входных данных");
            Console.WriteLine();
            Console.ResetColor();

            var pallets = new InputData().AddTestDate();
            printData.PrintOneTask(pallets);
            printData.PrintTwoTask(pallets);
        }
    }
}