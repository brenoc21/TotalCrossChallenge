using System;
public class Program
{
    public static string ExpressFactors(int n) 
  {       
          string result = "";
          int aux = 0;
          int counter = 0;
          int[] numbers = new int[n];
          bool firstNumber = true;
        
                
            aux = n;                        
            for(int i = 2; i<=n; i++){        
              counter = 0;                  
              
              while(aux%i == 0){          
                aux = aux/i;         
                counter++;           
              }
              if(counter > numbers[i-1]){
                numbers[i-1] = counter;  
              }
              
                
            }
            for(int i = 0; i < n; i++){
              
              switch(numbers[i]){
                case 0:
                  
                  break;
                case 1:
                  if(firstNumber == false){
                  result += " x " + (i+1);
                  }else{
                    result += (i+1);
                    firstNumber = false;
                  }
                  break;
                default:
                  if(firstNumber == false){
                    result += " x " + (i+1) + "^" + numbers[i];
                  }else{
                    result += (i+1) + "^" + numbers[i];
                    firstNumber = false;
                  }
                  
                  break;
              }
            }
      return result;
          
  }
}