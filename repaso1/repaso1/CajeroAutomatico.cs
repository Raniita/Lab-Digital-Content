using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    class CajeroAutomatico
    {
        // Vars
        private Usuario logged_user;

        // Construct
        public CajeroAutomatico()
        {
            Console.WriteLine("Please, log in");
        }

        public CajeroAutomatico(Usuario user)
        {
            // Logeamos con el usuario
            this.logged_user = user;
            Console.WriteLine("Logged as {0} with pin {1}", user.Dni, user.Pin);
        }

        // Propertys

        // Methods
        public virtual float ingresar(float dinero)
        {
            // Check params
            if (dinero < 0)
            {
                Console.WriteLine("Invalid value. Please, dinero must be possitive");
                return 0;
            }
            else {
                logged_user.Balance = logged_user.Balance + dinero;
                Console.WriteLine("Succesfull! Added {0} in our account", dinero);
                return logged_user.Balance;
            }
        }

        public virtual float retirar(float dinero)
        {
            // Check params
            if (dinero < 0)
            {
                Console.WriteLine("Invalid value. Please, dinero must be possitive");
                return 0;
            }
            else {
                if (dinero > logged_user.Balance)
                {
                    Console.WriteLine("Must withdraw the max of ur money");
                    return logged_user.Balance;
                }
                else {
                    logged_user.Balance = logged_user.Balance - dinero;
                    Console.WriteLine("Succesfull! You withdraw {0}", dinero);
                    return logged_user.Balance;
                }
            }
        }

        public virtual void consultar()
        {
            // Check params
            Console.WriteLine("Money: {0}", logged_user.Balance);
        }
    }
}
