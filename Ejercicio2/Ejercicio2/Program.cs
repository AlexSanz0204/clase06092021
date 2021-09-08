using Ejercicio2.Entidades;
using Ejercicio2.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {

            ClsTemperatura clstemperatura = new ClsTemperatura();
            NClsTemperatura nclstemperatura = new NClsTemperatura();
            clstemperatura.Tipo_de_clima1 = "Frío";
            clstemperatura.Tipo_de_clima2 = "Nublado";
            clstemperatura.Tipo_de_clima3 = "Caluroso";
            clstemperatura.Tipo_de_clima4 = "tropical";


            Console.WriteLine("Ingresa la Temperatura");
            Console.WriteLine("------------------------");
            Console.WriteLine(" ");
            double temperatura = Convert.ToDouble(Console.ReadLine());

            if (temperatura <= 10)
            {
                Console.WriteLine("El clima esta "+ clstemperatura.Tipo_de_clima1);
                Console.WriteLine(" ");
            }
            else
            {
                if (temperatura > 10 && temperatura <= 20)
                {
                    Console.WriteLine("El clima esta "+ clstemperatura.Tipo_de_clima2);
                    Console.WriteLine(" ");
                }
                else
                {
                    if (temperatura > 20 && temperatura <= 30)
                    {
                        Console.WriteLine("El clima esta "+ clstemperatura.Tipo_de_clima3);
                        Console.WriteLine(" ");
                    }
                    else
                    {
                        if (temperatura > 30)
                        Console.WriteLine("El clima esta "+ clstemperatura.Tipo_de_clima4);
                        Console.WriteLine(" ");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
