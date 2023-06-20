using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyTestTask
{
    internal class BoxIdIncrement
    {
        private static BoxIdIncrement ?instance;
        public int boxId = 0;

        private BoxIdIncrement()
        { }

        public static BoxIdIncrement getInstance()
        {
            if (instance == null)
                instance = new BoxIdIncrement();
            return instance;
        }
    }
}
