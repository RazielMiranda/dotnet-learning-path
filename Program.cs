using System;

namespace dotnet_learning_path
{
    class Program
    {
        static void Main(string[] args)
        {   
            Pessoa Raziel = new Pessoa();
          
            Raziel.SetNome("Raziel M.");
            Raziel.SetIdade(21);
            Console.WriteLine(Raziel.GetNome());
            Console.WriteLine(Raziel.GetIdade());
            Console.WriteLine(Raziel.Verifica());
        }
    }
}
