/*
* Name: [YOUR NAME HERE]
* South Hills Username: [YOUR SOUTH HILLS USERNAME HERE]
* Link(s) Used: [INSERT LINK(S) HERE]
*/

using System;
using System.Collections.Generic;

namespace GooglingExercisesPt2;

public class Source
{
    public static void RemoveNumbers(List<Int32> list, int numberToRemove)
    {
        foreach(int num in list)
        {
            if(num == numberToRemove)
            {
                list.Remove(num);
            }
        }
    }
}
