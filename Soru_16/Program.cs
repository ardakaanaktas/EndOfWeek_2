namespace Soru_16
{
    internal class Program
    {
        const double pi = 3.14159;//pi sayısı

        static void Main(string[] args)
        {
            Console.Write("Yarıçap Giriniz: ");
            double.TryParse(Console.ReadLine(), out double radius);
            Console.WriteLine($"Dairenin Alanı: {CircleArea(radius)}");
        }

        static double CircleArea(double radius) => pi * radius * radius;

    }
}
