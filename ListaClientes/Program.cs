//Codigo se baseia em uma lista de dados de clientes armazenados em lista simples
using System;
using System.Collections.Generic;

namespace ListaClientes
{
    class Program
    {
        static void Main(string[] args)
        {
            Clientes clientes = new Clientes();
            string condicao;
            List<string> c = new List<string>();
            List<int> i = new List<int>();
            
            
            do{
                Console.Write("Digite a opcao desejada [i-Inserir; l-Listar; s-Sair]: ");
                condicao = Console.ReadLine();

                switch(condicao){
                    case "i":
                        Console.Clear();
                        Console.Write("Digite o nome do cliente: ");
                        clientes.SetNome(Console.ReadLine());
                        Console.Write("Digite a idade do cliente: ");
                        clientes.SetIdade(int.Parse(Console.ReadLine()));
                        c.Add(clientes.GetNome());
                        i.Add(clientes.GetIdade());
                        msg();
                        break;    
                    case "l":
                        Console.Clear();
                        Console.WriteLine("Lista de clientes: ");
                        clientes.MostraDados(c, i);
                        msg();
                        break;
                    case "s":
                        Console.Clear();
                        Console.WriteLine("Encerrando a aplicação...\n");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Operação invalida! Tente novamente");
                        break;    
                }
                    
            }while(condicao != "s");

        }
        static void msg(){
            Console.WriteLine("Ação realizada com sucesso!!\n");
        }
    }
}
