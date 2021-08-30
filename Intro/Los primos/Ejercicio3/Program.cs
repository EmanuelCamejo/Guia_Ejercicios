using System;


namespace Los_primos
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            string res;
            bool respuesta = false;
            int divisores = 0;

            do
            {

                Console.WriteLine("Ingrese un número para saber los números primos que hay hasta el número ingresado");
                if (int.TryParse(Console.ReadLine(), out num) && num>0)
                {
                   
                        Console.Write("\nLos números primos de {0} son:", num);
                        for (int i = 0; i <= num; i++)
                        {
                            divisores = 0;
                            for (int j = 2; j < i; j++)
                            {
                                if ((i % j) == 0)
                                {
                                    divisores++;
                                }
                            }
                            if (divisores == 0 && i > 1)
                                Console.Write(" {0} ", i);
                        }
                        Console.WriteLine();
                    
                   

                    respuesta = false;

                }
                else
                {
                    Console.Write("ERROR. ¡Reingresar, tendra que reingrasar un número y mayor que 0!\n");
                    Console.WriteLine("Si desea salir escriba 'Salir'");
                    res = Console.ReadLine();
                    Console.WriteLine();
                    if (res == "salis" || res == "Salir")
                    {
                        respuesta = true;
                    }
                    else
                    {
                        respuesta = false;
                    }
                }


            } while (respuesta);


        }
    }
}
