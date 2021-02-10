using System;
using System.Text;

namespace DesafioAnimal
{
    public class Program
    {
        public static void Main(string[] args)
        {
            String colunaVertebral;
            String classeAnimal;
            String alimentacao;

            colunaVertebral = Console.ReadLine();
            classeAnimal = Console.ReadLine();
            alimentacao = Console.ReadLine();

            if ((colunaVertebral == "vertebrado") && (classeAnimal == "ave") && (alimentacao == "carnivoro"))
            {
                Console.WriteLine("aguia\n");
            }

            if ((colunaVertebral == "vertebrado") && (classeAnimal == "ave") && (alimentacao == "onivoro"))
            {
                Console.WriteLine("pomba\n");
            }

            if ((colunaVertebral == "vertebrado") && (classeAnimal == "mamifero") && (alimentacao == "onivoro"))
            {
                Console.WriteLine("homem\n");
            }

            if ((colunaVertebral == "vertebrado") && (classeAnimal == "mamifero") && (alimentacao == "herbivoro"))
            {
                Console.WriteLine("vaca\n");
            }

            if ((colunaVertebral == "invertebrado") && (classeAnimal == "inseto") && (alimentacao == "hematofago"))
            {
                Console.WriteLine("pulga\n");
            }

            if ((colunaVertebral == "invertebrado") && (classeAnimal == "inseto") && (alimentacao == "herbivoro"))
            {
                Console.WriteLine("lagarta\n");
            }

            if ((colunaVertebral == "invertebrado") && (classeAnimal == "anelideo") && (alimentacao == "hematofago"))
            {
                Console.WriteLine("sanguessuga\n");
            }

            if ((colunaVertebral == "invertebrado") && (classeAnimal == "anelideo") && (alimentacao == "onivoro"))
            {
                Console.WriteLine("minhoca\n");
            }
        }
    }
}
