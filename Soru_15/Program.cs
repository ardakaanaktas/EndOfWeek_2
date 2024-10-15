namespace Soru_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kaç saattir yol gidiyorsunuz ?");
            int.TryParse(Console.ReadLine(), out int time);

            Console.WriteLine("Ortalama olarak hızınız kaç ?");
            int.TryParse(Console.ReadLine(), out int speed);

            Console.WriteLine(roadLength(speed:speed,time:time));
        }

        static int roadLength(int speed, int time) => speed * time;
    }
}
