namespace listaEncadeada
{
    public class economia
    {
        private string pais;
        private long pib;
        private long populacao;

        //metodos

        public economia(string a, long b, long c){
            this.pais = a;
            this.pib = b;
            this.populacao = c;
        }

        public string getPais(){
            return this.pais;
        }

        public long getPib(){
            return this.pib;
        }

        public long getPopulacao(){
            return this.populacao;
        }
    }
}