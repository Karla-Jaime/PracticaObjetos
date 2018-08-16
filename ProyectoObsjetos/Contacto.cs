using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoObsjetos
{
    class Contacto
    {
        public string Nombre { get; set; }
        public string TelefonoCelular { get; set; }
        public string  TelefonoCasa { get; set; }
        public string Direccion { get; set; }
        public string CorreoElectronico { get; set; }

        public Contacto()
        {
            Nombre = "Nuevo Contacto";
            TelefonoCasa = "(000) 000 - 0000";
        }
        public Contacto(string nombre)
        {
            Nombre = nombre;
        }
        public Contacto(string nombre, string telefonoCasa, string telefonoCelular,
            string direccion, string correoElectronico)
        {
            Nombre = nombre;
            TelefonoCasa = telefonoCasa;
            TelefonoCelular = telefonoCelular;  //se igual al nombre del parametro
            Direccion = direccion;
            CorreoElectronico = correoElectronico;
            
        }
       
    }
}
