using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoObsjetos
{
    class Program
    {
        static void Main(string[] args)
        {

            Persona persona1 = new Persona();
            persona1.nombre = "Juan ";
            persona1.apellidos = "Perez ";
            persona1.edad = 20;

            Console.WriteLine(persona1.nombre + persona1.apellidos + " tiene " + persona1.edad + " años de edad");
            persona1.cumplirAños();
            Console.WriteLine("Ahora " + persona1.nombre + "tiene " + persona1.edad + "años :) es su cumple");
            persona1.altura = 1.82f;
            Console.WriteLine(persona1.nombre +  " mide " + persona1.altura + " es una torre");
            persona1.crecer(.3f);
            Console.WriteLine("Ahora " + persona1.nombre + " mide " + persona1.altura + " de altura");
            Console.ReadLine();
        }
    }
}
