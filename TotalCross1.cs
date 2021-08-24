 using System;

 public class Program
 {
     public static int ParseRomanNumeral(string num)
     {
       int result = 0;
			 char[] charArr = num.ToCharArray(); //Turns the String num into a char Array
			 for(int i = 0; i < charArr.Length; i++){ 
				 switch(charArr[i]){
					case 'I':
						 result += 1;
						 break;
					 case 'V':
						 if(i > 0){ //preventing the index from being out of bounds.
						 if(charArr[i-1] == 'I'){ 
							 result += 3; 
						 }else{
							 result += 5;
						 }
						 }else{
							 result += 5;
						 }
						 break;
					 case 'X':
						 if(i > 0){
						 if(charArr[i-1] == 'I'){
							 result += 8;
						 }else{
							 result += 10;
						 }
						 }else{
							 result +=10;
						 }
						 break;
					 case 'L':
						 if(i > 0){
						 if(charArr[i-1] == 'X'){
							 result += 30;
						 }else{
							 result += 50;
						 }
						 }else{
							 result += 50;
						 }
						 break;
					 case 'C':
						 if(i > 0){
						 if(charArr[i-1] == 'X'){
							 result += 80;
						 }else{
							 result += 100;
						 }
						 }else{
							 result += 100;
						 }
						 break;
					 case 'D':
						 if(i > 0){
						 if(charArr[i-1] == 'C'){
							 result += 300;
						 }else{
							 result += 500;
						 }
						 }else{
							 result += 500;
						 }
						 break;
						 case 'M':
						 if(i > 0){
						 if(charArr[i-1] == 'C'){
							 result += 800;
						 }else{
							 result += 1000;
						 }
						 }else{
							 result += 1000;
						 }
						 break;
				 }
			 }
			 return result;
     }
 }