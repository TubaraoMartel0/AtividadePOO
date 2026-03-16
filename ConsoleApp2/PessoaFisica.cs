using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class PessoaFisica
    {
        public String nome;
        public int idade;
        public String cpf;

        public void listarDados(String nome, int idade, String cpf)
        {
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("CPF: " + cpf);
        }
    }
}
