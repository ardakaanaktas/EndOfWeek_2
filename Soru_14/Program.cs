namespace Soru_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sayı Giriniz : ");
            int.TryParse(Console.ReadLine(), out int number);
            Console.WriteLine(evenOrOdd(number));
        }

        static bool evenOrOdd(int number)
        {
            if (number % 2 == 0)
                return true;
            else
                return false;
        }
    }
}
