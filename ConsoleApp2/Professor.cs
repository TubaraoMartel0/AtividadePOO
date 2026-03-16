using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ConsoleApp2
{
    internal class Professor : PessoaFisica
    {
        public String formacao;
        public String cargo;
        public double salario;

        public void listarProfessor(String formacao, String cargo, double salario)
        {
            Console.WriteLine("Formação acadêmica: " + formacao);
            Console.WriteLine("Cargo na instituião: " + cargo);
            Console.WriteLine("Salário: " + salario);
        }

        public void cadastrarDisciplina()
        {
            Console.WriteLine("Em qual disciplina deseja cadastrar o professor?");
            String disciplina = Console.ReadLine();
            Console.WriteLine("O professor foi cadastrado na disciplina: " + disciplina);
        }
    }
}
