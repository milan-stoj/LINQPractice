using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Problem 1: Select words from list containing "th". */
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            List<string> thWords = WordsTh(words);

            /* Problem 2: Remove duplicate words from a list. */
            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Zack", "Mike" };
            List<string> distinctNames = RemoveDuplicates(names);

            /* Problem 3: Average list of grades after dropping lowest grade from each entry. */
            List<string> classGrades = new List<string>()
                {
                "80,100,92,89,65",
                "93,81,78,84,69",
                "73,88,83,99,64",
                "98,100,66,74,55"   
                };
            double classAverage = AverageDroppedLowest(classGrades); // == 86.125;

            /* Problem 4: Return an alphabetically ordered string corresponding to the letter frequency of the passed string. */
            string test = "Terrill";
            string frequency = AnalyzeFrequency(test);
        }

        static List<string> WordsTh(List<string> wordsToCheck)
        {
            return wordsToCheck.FindAll(w => w.Contains("th"));
        }

        static List<string> RemoveDuplicates(List<string> wordsToDistinct)
        {
            return wordsToDistinct.Distinct().ToList();
        }

        static double AverageDroppedLowest(List<string> gradesToAverage)
        {
            var splitGrades = gradesToAverage.Select(s => s.Split(','));
            var convertedGrades = splitGrades.Select(s => s.ToList()).Select(s => s.Select(int.Parse));
            var orderedGrades = convertedGrades.Select(s => s.OrderBy(n => n).ToList()).ToList();
            orderedGrades.ForEach(s => s.RemoveAt(0));
            return orderedGrades.Select(s => s.Average()).ToList().Average();
        }

        static string AnalyzeFrequency(string wordsToCheck)
        {
            var wordInList = wordsToCheck.ToUpper().ToList();
            var distinctList = wordInList.Distinct();
            var orderedList = distinctList.OrderBy(c => c).ToList();
            string frequency = default;
            foreach (char distinct in orderedList)
            {
                int count = wordInList.Count(c => c == orderedList[orderedList.IndexOf(distinct)]);
                frequency += $"{orderedList[orderedList.IndexOf(distinct)]}{count}";
            }
            return frequency;
        }
    }
}
