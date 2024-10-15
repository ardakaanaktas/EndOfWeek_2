namespace Soru_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(sum(45,67));
        }

        static int sum (in int a, in int b) => a + b;
    }
}
