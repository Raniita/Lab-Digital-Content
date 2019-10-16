using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creamos el usuario
            string yo_dni = "12345678";
            string yo_pin = "1245";
            float init_money = 1000;
            Usuario yo = new Usuario(yo_dni, yo_pin, init_money);
            Console.WriteLine("User created");

            // Nos conectamos al cajero automatico
            CajeroAutomatico santander = new CajeroAutomatico(yo);
            Console.WriteLine("Logged on Santander");

            // Consultamos el dinero
            santander.consultar();

            // Ingresamos 10e
            santander.ingresar(10);

            // Retiramos 10e
            santander.retirar(10);

            // Retiramos 400e
            santander.retirar(400);

            // Consultamos
            santander.consultar();

            // Ingresamos 5e
            santander.ingresar(5);

            // Probamos otro usuario
            string dni_2 = "5478787421";
            string pin_2 = "12345";
            Usuario user_2 = new Usuario(dni_2, pin_2);
            Console.WriteLine("User created");

            // Logeamos en el bank
            CajeroAutomatico bank = new CajeroAutomatico(user_2);

            // Consultamos
            bank.consultar();

            // Retiramos 10000
            bank.retirar(10000);

            // Ingresamos -3
            bank.ingresar(-3);

            // Consultamos
            bank.consultar();

            String a = Console.ReadLine();
        }
    }
}
