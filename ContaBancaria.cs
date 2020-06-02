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
                return this.mensagem;
            }

            using (System.IO.TextWriter documento = System.IO.File.CreateText("documento.txt"))
            {
                documento.WriteLine($"Seu nome: {this.nome}");
                documento.WriteLine($"Sua idade:{this.idade}");
            }
            return this.mensagem;
        }
        
    }
}