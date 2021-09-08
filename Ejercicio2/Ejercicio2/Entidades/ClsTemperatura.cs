using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Entidades
{
    class ClsTemperatura
    {
        private double temperatura;
        private string tipo_de_clima1;
        private string tipo_de_clima2;
        private string tipo_de_clima3;
        private string tipo_de_clima4;

        public double Temperatura { get => temperatura; set => temperatura = value; }
        public string Tipo_de_clima1 { get => tipo_de_clima1; set => tipo_de_clima1 = value; }
        public string Tipo_de_clima2 { get => tipo_de_clima2; set => tipo_de_clima2 = value; }
        public string Tipo_de_clima3 { get => tipo_de_clima3; set => tipo_de_clima3 = value; }
        public string Tipo_de_clima4 { get => tipo_de_clima4; set => tipo_de_clima4 = value; }
    }
}
