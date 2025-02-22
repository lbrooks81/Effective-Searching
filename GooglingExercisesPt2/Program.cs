using System;
using System.Collections.Generic;
using System.Linq;

namespace GooglingExercisesPt2
{
    class Program
    {
        public static void Main()
        {
            List<Int32> list = new List<Int32>(Enumerable.Range(0, 15).Select(x => x = Random.Shared.Next(1, 10)));
            int numToRemove = Random.Shared.Next(1, 10);
            list.Insert(Random.Shared.Next(0, list.Count), numToRemove);
            Source.RemoveNumbers(list, numToRemove);

            bool numExists = list.Where(x => x == numToRemove).Count() > 1;

            Console.WriteLine(numExists == false ? "Correct!" : "Incorrect - " + numToRemove + " still exists in the list.");
        }
    }
}