namespace Soru_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1.Kişinin yaşını giriniz : ");
            int.TryParse(Console.ReadLine(), out int firstPersonAge);

            Console.Write("2.Kişinin yaşını giriniz : ");
            int.TryParse(Console.ReadLine(), out int secondPerson);

            Console.Write("3.Kişinin yaşını giriniz : ");
            int.TryParse(Console.ReadLine(), out int thirtPerson);

            

            Console.WriteLine("En yaşlı kişi : " + oldestPerson(firstPersonAge,secondPerson,thirtPerson));
        }

        static int oldestPerson(int firstPersonAge, int secondPerson, int thirtPerson)
        {
            if (firstPersonAge > secondPerson)
            {
                if (firstPersonAge > thirtPerson)
                {
                    return firstPersonAge;
                }
                else
                    return thirtPerson;

            }
            else
            {
                if (secondPerson > thirtPerson)
                {
                    return secondPerson;
                }
                else
                    return thirtPerson;
            }
        }
    }
}
