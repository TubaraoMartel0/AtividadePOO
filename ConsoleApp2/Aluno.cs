using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Text;

namespace ConsoleApp2
{
    internal class Aluno : PessoaFisica
    {
        public double RM;
        public String curso;

        public void listarAluno(double RM, String curso)
        {
            Console.WriteLine("RM: " + RM);
            Console.WriteLine("Curso: " + curso);
        }

        public void matricularDisciplina()
        {
            Console.WriteLine("Em qual disciplina você quer estudar?");
            String disciplina = Console.ReadLine();
            Console.WriteLine("O aluno foi cadastrado na disciplina de " + disciplina);
        }
    }
}