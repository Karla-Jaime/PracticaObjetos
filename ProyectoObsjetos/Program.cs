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
            Contacto contacto1 = new Contacto(); // new es para creas las instancias de las clases

            contacto1.Nombre = "Pedro Lopez";
            contacto1.TelefonoCasa = "(644) 432- 3275";
            contacto1.TelefonoCelular = "644-407-2375";
            contacto1.Direccion = "5 de Febrero 510";

            Console.WriteLine("Nombre: " + contacto1.Nombre);
            Console.WriteLine("Telefono de casa: " + contacto1.TelefonoCasa);

            Contacto contacto2 = new Contacto("Juan Perez");
            Console.WriteLine("Contacto 2: ");
            Console.WriteLine("Nombre: " + contacto2.Nombre);

            Contacto contacto3 = new Contacto("Maria Navarro", "(644) 416 - 3885", 
                "644 107 2875", "5 de Febrero", "maria-bonita@hotmail.com");
            Console.WriteLine("Contacto 3: ");
            Console.WriteLine("Nombre: " + contacto3.Nombre);
            Console.WriteLine("Telefono de Casa: " + contacto3.TelefonoCasa);
            Console.WriteLine("Telefono Celular: " + contacto3.TelefonoCelular);
            Console.WriteLine("Direccion: " + contacto3.Direccion);
            Console.WriteLine("Correo Electronico: " + contacto3.CorreoElectronico);

            Console.ReadLine();
        }
    }
}
