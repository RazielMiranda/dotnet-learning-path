namespace dotnet_learning_path
{
    public class ContaBancaria
    {
        protected string nome;
        protected string banco;
        protected string agencia;
        protected int conta;
        private float saldo;

        public void exibir_conta(string nome, string banco, string agencia, int conta, float saldo){
            this.nome = nome;
            this.banco = banco;
            this.agencia = agencia;
            this.conta = conta;
            this.saldo = saldo;
        }

        public float get_saldo(){
            return this.saldo;
        }
        
        
    }
}