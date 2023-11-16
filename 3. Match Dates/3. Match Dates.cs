using Microsoft.VisualBasic;
using System.Text.RegularExpressions;

namespace _3._Match_Dates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(?<day>\d{2})(?<separator>[\.\-\/])(?<month>[A-z][a-z]{2})\k<separator>(?<year>\d{4})\b";
            Regex regex = new Regex(pattern);

            string input = Console.ReadLine();

            MatchCollection matches = regex.Matches(input);
            
            foreach (Match match in matches) 
            {
                Console.WriteLine($"Day: {match.Groups[1]}, Month: {match.Groups[3]}, Year: {match.Groups[4]}");

            }



        // INPUT FROM CONSOLE: 03-Mar-1878, 25/Apr/1915, 31-May-1916, 22/Jun-1941, 25.Dec.1937, 23/09/1973
        // OUTPUT:
        //Day: 03, Month: Mar, Year: 1878
        //Day: 25, Month: Apr, Year: 1915
        //Day: 31, Month: May, Year: 1916
        //Day: 25, Month: Dec, Year: 1937

        }
    }
}