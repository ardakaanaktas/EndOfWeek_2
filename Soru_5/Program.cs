namespace Soru_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yaşınız Kaç ?");

            int.TryParse(Console.ReadLine(), out int age);

            Console.WriteLine((age > 18) ? "+":"-");
        }
    }
}
