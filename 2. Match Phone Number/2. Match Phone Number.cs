using System.Text.RegularExpressions;

namespace _2._Match_Phone_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            string pattern = @"\+359([\ \-])2\1\d{3}\1\d{4}\b";
            Regex regExpression= new Regex(pattern);

            MatchCollection matches = regExpression.Matches(input);

            Console.WriteLine(string.Join(", ", matches ));






        }
    }
}