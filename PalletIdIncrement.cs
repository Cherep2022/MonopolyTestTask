using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyTestTask
{
    internal class PalletIdIncrement
    {
        private static PalletIdIncrement ?instance;
        public int palletId = 0;

        private PalletIdIncrement()
        { }

        public static PalletIdIncrement getInstance()
        {
            if (instance == null)
                instance = new PalletIdIncrement();
            return instance;
        }
    }
}
