using System;

namespace Aula_5
{
    public class Cartao
    {
        
        public string numero { get; set; }
        public string titular { get; set; }
        public string bandeira { get; set; }

        private string token = "alsndsqoidlkanfioqniofalkhsukiowesjrgioj309t3j094j0tj3afhuishfh";
        protected string cvv { get; set;}

        public void AprovarCompra (){

            Console.WriteLine("Compra aprovada!");
        }

        private bool ValidarToken(){
            if(token != null){
                return false;
            }
            return true;
        }

        protected bool ValidarCompra(){
            return true;
        }

    }
}