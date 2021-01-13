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
                        Console.WriteLine();
                        Console.WriteLine("Insira o nome do aluno: ");
                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine();
                        Console.WriteLine("Numero de disciplinas: ");
                        int materias = Convert.ToInt32(Console.ReadLine());
                        aluno.Notas = new DisciplinasDoAluno[materias];

                        Console.WriteLine();
                        Console.WriteLine("Insira as notas: ");
                        Console.WriteLine("-----------------");

                        for (int i=0; i<materias; i++){
                            Console.WriteLine("Disciplina: ");
                            aluno.Notas[i].Disciplina = Console.ReadLine();

                            Console.WriteLine("Nota: ");
                            if(decimal.TryParse(Console.ReadLine(), out decimal nota)){
                                aluno.Notas[i].Nota = nota;
                            } else {
                                throw new ArgumentException("o valor deve ser decimal");
                            }

                            Console.WriteLine("-----------------");
                        }
                        Console.WriteLine();

                        alunos[indice] = aluno;
                        indice++;
                        
                        break;

                    case "2": //listar alunos
                        foreach (var a in alunos){
                            Console.WriteLine();
                            if(!string.IsNullOrEmpty(a.Nome)){
                                Console.WriteLine($"ALUNO: {a.Nome}");

                                foreach (var b in a.Notas){
                                    Console.WriteLine($"DISCIPLINA: {b.Disciplina} - NOTA: {b.Nota}");
                                }
                            }
                        }

                        break;

                    case "3": //calcular media do aluno
                        Console.WriteLine();
                        Console.WriteLine("Insira o nome do aluno: ");
                        string nome = Console.ReadLine();
                        Console.WriteLine();

                        decimal total = 0;
                        var n = 0;
                        var flag = 0;

                        foreach (var a in alunos){
                            if ((!string.IsNullOrEmpty(a.Nome)) && (string.Compare(a.Nome, nome)==0)){
                                flag = 1;
                                foreach (var b in a.Notas){
                                    total = total + b.Nota;
                                    n++;
                                }
                            }
                        }

                        if(flag == 0){
                            Console.WriteLine("aluno nao encontrado");
                        } else {
                        
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

                            if(media>=6){
                                Console.WriteLine();
                                Console.WriteLine("aluno aprovado");
                            }

                        }

                        break;

                    case "4": //calcular media geral
                        Console.WriteLine();
                        
                        decimal mediaAluno = 0;
                        decimal totalAluno = 0;
                        var nAluno = 0;

                        decimal totalGeral = 0;
                        var nGeral = 0;

                        foreach (var a in alunos){
                            if (!string.IsNullOrEmpty(a.Nome)){
                                totalAluno = 0;
                                nAluno = 0;
                                foreach (var b in a.Notas){
                                    totalAluno = totalAluno + b.Nota;
                                    nAluno++;
                                }
                                mediaAluno = totalAluno/nAluno;
                                totalGeral = totalGeral + mediaAluno;
                                nGeral++;
                            }
                        }
                        
                        var mediaGeral = totalGeral/nGeral;
                        Console.WriteLine($"MEDIA: {mediaGeral}");

                        Conceito conceitoGeral;
                        if(mediaGeral<2){
                            conceitoGeral = Conceito.F;
                        } else if(mediaGeral<4){
                            conceitoGeral = Conceito.D;
                        } else if(mediaGeral<6){
                            conceitoGeral = Conceito.C;
                        } else if(mediaGeral<8){
                            conceitoGeral = Conceito.B;
                        } else {
                            conceitoGeral = Conceito.A;
                        }
                        Console.WriteLine($"CONCEITO: {conceitoGeral}");

                        break;

                    default:
                        throw new ArgumentOutOfRangeException();

                }

                op = Opcao();
            }

            static string Opcao(){
                Console.WriteLine();
                Console.WriteLine("Informe a opção desejada:");
                Console.WriteLine("1 - inserir aluno");
                Console.WriteLine("2 - listar alunos");
                Console.WriteLine("3 - calcular media do aluno");
                Console.WriteLine("4 - calcular média geral");
                Console.WriteLine("X - sair");
                Console.WriteLine();

                string op = Console.ReadLine();
                return op;
            }
        }
    }
}