﻿using System;
using Nominas.Core;

namespace Nominas.UI
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Empleado d = new Directivo("Donald");
	    Empleado d = new Directivo("Daisy");
            Empleado o = new Obrero("Pepo");
	    Empleado o2 = new Obrero("Obrero");
            Console.Out.WriteLine(d.ToString(10));
            //Console.Out.WriteLine("Nomina: " + d.CalcularNomina(10));

            Console.Out.WriteLine(o.ToString(10));
            //Console.Out.WriteLine("Nomina: " + o.CalcularNomina(10));
        }
    }
}
