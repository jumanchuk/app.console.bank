using System;

namespace App.console.bank
{
    public class Cuenta
    {
        decimal saldo;

        public Cuenta()
        {
            //Constructor de la clase
            saldo = 0;
        }

        public void Consultar()
        {
            Console.WriteLine();
            Console.WriteLine("El Saldo actual es: " + saldo);

        }

        public void Depositar()
        {
            decimal monto;

            Console.Write("Ingrese un el monto del deposito: ");
            monto = Convert.ToDecimal(Console.ReadLine());
            
            if(monto>0){

            saldo+=monto;
            Console.WriteLine();
            Console.WriteLine("Deposito efectuado correctamente.");
            Console.WriteLine();
            Console.Write("Saldo anterior: "+(saldo-monto));
            Console.WriteLine(" --> Nuevo saldo: "+(saldo));

            }
            else
            {

             Console.WriteLine("Ingrese un importe valido.");
             Depositar();
             Console.WriteLine();

            }

        }

        public void Retirar()
        {
            decimal monto;

            Console.Write("Ingrese un el monto del deposito: ");
            monto = Convert.ToDecimal(Console.ReadLine());
            
            if(monto>0){

            saldo-=monto;
            Console.WriteLine();
            Console.WriteLine("Retiro efectuado correctamente.");
            Console.WriteLine();
            Console.Write("Saldo anterior: "+(saldo+monto));
            Console.WriteLine(" --> Nuevo saldo: "+(saldo));

            }
            else
            {

             Console.WriteLine("Ingrese un importe valido.");
             Retirar();
             Console.WriteLine();

            }

        }

    }
    
}