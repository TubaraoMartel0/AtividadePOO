using ConsoleApp2;

Console.WriteLine("Você é aluno ou professor??");
String escolaridade = Console.ReadLine();

PessoaFisica pessoa = new PessoaFisica();
Console.WriteLine("Insira o nome: ");
pessoa.nome = Console.ReadLine();
Console.WriteLine("Insira a idade: ");
pessoa.idade = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Insira o CPF");
pessoa.cpf = Console.ReadLine();

// Console.WriteLine("-------------------");

if (escolaridade == "professor" || escolaridade == "Professor")
{
    Professor prof = new Professor();
    Console.WriteLine("Insira a formação:");
    prof.formacao = Console.ReadLine();
    Console.WriteLine("Insira o cargo:");
    prof.cargo = Console.ReadLine();
    Console.WriteLine("Insira seu salario:");
    prof.salario = Convert.ToDouble(Console.ReadLine());
    prof.listarDados(pessoa.nome, pessoa.idade, pessoa.cpf);
    prof.listarProfessor(prof.formacao, prof.cargo, prof.salario);
}
else if (escolaridade == "aluno" || escolaridade == "Aluno")
{
    Aluno aluno = new Aluno();
    Console.WriteLine("Insira o RM");
    aluno.RM = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Insira o seu curso:");
    aluno.curso = Console.ReadLine();
    aluno.listarDados(pessoa.nome, pessoa.idade, pessoa.cpf);
    aluno.listarAluno(aluno.RM, aluno.curso);
}