﻿/*
* Name: [YOUR NAME HERE]
* South Hills Username: [YOUR SOUTH HILLS USERNAME HERE]
* Link(s) Used: None :)
*/

using System;
using System.Collections.Generic;

namespace GooglingExercisesPt2;

public class Source
{
    public static void RemoveNumbers(List<Int32> list, int numberToRemove)
    {
        List<Int32> newNumbers = new List<Int32>();

        foreach(int num in list)
        {
            if(num == numberToRemove)
            {
                continue;
            }
            newNumbers.Add(num);
        }
        
        list.Clear();
        list = newNumbers;
    }
}
