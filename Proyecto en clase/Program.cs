using Clase_Erencia.Clase_Base;
using Clase_Erencia.Clase_Hija;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Clase_Erencia
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Xbox xb = new Xbox();
            xb.GamePass = true;
            xb.AnioLanzamiento = 2022;
            xb.Marca = "Xbox Series X";
            string resultado2 = xb.MostrarDetallesXbox();
            Console.WriteLine(resultado2);
        }
    }
}