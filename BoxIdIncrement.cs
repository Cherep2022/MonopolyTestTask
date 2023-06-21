

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
