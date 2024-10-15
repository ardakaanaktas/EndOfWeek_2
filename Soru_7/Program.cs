namespace Soru_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? str = Console.ReadLine();// Read the string

            string[] strPieces = str.Split(' ');// Split the string

            Array.Reverse(strPieces);// Reverse the array

            Console.WriteLine(string.Join(" ", strPieces));// Print the reversed string with spaces
        }
    }
}
