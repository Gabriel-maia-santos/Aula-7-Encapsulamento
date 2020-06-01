using System;

namespace Aula_5
{
    public class MasterCard : Cartao
    {
        
        public int parcelas { get; set; }
        

        public void ComprarComDescontoMastercard(float desconto){
            // Utilizando encapsulamento com assinatura "protected"
            cvv = "123";
            Console.WriteLine($"Compra realizada com {parcelas} parcelas e R$ {desconto} de desconto!");
        }
    }
}