using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARCIAL_II
{
    internal class Profesor : Persona
    {

        private string titulo;
        private string carrera_asignada;
        private double salario;

        public Profesor()
        {

        }

        public string Titulo { get => titulo; set => titulo = value; }
        public string Carrera_asignada { get => carrera_asignada; set => carrera_asignada = value; }
        public double Salario { get => salario; set => salario = value; }

        public void MostrarInformacion()

        {

            Console.WriteLine("titulo:" + titulo);
            Console.WriteLine("carrera_asignada:" + carrera_asignada);
            Console.WriteLine("salario:" + salario);
             
            



        }
    }
}
