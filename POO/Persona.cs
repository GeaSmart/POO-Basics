using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Persona
    {
        public Persona()
        {
            Console.WriteLine("Objeto persona inicializado");
            Direcciones = new List<string>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Sueldo { get; set; }
        public List<String> Direcciones { get; set; }
    }
}
