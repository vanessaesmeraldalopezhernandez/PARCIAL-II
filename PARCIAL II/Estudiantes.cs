using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARCIAL_II
{
    internal class Estudiante : Persona
    {
        private int ciclo;
        private double cum;
        private string carrera;

        public Estudiante()
        {

        }

        public int Ciclo { get => ciclo; set => ciclo = value; }
        public double Cum { get => cum; set => cum = value; }
        public string Carrera { get => carrera; set => carrera = value; }

        public void MostrarInformacion()
        {
            Console.WriteLine("Ciclo:" + Ciclo);
            Console.WriteLine("Cum:" + Cum);
            Console.WriteLine("Carrera:" + Carrera);

        }
    }
}
