using System;
namespace Exercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            string opcaoUsuario = ObterOpcaoUsusario();
            var IndiceAluno = 0;

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        Console.WriteLine("Informe o nome do aluno: ");
                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();


                        Console.WriteLine("Informe a nota do aluno:");

                        if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            aluno.Nota = nota;
                        }
                        else
                        {
                            throw new ArgumentException("O valor da nota deve ser decimal!");
                        }

                        alunos[IndiceAluno] = aluno;
                        IndiceAluno++;

                        break;


                    case "2":
                        foreach (var a in alunos)
                        {
                            if (!string.IsNullOrEmpty(a.Nome))
                                Console.WriteLine($"ALUNO: {a.Nome} - NOTA: {a.Nota}");
                        }
                        break;

                    case "3":
                        decimal notaTotal = 0;
                        var numAlunos = 0;

                        for (int i = 0; i < alunos.Length; i++)
                        {
                            if (!string.IsNullOrEmpty(alunos[i].Nome))
                            {
                                notaTotal = notaTotal + alunos[i].Nota;
                                numAlunos++;
                            }
                        }

                        var mediaGeral = notaTotal / numAlunos;
                        EConceito conceitoGeral;

                        if (mediaGeral < 2)
                        {
                            conceitoGeral = EConceito.E;
                        }
                        if (mediaGeral < 4)
                        {
                            conceitoGeral = EConceito.E;
                        }
                        if (mediaGeral < 6)
                        {
                            conceitoGeral = EConceito.E;
                        }
                        if (mediaGeral < 8)
                        {
                            conceitoGeral = EConceito.E;
                        }
                        else
                        {
                            conceitoGeral = EConceito.A;
                        }

                        Console.WriteLine($"MEDIA GERAL : {mediaGeral} - CONCEITO : {conceitoGeral}");

                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = ObterOpcaoUsusario();

            }
        }

        private static string ObterOpcaoUsusario()
        {
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1- Inserir novo aluno");
            Console.WriteLine("2- Listar alunos");
            Console.WriteLine("3- Calcular média geral");
            Console.WriteLine("X- Sair ");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}