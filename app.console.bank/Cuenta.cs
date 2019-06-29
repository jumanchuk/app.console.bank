using System;

namespace App.console.bank
{
    public class Cuenta
    {
        double saldo;

        public Cuenta()
        {
            saldo = 0;
        }

        public void Depositar()
        {
            double monto;

            Console.Write("Ingrese un el monto del deposito: ");
            monto = Convert.ToDouble(Console.ReadLine());
            
            if(monto>0){

            saldo=monto;
            Console.WriteLine();
            Console.WriteLine("Deposito efectuado correctamente.");
            Console.WriteLine();
            Console.Write("Saldo anterior: "+(saldo-monto));
            Console.WriteLine(" --> Nuevo saldo: "+(saldo));

            }
            else
            {

             Console.WriteLine("Deposito efectuado correctamente.");
             Depositar();
             Console.WriteLine();

            }

        }

        public void Consultar()
        {
            Console.WriteLine();
            Console.WriteLine("El Saldo actual es: " + saldo);

        }

    }
    
}