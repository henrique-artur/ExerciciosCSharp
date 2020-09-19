using System.Collections.Generic;
using System;

namespace SistemaDePedidos
{
    public class Pedido
    {
        //Atributos
        private List<string> conta;
        //----------------------------------------
        //Getters e Setters
        public List<string> GetConta(){
            return conta;
        }
        public void SetConta(List<string> cont){
            this.conta = cont;
        }
        //----------------------------------------
        //metodos
        public void Incluir(string pedido){
            this.conta.Add(pedido);
        }

        public void MostrarItens(List<string> itens){
            for(int i = 0; i < itens.Count; i++){
                Console.WriteLine(itens[i]);
            }
        }

        //----------------------------------------
        //construtor 
        public Pedido(List<string> itens){
            this.conta = itens;
        }

        
    }
}