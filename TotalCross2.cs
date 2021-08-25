// Its possible to solve using some or all of these librarys.

using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

public class Program 
{
			public static string Smallest(int n)
			{		
					int aux = 0;
				  int counter = 0;
					int[] numbers = new int[n];
				
					for(int i = n; i >= 2; i--){      
						aux = i;									      
						for(int j = 2; j<=i; j++){  			
							counter = 0;						      
							
							while(aux%j == 0){					
								aux = aux/j;				 
								counter++;					 
							}
							if(counter > numbers[j-1]){
								numbers[j-1] = counter;  
							}
							
								
						}
					}
					BigInteger result = 1;
					BigInteger aux2 = 0;
					for(int i = 0; i < numbers.Length; i++){
						aux2 = BigInteger.Pow(i+1, numbers[i]);
						if (aux2 > 0){
							result = result*aux2;
						}
						
					}
					return result.ToString();
			}
}