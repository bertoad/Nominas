using System;
namespace Nominas.Core
{
    public class Obrero : Empleado
    {
        public const int SalarioHPrefijado = 50;

        public Obrero(string nombre)
            :base(nombre,SalarioHPrefijado)
        {

        }

        public string ToString(int horasT)
        {
            return base.ToString() + " (obrero) ";
        }

    }
}
