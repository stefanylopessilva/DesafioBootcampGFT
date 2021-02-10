using System;
using System.Linq;

namespace DesafioAlbumCopa
{
    public class Program
    {

        public static void Main(string[] args)
        {
            int numeroDeFigurinhas = Int32.Parse(Console.ReadLine());
            int numeroDeFigurinhasCompradas = Int32.Parse(Console.ReadLine());
            int totalDeFigurinhas = 0;

            int[] albumDeFigurinha = new int[100];

            for (int i = 0; i < numeroDeFigurinhasCompradas; i++)
            {
                int descricaoDeFigurinhasCompradas = Int32.Parse(Console.ReadLine());
                albumDeFigurinha[i] = descricaoDeFigurinhasCompradas;
            }

            int[] figurinhaSemRepetidas = albumDeFigurinha.Distinct().Where(x => x != 0).ToArray();

            totalDeFigurinhas = numeroDeFigurinhas - figurinhaSemRepetidas.Length;

            Console.WriteLine(totalDeFigurinhas);
        }
    }
}
