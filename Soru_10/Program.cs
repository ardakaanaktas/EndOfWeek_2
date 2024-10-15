namespace Soru_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Doğru veya yanlış belirtmek için \"true\" yada \"false\" yazınız.");

            bool.TryParse(Console.ReadLine(), out bool result);
            Console.WriteLine(checkBool(result));


        }

        static string checkBool(bool result)
        {
            if (result)
                return "Doğru";
            else
                return "Yanlış";
        }


    }
}
