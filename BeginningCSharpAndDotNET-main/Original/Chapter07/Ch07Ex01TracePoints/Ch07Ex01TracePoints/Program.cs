﻿using System;
using System.Diagnostics;

namespace Ch07Ex01TracePoints
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArray = { 4, 7, 4, 2, 7, 3, 7, 8, 3, 9, 1, 9 };
            int maxVal = Maxima(testArray, out int[] maxValIndices);
            Console.WriteLine($"Maximum value {maxVal} found at element indices:");
            foreach (int index in maxValIndices)
            {
                Console.WriteLine(index);
            }
            Console.ReadKey();
        }
        static int Maxima(int[] integers, out int[] indices)
        {
            indices = new int[1];
            int maxVal = integers[0];
            indices[0] = 0;
            int count = 1;
            for (int i = 1; i < integers.Length; i++)
            {
                if (integers[i] > maxVal)
                {
                    maxVal = integers[i];
                    count = 1;
                    indices = new int[1];
                    indices[0] = i;
                }
                else
                {
                    if (integers[i] == maxVal)
                    {
                        count++;
                        int[] oldIndices = indices;
                        indices = new int[count];
                        oldIndices.CopyTo(indices, 0);
                        indices[count - 1] = i;
                    }
                }
            }
            Trace.WriteLine(string.Format(
               $"Maximum value {maxVal} found, with {count} occurrences."));
            return maxVal;
        }
    }
}
