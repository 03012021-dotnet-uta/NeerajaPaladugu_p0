

/*
•		Print the numbers 1 to 1000 to the console. 
•	Print them in groups of 10 per line with a space separating each number.  
•	When the number is multiple of three, print “sweet” instead of the number on the console.  
•	If the number is a multiple of five, print “salty” (instead of the number) to the console.  
•	For numbers which are multiples of three and five, print “sweet’nSalty” to the console (instead of the number).  
•	After the numbers have all been printed, print out how many sweet’s, how many salty’s, and how many sweet’nSalty’s. These are three separate groups, so sweet’nSalty does not increment sweet or salty (and vice versa). 
•	Include verbose commentary in the source code to tell me what each few lines are doing. 
•	The coding Challenge is due by midnight, today, 03.10.21. 
•	Push the “compilable” source code to your P0 repo. */
 

using System;

namespace FizzbuzzUI
      {
    class Program
    {

        int sweetCount = 0;
        int saltyCount = 0;
        int sweet_SaltyCount = 0;

        static void Main(string[] args){

      Program p = new Program();
        p.printJob();

                             
            //for(int i = 1; i <= 1000; i++)
           // Console.WriteLine(i+((i%10==9) ? "\n" : " "));
           Console.WriteLine();
         
          Console.WriteLine(" N of sweet:" + p.sweetCount + "  N of salty: " + p.saltyCount + "N of sweetandsalty: " + p.sweet_SaltyCount +"" );
         
        
                      
        }
        
       private  void printJob(){

            for( int i = 0; i < 1000; i++){

                if((i-1) % 10 == 0 ){
                    Console.WriteLine();
                }
                if(i % 15 == 0){
                    Console.Write(" sweetandsalty  ");
                    sweet_SaltyCount++;
                    continue;
                }
                 if(i % 3 == 0){
                     Console.Write("  sweet ");
                    sweetCount++;
                    continue;

                 }
                  if(i % 5 == 0){
                Console.Write(" salty ");
                    saltyCount++;
                    continue;

                  }
                 
                 
                        Console.Write(" "  +i+ " ");
            } 

                
        }
    }
}
