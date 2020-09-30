using System;

namespace listaEncadeada
{
    class Program
    {
        static void Main(string[] args)
        {
            economia eco;
            long populacao, pib;
            string paises; 
            char condicao;

            do{
                Console.Write("Nome do pais: ");
                paises = Console.ReadLine();
                Console.Write("Digite o PIB deste pais: ");
                pib = long.Parse(Console.ReadLine());
                Console.Write("Digite a população do pais: ");
                populacao = long.Parse(Console.ReadLine());

                eco = new economia(paises, pib, populacao);                
                listaPaises.incluir(eco);

                Console.Write("Deseja cadastrar mais algum pais? [s/n] ");
                condicao = char.Parse(Console.ReadLine()); 
            } while (condicao != 'n');
            Console.WriteLine("Lista de exibição: ");
            listaPaises.exibir();
        }
    }
}
