using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpTestII
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable declaration
            int x, y, a, b;

            //assign variables
            x = 3;
            y = 2;
            a = 1;
            b = 0;

            //adding
            x = 3 + 4;

            //subtracting
            x = 4 - 3;

            //multiplying
            x = 10 * 5;

            //division
            x = 10 / 5;

            //PEMDAS
            x = (x + y) * (a - b);

            //equality
           
             if(x == y)
             {

             }

             //greater than
             if(x > y)
             {

             }
                
             //less than
             if(x<y)
             {

             }

             //conditional
             if((x > y) && (a > b))
            {

            }

            if ((x > y) || (a > b))
            {

            }

            //in line conditional
            string message = (x == 1) ? "Car" : "Break";

            Console.WriteLine("Hi");
        }
    }
}
