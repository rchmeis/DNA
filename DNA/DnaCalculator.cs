using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace DNA
{
    internal class DnaCalculator
    {
        public int HammingDistance(string dna1, string dna2)
        {
            int diff = 0;
            int minLength = Math.Min(dna1.Length, dna2.Length);
            int lengthDiff = Math.Max(dna1.Length, dna2.Length) - minLength;

            for (int i = 0; i < minLength;i++)
            {
                if (dna1[i] != dna2[i])
                {
                    diff += 1;
                }
            }
            
            int hammingDistance = diff + lengthDiff;
            return hammingDistance;
        }
    }
}
