using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Operaciones
    {
        public static void RealizarTransaccion()
        {
            /*OBJETOS Y CLASES*/
            //var cliente = new Cliente();
            //cliente.Nombre = "Gerson";
            //cliente.Vender(100);
            //Console.WriteLine($"El cliente {cliente.Nombre} tiene {cliente.Credito} de crédito.");
            //cliente.Comprar(30);
            //Console.WriteLine($"El cliente {cliente.Nombre} tiene {cliente.Credito} de crédito.");

            /*TIPOS (Por referencia)*/
            var cliente = new Cliente();
            cliente.Nombre = "Gerson";
            Console.WriteLine($"El nombre del cliente es {cliente.Nombre}");
            CambiarNombre(cliente);
            Console.WriteLine($"El nombre del cliente es {cliente.Nombre}");

            /*TIPOS (Por valor)*/
            var saldo = 5000;
            Console.WriteLine($"El saldo del cliente es {saldo}");
            DuplicarSaldo(saldo);
            Console.WriteLine($"El saldo del cliente es {saldo}");
        }
        public static void CambiarNombre(Cliente cliente)
        {
            cliente.Nombre = "Jorge";
        }
        public static void DuplicarSaldo(int saldo)
        {
            saldo *= 2;
        }
    }
}
