using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARCIAL_II
{
    internal class Persona
    {
        protected string nombre;
        protected string apellido;
        protected int edad;
        protected string fecha_nacimiento;

       public string Nombre { get => nombre; set => nombre = value; }
       public string Apellido { get => apellido; set => apellido = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Fecha_nacimiento { get => fecha_nacimiento; set => fecha_nacimiento = value; }

        public Persona()
        {

        }



        public void MostrarNombreCompleto()
        {
            nombre = Nombre;
            apellido = Apellido;
            edad = Edad;
            Fecha_nacimiento = Fecha_nacimiento;

        }
    }
}
