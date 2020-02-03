using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;

namespace objeto_op
{
    public class operaciones : MarshalByRefObject
    {
        public operaciones()
        {

        }

        public double sumar(double a, double b)
        {
            return a + b;
        }

        public double restar(double a, double b)
        {
            return a - b;
        }

        public double multiplicar(double a, double b)
        {
            return a * b;
        }

        public double dividir(double a, double b)
        {
            return a / b;
        }
    }
}
