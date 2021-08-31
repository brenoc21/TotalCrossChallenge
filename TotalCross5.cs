using System;
using System.Linq;

public class Program
{
  
	public static string PokerHandRanking(string[] hand)
	{
    
		int biggest =0;
		int aux = 0;
		int mtxAux = 0;
		string result = "High Card";
		bool flush = false;
		int counter = 0;
		char[] type = new char[hand.Length];
		int[] power = new int[hand.Length];
		int[] ofAKind = new int[hand.Length];
		for(int i = 0; i < hand.Length; i++){
			type[i] = hand[i][hand[i].Length-1];
			hand[i] = hand[i].Substring(0, hand[i].Length-1);
		}
		for(int i = 0; i< hand.Length; i++){
			switch(hand[i]){
				case "A":
					power[i] = 14;
					break;
				case "K":
					power[i] = 13;
					break;
				case "Q":
					power[i] = 12;
					break;
				case "J":
					power[i] = 11;
					break;
					default:
					power[i] = int.Parse(hand[i]);
					break;
					
			}
      
			
		}
		power = SelectionSort(power, power.Length);
    for(int i = 0; i < power.Length; i++){
      
    }
    
			for(int i = 0; i < power.Length - 1; i++){
			
		if(power[i] == power[i+1]){
			counter++;
		}else{
			if(counter > 0){
			counter++;
			ofAKind[mtxAux] = counter;
			counter = 0;
			mtxAux++;
			}
		}
	}
		if(counter> 0){
			counter++;
			ofAKind[mtxAux] = counter;
			counter = 0;
			mtxAux++;
		}
		if(ofAKind[0]> 0 ){
			switch(ofAKind[0]){
				case 2:
					switch(ofAKind[1]){
						case 2:
							result = "Two Pair";
							break;
						case 3:
							result = "Full House";
							break;
						default:
							result = "Pair";
							break;
					}
					break;
					case 3:
					  switch(ofAKind[1]){
							case 2:
								result = "Full House";
								break;
							default:
								result = "Three of a Kind";
								break;
						}
						break;
					case 4:
					result = "Four of a Kind";
					break;
				}
		}else{
			if(type[0] == type[1] && type[0] == type[2]&& type[0] == type[3]&& type[0] == type[4]){
				flush = true;
				result = "Flush";
			}
			
			 if((power[0] == (power[1] - 1)) && (power[1] == (power[2] - 1)) && (power[2] == (power[3] - 1)) && (power[3] == (power[4] - 1)))
			 {
				 if(flush == true){
					 if(power[4] ==14){
					 result = "Royal Flush";
					 }else{
						 result = "Straight Flush";
					 }
				 }else{
           result = "Straight";
         }

				 
			 }
			
		}
		
		return result;
	}
  public static int[] SelectionSort (int[] arr, int size){
int i, j, min, x;
    for (i=0; i < size; i++){
        min = i;
	for (j=i+1; j < size; j++){
            if (arr[j] < arr[min]){
	        min = j;
          }
	}
	x = arr[min];
	arr[min] = arr[i];
	arr[i] = x;
    }
return arr;

}
}