using System;
using System.Collections.Generic;

namespace SistemaDePedidos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> mesa26 = new List<string>();
            ItemPedido item = new ItemPedido();
            Pedido pedido;
            string conteudo;
            double val, total = 0;
            int quant;
            char condicao;

            do{
                Console.Write("Insira o item pedido: ");
                mesa26.Add(conteudo = Console.ReadLine());
                Console.Write("Insira o valor do pedido: ");
                val = double.Parse(Console.ReadLine());
                Console.Write("insira a quantidade do item: ");
                quant = int.Parse(Console.ReadLine());
                
                total += item.Totalizar(val, quant);
                pedido = new Pedido(mesa26);

                Console.Write("Deseja inserir novo pedido? [s/n]: ");
                condicao = char.Parse(Console.ReadLine());
                Console.WriteLine("");
            }while(condicao != 'n');
            
            Console.WriteLine("Pedido finalizado:");
            pedido.MostrarItens(mesa26);
            Console.WriteLine("Valor total R${0:N2}", total);
        }
    }
}
