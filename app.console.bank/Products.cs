using System;

namespace App.console.bank
{

    delegate bool Operar(decimal monto);
    
    class Products
    {
        private decimal saldo;
        
        /* Constructor, siempre tiene que ser publico */
        public Products()
        {
            //Constructor de la clase
            saldo = 0;
        }

        public decimal Saldo{
            get { return saldo;}
        }
            
        public bool Depositar(decimal monto)
        {
            if (monto>0){
                
                saldo+=monto;
                return true;

            }else{

                return false;
            }
        }

        public bool Retirar(decimal monto)
        {
            if (monto<=saldo){
                
                saldo-=monto;
                return true;

            }else{

                return false;

            }

        }

        public void imprSaldo(decimal saldo){

        Console.WriteLine("Su saldo disponible es: "+ saldo);
        Console.WriteLine();
        Console.WriteLine("Presione cualquier tecla para continuar...");
        Console.ReadKey();
        Console.Clear();

        }

        public void imprRes(bool r){

            if (r==true){
                Console.WriteLine();
                Console.WriteLine("Operación Exitosa");

            }else{
                Console.WriteLine();
                Console.WriteLine("Operación Rechazada");

            }
        }


        }

    }