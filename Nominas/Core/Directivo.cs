using System;
namespace Nominas.Core
{
    public class Directivo : Empleado
    {
        public const int SalarioBase = 1000;
        public const int SalarioHPrefijado = 100;

        public Directivo (string nombre)
           :base(nombre,SalarioHPrefijado)
        {
        }

        public override int CalcularNomina(int horasT)
        {
            return base.CalcularNomina(horasT) + SalarioBase;
        }

        public string ToString(int HorasT)
        {
            return base.ToString() + " (directivo) ";
        }

    }
}
