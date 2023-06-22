
namespace MonopolyTestTask
{
    public class Box
    {
        public int id { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int depth { get; set; }
        public int weight { get; set; }
        public int size { get; set; }
        public DateTime dateShelfLife { get; set; }
        public DateTime dateOfProduction { get; set; }

        protected Box()
        {
            
        }
        public Box(int id,int height, int width, int depth)
        {
            this.height = height;
            this.width = width;
            this.depth = depth;

            this.id = id;
            size = GetSizeBox();
        }
        int GetSizeBox()
        {
            if (width > 0 && height > 0 && depth > 0)
                return width * height * depth;
            else throw new Exception("Не удалось посчитать объем коробки, ширина глубина и высота должны быть больше нуля.");
        }
    }
}