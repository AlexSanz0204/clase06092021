using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int dato = 1;
            while (dato == 1)
            {

                Console.WriteLine("Coloque un valor que corresponda a lo que desea sacar de dinero.");
                int x = Convert.ToInt32(Console.ReadLine());


                if (x % 5 == 0)
                {

                    Console.WriteLine("enhrabuena, Puedes sacar tu dinero.");
                }
                else
                {

                    Console.WriteLine("Error,El dinero no se ha podido sacar.");
                    dato = 2;

                    Console.ReadLine();
                }
            }
        }
    }
}
