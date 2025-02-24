/*
* Name: Logan Brooks
* South Hills Username: lbrooks81
* Link(s) Used: https://www.csharp.com/article/how-to-sort-a-dictionary-with-c-sharp/
*/

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace GooglingExercisesPt1;

public class Source
{
    //Sort by value, not key
    public static Dictionary<String, Int32> Sort(Dictionary<String, Int32> dict)
    {
        return dict.ToList().OrderBy(x => x.Value).ToDictionary();
            
        //Return the dictionary, sorted by value, not key.
        //You must use LINQ to perform the sort and do it in one instruction.
    }
}
