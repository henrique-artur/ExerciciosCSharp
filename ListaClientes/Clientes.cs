using System.Collections.Generic;
using System;

namespace ListaClientes
{
    public class Clientes
    {
        //Atributos
        private string nome;
        private int idade;
        
        //Metodos acessores
        public string GetNome()
        {
            return nome;
        }
        public void SetNome(string n)
        {
            nome = n;
        }
        
        public int GetIdade()
        {
            return idade;
        }
        public void SetIdade(int i)
        {
            idade = i;
        }

        //Metodos
        public void MostraDados(List<string> j, List<int> data)
        {
            for(int i = 0; i < j.Count; i++){
                Console.WriteLine($"nome: {j[i]}, e idade: {data[i]}");               
            }

        }
    }
}