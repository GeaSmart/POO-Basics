using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class RepositorioPersonasBD : IRepositorioPersonas, IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Se ejecutó el dispose");
        }

        public void ObtenerPersonas()
        {
            Console.WriteLine("Obteniendo personas de la base de datos");
        }
    }
}
