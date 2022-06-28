using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class RepositorioPersonasMemoria : IRepositorioPersonas
    {
        public void ObtenerPersonas()
        {
            Console.WriteLine("Obteniendo personas desde la memoria");
        }
    }
}
