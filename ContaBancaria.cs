namespace dotnet_learning_path
{
    public class Pessoa
    {
        private string nome;
        private int idade;

        public string mensagem;

        public int GetIdade()
        {
            return idade;
        }

        public void SetIdade(int value)
        {
            idade = value;
        }

        public string GetNome()
        {
            return nome;
        }

        public void SetNome(string value)
        {
            nome = value;
        }

        public string Verifica()
        {
            if(idade < 21)
            {
                mensagem = "Não é o raziel";
                return this.mensagem;
            }
                mensagem = "É o raziel";
            return this.mensagem;
        }
        
    }
}