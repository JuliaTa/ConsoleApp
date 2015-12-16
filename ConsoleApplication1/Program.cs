using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Math {

        int A;
        int B;
        int C;
        string G;
        Math(string name) : this(200,30) {
            this.G = name;
        }

        Math(int A, int B){
            this.A = A;
            this.B = B;
    }
        Math(int A, int B, int C)
        {

        }
        
    }




    class Program
    {
        static void Main()
        {

            Math A = new Math();

            
            Console.ReadKey();

        }
    }
}
