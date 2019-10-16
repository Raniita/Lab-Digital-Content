using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    class Usuario
    {
        // Vars
        protected float balance;
        private string dni;
        private string pin;

        // Construct
        public Usuario()
        {
            System.Console.WriteLine("Please, introduce dni and pin");
        }

        public Usuario(string user_dni, string user_pin) {
            this.dni = user_dni;
            this.pin = user_pin;
            //default with balance 0
            this.balance = 0;
            Console.WriteLine("User {0} created with {1} euros", this.dni, this.balance);
        }

        public Usuario(string user_dni, string user_pin, float user_balance) {
            this.dni = user_dni;
            this.pin = user_pin;
            this.balance = user_balance;
            Console.WriteLine("User {0} created with {1}", this.dni, this.balance);
        }

        // Propertys
        public float Balance{
            get{
                return this.balance;
            }
            set {
                this.balance = value;
            }
        }

        public string Dni
        {
            get {
                return this.dni;
            }
        }

        public string Pin
        {
            get
            {
                return this.pin;
            }
        }

        // Methods
        
    }
}
