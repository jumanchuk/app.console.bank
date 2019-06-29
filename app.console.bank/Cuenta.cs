using System;

namespace App.console.bank
{
    public class Cuenta
    {
        decimal saldo;
        bool estado;

        public Cuenta()
        {
            //Constructor de la clase
            saldo = 0;
        }

        public Cuenta(int nrocta)
        {
            if (nrocta==1)
            {


            }
            else
            {
                Console.WriteLine("Numero de cuenta invalida!");
            }
        }

        public void Depositar()
        {
            decimal monto;

            Console.Write("Ingrese un el monto del deposito: ");
            monto = Convert.ToDecimal(Console.ReadLine());
            
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