using System;
using AulaPOO_Heranca.classes;

namespace AulaPOO_Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
           PessoaFisica pf = new PessoaFisica();
            pf.nome = "Matheus";
            
            Console.WriteLine("Digite seu CPF");
            pf.cpf = Console.ReadLine();

            Console.WriteLine(pf.DarBoasVindas(pf.nome));
            Console.WriteLine(pf.ValidarCPF(pf.cpf));
        }
    }
}
