using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ASSN706_EKF
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare Variables
            int x, y, z;
            string stars = "*";

            for (z = 7; z >= 0; z = z - 1)
            {
                
                //Spaces Loop
                for (y = z; y >= 0; y = y - 1)
                {
                    Console.Write(" ");


                }//end Spaces Loop            

                //Star Loop
                for (x = (15-(z*2)); x >= 1; x = x - 1 )
                {
                    Console.Write(stars);
                    
                    
                }//end star loop
                Console.WriteLine();
            }//end loop

            Console.WriteLine("       ***");
            Console.WriteLine("       ***");
            Console.WriteLine("       ***");

            Console.ReadLine();


        }// end main
    }//end class
}//end program
