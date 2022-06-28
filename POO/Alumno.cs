using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Alumno
    {
        /* CONSTRUCTORES */
        public Alumno()
        {
            Console.WriteLine("Un objeto de la clase Alumno se ha creado");
        }
        public Alumno(int id, string Nombre, DateTime fechaMatricula)
        {
            this.Id = id;
            this.Nombre = Nombre;
            this.FechaMatricula = fechaMatricula;
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaMatricula { get; set; }
        public List<String> Direcciones { get; set; }
    }
}
