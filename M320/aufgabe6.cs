namespace aufgabe6
{
    internal class Rectangle
    {
        int height = 5;
        int width = 5;

        public static int Area(int width, int height)
        {
            int area = width * height;
            return area;
        }

        public static int Diagonal(int width, int height)
        {
            int diagonal = width^2 * height^2;
            diagonal = (int)Math.Sqrt(diagonal);
            return diagonal;
        }

        public static int Volume(int width, int height)
        {
            int volume = width * height * width;
            return volume;
        }

        //mir fällt nichts weiters ein
    }
}
