using System;

namespace senai_Ifood
{
    class Program
    {
        static void Main(string[] args)
        {
           Cliente henrique = new Cliente("Henrique Leandro");
            henrique.Endereco = "Estrada nova ipê, 1028";
            Restaurante BK = new Restaurante("Burguer King" , "Shopping Diadema, 1028" );

            Pedido pedido1 = new Pedido();
            pedido1.Cliente = henrique;
            pedido1.Restaurante = BK;

            System.Console.WriteLine(pedido1.EntregarPedido());
        }
    }
}
