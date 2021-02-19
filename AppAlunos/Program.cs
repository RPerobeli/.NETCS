using System;

namespace AppAlunos
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcaoUser = ObterOpcao();
            Aluno[] alunos = new Aluno[5];
            int indiceAluno = 0;

            while(opcaoUser.ToUpper() != "X")
            {
                switch(opcaoUser)
                {
                    case "1":
                        InserirAluno(alunos, indiceAluno);
                        indiceAluno++;
                        break;
                    case "2":
                        ListarAlunos(alunos);
                        break;
                    case "3": 
                        var media = CalcularMedia(alunos);
                        Console.WriteLine($"A media dos alunos e: {media}");
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                        break;
                }
                opcaoUser = ObterOpcao();
            }

        }
        private static string ObterOpcao()
        {
            Console.WriteLine();
            Console.WriteLine("Informe a opcao desejada:");
            Console.WriteLine("1- Inserir novo aluno.");
            Console.WriteLine("2- Listar alunos");
            Console.WriteLine("3- Calcular media geral.");
            Console.WriteLine("X- Sair.");
            Console.WriteLine();

            string op = Console.ReadLine();
            return op;

        }
        private static void InserirAluno(Aluno[] arrayAlunos, int indiceAluno)
        {
            Console.WriteLine("Digite o nome do aluno:");
            Aluno aluno = new Aluno();
            aluno.nome = Console.ReadLine();
            Console.WriteLine("Informe a nota do aluno");
            if(decimal.TryParse(Console.ReadLine(), out decimal nota))
            {
                aluno.nota = nota;
            }
            else
            {
                throw new ArgumentException("O valor da nota deve ser decimal");
            }
            arrayAlunos[indiceAluno] = aluno;
            Console.WriteLine("Aluno Inserido");
        }
        private static void ListarAlunos(Aluno[] arrayAlunos)
        {
            foreach(Aluno a in arrayAlunos)
            {
                if(!string.IsNullOrEmpty(a.nome))
                {
                    Console.WriteLine($"Aluno: {a.nome}, Nota: {a.nota}");
                }
            }
        }

        private static decimal CalcularMedia(Aluno[] arrayAlunos)
        {
            decimal media = 0;
            decimal soma = 0;
            int cont =0;
            foreach(Aluno a in arrayAlunos)
            {
                if(!string.IsNullOrEmpty(a.nome))
                {
                    soma += a.nota;
                    cont++;                    
                }
            }
            media = soma/cont;
            return media;
        }
    }
}
