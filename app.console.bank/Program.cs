using System;

namespace App.console.bank
{
    class Program
    {
        static void Main(string[] args)
        {

            Products c = new Products();           
            Operar retirar = c.Retirar;

            int op=0;
            decimal monto;

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
                    
                try
                {
                op=Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                Console.WriteLine();
                Console.Write("Ingrese una opción valida.");
                op=-1;
                Console.ReadKey();
                }
                switch (op)
                {                    
                    case 0:
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("Gracias por utilizar nuestros servicios.");
                    break;

                    case 1:
                    Console.Clear();
                    Console.WriteLine();
                    c.imprSaldo(c.Saldo);
                    break;
                    
                    case 2:
                    Console.Clear();
                    Console.WriteLine();
                    Console.Write("Ingrese el monto de la operación: ");
                    try
                    {   //llamando directamente al metodo
                        monto=Convert.ToDecimal(Console.ReadLine());
                        c.imprRes(c.Depositar(monto));
                        c.imprSaldo(c.Saldo);
                    }
                    catch
                    {
                        Console.Clear();
                        Console.WriteLine();
                        Console.Write("Ingrese un monto valido");
                        Console.ReadKey();
                    }
                    break;

                    case 3:
                    Console.Clear();
                    Console.WriteLine();
                    Console.Write("Ingrese el monto de la operación: ");
                    monto=Convert.ToDecimal(Console.ReadLine());
                    //llamo a través de delegados
                    c.imprRes(retirar(monto));
                    c.imprSaldo(c.Saldo);
                    break;

                    default:
                    Console.Clear();
                    break;
                }
                
            } while (op!=0);

        }
    }
}
