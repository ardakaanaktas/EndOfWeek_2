namespace Soru_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yerleri değiştirilecek iki isimi aralarında boşluk olacak şekilde giriniz : ");

            string[] names = Console.ReadLine().Split(' ');// Read the string and split it

            names = changeName(names);// Reverse the array

            string result = string.Join(" ", names);// Join the array with spaces

            Console.WriteLine(result);// Print the reversed string with spaces
        }

        static string[] changeName(string[] names)
        {
            Array.Reverse(names);// Reverse the array
            return names;// Return the reversed array
        }
    }
}
