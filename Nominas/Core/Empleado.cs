using System;
namespace Nominas.Core
{
    public abstract class Empleado
    {
        protected Empleado(string nombre, int SalarioHora)
        {
            this.Nombre = nombre;
            this.SalarioH = SalarioHora;
        }

        public int SalarioH
        {
            get; set;
        }

        public string Nombre
        {
            get; set;
        }

        public virtual int CalcularNomina(int horasT)
        {
            return horasT * this.SalarioH;
        }

        public override string ToString()
        {
           return "Empleado: " + this.Nombre + ", sueldo por hora(€): " + this.SalarioH ; 
        }
    }
}
