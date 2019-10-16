using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Practica 2. Ordenar 25 numeros");
            // Generamos la lista aleatoria
            Random random = new Random();
            int[] mi_lista = new int[25];
            for (int i = 0; i <=24; i++)
            {
                mi_lista[i] = random.Next(0, 100);
                Console.WriteLine("{0} numero generado: {1}", i, mi_lista[i]);
            }

            // Printeamos la lista sin ordenar
            Console.WriteLine("Lista desordenada");
            foreach (int i in mi_lista)
            {
                Console.Write(i + ", ");
            }

            // Llamamos a ordenar
            Ordenar sort = new Ordenar(mi_lista);
            int[] lista_ordenada = sort.ordenar_bubble();

            // Printeamos la lista ordenada
            Console.WriteLine("Lista Ordenada:");
            foreach (int num in lista_ordenada)
            {
                Console.Write(num + ", ");
            }

            String a = Console.ReadLine();
        }
    }
}
