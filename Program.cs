

using System.IO;
using System.Text;

namespace MonopolyTestTask
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            CreatPallets creatPallets = new CreatPallets(Path.GetFullPath("Pallet.xlsx"));
            CreatBox creatBox = new CreatBox(Path.GetFullPath("Box.xlsx"));
            creatBox.addBoxIntoPallet(creatPallets.pallets);

            var printData = new PrintData();
            printData.PrintOneTask(creatPallets.pallets);
            printData.PrintTwoTask(creatPallets.pallets);


            //var pallets = new InputData().AddTestDate();gv
            //printData.PrintOneTask(pallets);
            //printData.PrintTwoTask(pallets);
        }
    }
}