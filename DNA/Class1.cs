using System;
using System.Collections.Generic;
using System.Text;

namespace DNA
{
    internal class Dna
    {
        
        public int CompareDna(string dna1, string dna2)
        {
            int diffCount = 0;                                   //declare a variable outside of the loop to contain the differences for each iteration
            int minLength = Math.Min(dna1.Length, dna2.Length);  //returns the smaller of the two integers
            for(int i=0; i<minLength;i++)
            {
                if(dna1[i]!= dna2[i])
                {
                    diffCount++;
                }
            }
            diffCount += Math.Abs(dna1.Length - dna2.Length);   //Math.Abs returns the absolute value. 
            return diffCount;
        }

        
    }
}
