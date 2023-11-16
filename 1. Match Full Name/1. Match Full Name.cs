using System.Text.RegularExpressions;

namespace _1._Match_Full_Name
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string pattern = @"\b[A-Z][a-z]+\b [A-Z][a-z]+\b";
            Regex regex = new Regex(pattern);

            string input = Console.ReadLine();

            MatchCollection matches = regex.Matches(input);
            Console.WriteLine(string.Join(" ", matches));

           


        }
    }
}