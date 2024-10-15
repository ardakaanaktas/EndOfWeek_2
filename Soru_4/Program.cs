namespace Soru_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int randomNumber = random.Next();

            Console.WriteLine(randomNumber);
            Console.WriteLine(randomNumber % 3);
        }
    }
}
