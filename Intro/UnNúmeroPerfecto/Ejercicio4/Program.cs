using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num=100;
           

            for (int i = 1; i < num; i++)
            {
                int acum = 0;
                string divisores = "";

                for (int j = 1; j <= (i / 2); j++)
                {
                    if (i%j==0)
                    {
                        acum =acum +j;
                        divisores += " " + j + " " ;
                    }
                }
                if (acum==i)
                {
                    Console.WriteLine("El {0} es perfecto y sus divisores son {1}",i,divisores);
                }
            }

        }
    }
}
