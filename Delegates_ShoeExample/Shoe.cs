namespace Delegates_ShoeExample
{
    public class Shoe
    {
        public string Color { get; set; }
        public int Size { get; set; }
        public string Brand { get; set; }

        public Shoe(string color, int size, string brand)
        {
            Color = color;
            Size = size;
            Brand = brand;
        }
    }

}