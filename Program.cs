using System;

namespace mediaTrimestral
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa cálculo de médias trimestrais.");
            Console.WriteLine("Digite a nota entre 0 e 10 do 1º trimestre");
            double nt1 = double.Parse(Console.ReadLine())*3.0;
            Console.WriteLine("Digite a nota entre 0 e 10 do 2º trimestre");
            double nt2 = double.Parse(Console.ReadLine()) * 3.5;
            Console.WriteLine("Digite a nota entre 0 e 10 do 3º trimestre");
            double nt3 = double.Parse(Console.ReadLine()) * 3.5;

            double media = nt1 + nt2 + nt3;

            if ( media >= 60)
            {
                Console.WriteLine("Aluno aprovado");

            }else
            {
                Console.WriteLine("O aluno não está aprovado.");
                double pontosFaltando = 100 - media;

                Console.WriteLine($"\n Estão faltando: {pontosFaltando} Pontos");

            }

            Console.WriteLine(media);

        }
    }
}
