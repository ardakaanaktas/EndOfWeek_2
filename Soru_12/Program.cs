namespace Soru_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rakam girdikten sonra enter tuşuna basınız. En son çıkmak ve En büyük sayıyı yazdırmak için rakam dışında bir girdi girmeniz yeterli.");
            Console.WriteLine("En büyük sayı : "+ findBiggestNumber());

        }


        static int findBiggestNumber()
        {
            int biggestNumber = 0;

            while (int.TryParse(Console.ReadLine(), out int number))
            {
                if (number > biggestNumber)
                {
                    biggestNumber = number;
                }
            }

            return biggestNumber;
        }
    }
}