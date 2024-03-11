using System;

namespace mediaTrimestral
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa cálculo de médias trimestrais.");
            Console.WriteLine("Digite a nota entre 0 e 10 do 1º trimestre");
            double notaPrimeiroTrimestre = double.Parse(Console.ReadLine()) * 3.0;
            Console.WriteLine("Digite a nota entre 0 e 10 do 2º trimestre");
            double notaSegundoTrimestre = double.Parse(Console.ReadLine()) * 3.5;
            Console.WriteLine("Digite a nota entre 0 e 10 do 3º trimestre");
            double notaTerceiroTrimestre = double.Parse(Console.ReadLine()) * 3.5;

            Calculadora notas = new Calculadora();

            notas.nota1= notaPrimeiroTrimestre;
            notas.nota2= notaSegundoTrimestre;
            notas.nota3= notaTerceiroTrimestre;

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
