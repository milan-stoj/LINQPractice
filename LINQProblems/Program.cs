using System;
using System.Collections.Generic;
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
            int classAverage = AverageDroppedLowest(classGrades);

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
            throw new NotImplementedException();
        }

        static int AverageDroppedLowest(List<string> gradesToAverage)
        {
            throw new NotImplementedException();
        }

        static string AnalyzeFrequency(string wordsToCheck)
        {
            throw new NotImplementedException();
        }

    }
}
