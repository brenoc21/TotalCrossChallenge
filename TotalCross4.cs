using System;
using System.Collections.Generic;
class Program
{
    public static int SimPropFrac(int maxDen)
    {
        List<double> fractions = new List<double>();
        int counter = 1;
        int k = 1;
        while (k <= maxDen)
        {
            for (int i = 1; i < k; i++)
            {
                fractions.Add((float)i / k);
            }
            k++;
        }
        for (int i = 0; i < fractions.Count; i++)
        {

            for (int j = 0; j < i; j++)
            {

                if (fractions[i] == fractions[j])
                {
                    break;
                }
                else
                {
                    if (j == i - 1)
                    {
                        counter++;
                    }

                }

            }

        }
        return counter;
    }
}
