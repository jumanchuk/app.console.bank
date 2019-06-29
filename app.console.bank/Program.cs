using System;

namespace App.console.bank
{
    class Program
    {
        static void Main(string[] args)
        {

            Cuenta ctaa = new Cuenta();           
            
            int op=0;

            do
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Menú: ");
                Console.WriteLine();
                Console.WriteLine("1 - Consultar Saldo.");
                Console.WriteLine("2 - Depositar.");
                Console.WriteLine("3 - Retirar.");
                Console.WriteLine("0 - Salir. ");
                Console.WriteLine();
                Console.Write("Ingrese una opción: ");
                op=Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (op)
                {                    
                    case 0:
                    Console.WriteLine();
                    Console.WriteLine("Gracias por utilizar nuestros servicios!.");
                    break;

                    case 1:
                    ctaa.Consultar();
                    Console.WriteLine();
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                    
                    case 2:
                    ctaa.Depositar();
                    Console.WriteLine();
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                    break;

                    case 3:
                    ctaa.Retirar();
                    Console.WriteLine();
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                    break;

                    default:
                    break;
                }
                
            } while (op>0);

        }
    }
}
