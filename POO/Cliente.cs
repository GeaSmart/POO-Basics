using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Cliente
    {
        /* CAMPOS */
        private int id;
        private string nombre;

        /* PROPIEDADES */
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public decimal Credito { get; set; } //Propiedad auto-implementada

        /* MÉTODOS */
        public void Comprar(decimal monto)
        {
            this.Credito -= monto;
        }
        public void Vender(decimal monto)
        {
            this.Credito += monto;
        }
    }
}
