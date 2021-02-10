using System;

namespace DesafioCalculoViagem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double tempo = Double.Parse(Console.ReadLine());
            double velocidade = Double.Parse(Console.ReadLine());

            double litros = (tempo * velocidade) / 12;

            Console.WriteLine(litros.ToString("F3"));
        }
    }
}
