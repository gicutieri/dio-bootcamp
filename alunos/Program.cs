using System;

namespace alunos
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            var indice = 0;
            string op = Opcao();

            while(op.ToUpper() != "X"){
                switch (op){
                    case "1": //inserir aluno
                        Console.WriteLine("Insira o nome do aluno: ");
                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine("Insira a nota do aluno: ");
                        if(decimal.TryParse(Console.ReadLine(), out decimal nota)){
                            aluno.Nota = nota;
                        } else {
                            throw new ArgumentException("o valor deve ser decimal");
                        }

                        alunos[indice] = aluno;
                        indice++;
                        
                        break;

                    case "2": //listar alunos
                        foreach (var a in alunos){
                            if(!string.IsNullOrEmpty(a.Nome)){
                                Console.WriteLine($"ALUNO: {a.Nome} - NOTA: {a.Nota}");
                            }
                        }

                        break;

                    case "3": //calcular media
                        decimal total = 0;
                        var n = 0;

                        foreach (var a in alunos){
                            if (!string.IsNullOrEmpty(a.Nome)){
                                total = total + a.Nota;
                                n++;
                            }
                        }
                        
                        var media = total/n;
                        Console.WriteLine($"MEDIA: {media}");

                        Conceito conceito;
                        if(media<2){
                            conceito = Conceito.F;
                        } else if(media<4){
                            conceito = Conceito.D;
                        } else if(media<6){
                            conceito = Conceito.C;
                        } else if(media<8){
                            conceito = Conceito.B;
                        } else {
                            conceito = Conceito.A;
                        }
                        Console.WriteLine($"CONCEITO: {conceito}");

                        break;

                    default:
                        throw new ArgumentOutOfRangeException();

                }

                op = Opcao();
            }

            static string Opcao(){
                Console.WriteLine("Informe a opção desejada:");
                Console.WriteLine("1 - inserir aluno");
                Console.WriteLine("2 - listar alunos");
                Console.WriteLine("3 - calcular média geral");
                Console.WriteLine("X - sair");
                Console.WriteLine();

                string op = Console.ReadLine();
                return op;
            }
        }
    }
}