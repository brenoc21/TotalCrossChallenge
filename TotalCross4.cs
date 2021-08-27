using System;
using System.Collections.Generic;

public class Program
{
    public static int SimPropFrac(int maxDen)
    {
			List<double> fractions = new List<double>();
			int counter = 0;
			int k = 1;
			while(k <= maxDen){
				for(int i = 1; i < k; i++){
					fractions.Add(i/k);
				}
				k++;
			}
			for(int i = 0; i < fractions.Count; i++){
				for(int j = 0; j < i; j++){
					if(fractions[i] == fractions[j]){
						break;
					}else{
						counter++;
					}
					
				}
				
			}
				return counter;
    }
}