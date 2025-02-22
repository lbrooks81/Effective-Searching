using System;
using System.Collections.Generic;
using System.Linq;

namespace GooglingExercisesPt1
{
    class Program
    {
        static void Main()
        {
            Dictionary<String, Int32> generatedDictionary = [];

            for(int i = 0; i < 10; i++)
            {
                generatedDictionary.Add(i.ToString(), Random.Shared.Next(1, 101));
            }

            generatedDictionary = Source.Sort(generatedDictionary);

            bool correct = true;

            for(int i = 1; i < generatedDictionary.Count; i++)
            {
                if (generatedDictionary.ElementAt(i - 1).Value > generatedDictionary.ElementAt(i).Value)
                {
                    correct = false;
                    break;
                }
            }

            Console.WriteLine(correct ? "Correct!" : "Incorrect - Not sorted.");
        }
    }
}