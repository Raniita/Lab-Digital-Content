using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    class Ordenar
    {
        // Vars
        private int[] list;
        private int[] sorted_list;

        // Constructor
        public Ordenar()
        {
            Console.WriteLine("\nPlease, introduce a list to sort");
        }

        public Ordenar(int[] mList)
        {
            if (mList.Length == null && mList.Length > 25)
            {
                Console.WriteLine("\nEnter a valid list to sort");
            }
            else
            {
                // Array okai to sort
                this.list = mList;
                Console.WriteLine("\nList saved. Ready for sort");
            }
        }

        // Methods
        public int[] ordenar_bubble()
        {
            // Algoritmo de la burbuja, sencillo y eficaz
            int[] cList = this.list;
            int temp;

            for (int j = 0; j <= cList.Length - 2; j++)
            {
                for (int i = 0; i <= cList.Length - 2; i++)
                {
                    if (cList[i] > cList[i + 1])
                    {
                        temp = cList[i + 1];
                        cList[i + 1] = cList[i];
                        cList[i] = temp;
                    }
                }
            }

            this.sorted_list = cList;

            return this.sorted_list;
        }
    }
}
