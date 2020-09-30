using System.Collections.Generic;
using System;

namespace listaEncadeada
{
    public static class listaPaises
    {
        private static List<economia> lista = new List<economia>();

        //Metodos

        public static void incluir(economia eco){
            lista.Add(eco);
        }
        public static void exibir(){
            foreach (economia eco in lista)
            {
                Console.WriteLine("Pais: " + eco.getPais());
                Console.WriteLine("PIB: US$ " + eco.getPib());
                Console.WriteLine("Pop.: " + eco.getPopulacao());
                Console.WriteLine();
            }
        }
        
    }
}