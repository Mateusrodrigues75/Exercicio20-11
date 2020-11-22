using System;

namespace Exercicio20_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculando a Média de 10 Alunos");
            Console.WriteLine("--------------------------------");

            string[] nomes = new string[10];
            
            float[] notas1 = new float [10];
            float[] notas2 = new float [10];
            float[] notas3 = new float [10];
            float[] notas4 = new float [10];

            int aprovados = 0;
            int reprovados = 0;

            float[] media = new float [10];
            float mediaGeral;


            float soma = 0;

            for(var cont = 0; cont < nomes.Length; cont++){
                Console.Write("Digite o nome do aluno: ");
                nomes[cont] = Console.ReadLine();
                
                Console.Write("Digite a nota 1: ");
                notas1[cont] = float.Parse(Console.ReadLine());
                
                Console.Write("Digite a nota 2: ");
                notas2[cont] = float.Parse(Console.ReadLine());
                
                Console.Write("Digite a nota 3: ");
                notas3[cont] = float.Parse(Console.ReadLine());
                
                Console.Write("Digite a nota 4: ");
                notas4[cont] = float.Parse(Console.ReadLine());

                media[cont] = (notas1[cont] + notas2[cont] + notas3[cont] + notas4[cont])/4;

                Console.WriteLine($"A media do aluno(a) {nomes[cont]} é {media[cont]}.");
                if (media[cont] >= 7){
                    aprovados = aprovados + 1;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{nomes[cont]} está APROVADO(A)!");
                    Console.ResetColor();                    
                }else{
                    reprovados = reprovados + 1;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{nomes[cont]} está REPROVADO(A)!");
                    Console.ResetColor();
                }
                Console.WriteLine("--------------------------------------");
            }

            Console.WriteLine($"o total de alunos Aprovados :{aprovados}");
            Console.WriteLine($"o total de alunos Reprovados :{reprovados}");
            

            for (var i = 0; i < media.Length; i++){
                soma += media[i]; 
            }

            mediaGeral = soma/10;

            Console.WriteLine($"A média geral da sala é {mediaGeral}");

            

            
        
        }
    }
}
