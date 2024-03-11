using System;

namespace mediaTrimestral
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa cálculo de médias trimestrais.");
            Console.WriteLine("Digite a nota entre 0 e 10 do 1º trimestre");
            double nt1 = double.Parse(Console.ReadLine()) * 3.0;
            Console.WriteLine("Digite a nota entre 0 e 10 do 2º trimestre");
            double nt2 = double.Parse(Console.ReadLine()) * 3.5;
            Console.WriteLine("Digite a nota entre 0 e 10 do 3º trimestre");
            double nt3 = double.Parse(Console.ReadLine()) * 3.5;

            Calculadora notas = new Calculadora();

            notas.nt1 = nt1;
            notas.nt2 = nt2;
            notas.nt3 = nt3;

            double media = notas.CalcularMedia();

            Console.WriteLine($"Média: {media:f2}");

            if (media >= 60)
            {
                Console.WriteLine("Aluno aprovado");
            }
            else
            {
                Console.WriteLine("O aluno não está aprovado.");
                double pontosFaltando = 100 - media;

                Console.WriteLine($"\nEstão faltando: {pontosFaltando:f2} Pontos");
            }
            Console.WriteLine($" A média final do aluno foi de: {media:f2}");

        }
    }
}
