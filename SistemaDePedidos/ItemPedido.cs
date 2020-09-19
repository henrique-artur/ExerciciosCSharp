namespace SistemaDePedidos
{
    public class ItemPedido
    {
        //Atributos
        private string descricao;
        private double valorUnitario;
        private int quantidade;

        //Getters e Setters

        public string GetDescricao(){
            return this.descricao;
        }

        public void SetDescricao(string descr){
           this.descricao = descr; 
        }

        public double GetValorUnitario(){
            return this.valorUnitario;
        }

        public void SetValorUnitario(double valorUni){
            this.valorUnitario = valorUni;
        }

        public int GetQuantidade(){
            return this.quantidade;
        }
        
        public void SetQuantidade(int quant){
            this.quantidade = quant;
        }
        //metodos
        public double Totalizar(double valor, int q){
            this.valorUnitario = valor * q;
            return this.valorUnitario;
        }
    }
}