using System;
using System.Globalization;
using ExercicioUm.Um.Class;

namespace ExercicioUm.Um
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona x = new Persona();
    	    Persona y = new Persona();

    	    Console.WriteLine("Insira o nome da Primeira Pessoa: ");
            x.Nome = Console.ReadLine();
            Console.WriteLine("Insira a idade da primeira pessoa: ");
            x.Idade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Insira o nome da Segunda Pessoa: ");
            y.Nome = Console.ReadLine();
            Console.WriteLine("Insira a idade da Segunda pessoa: ");
            y.Idade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if(x.Idade > y.Idade)
            {
                Console.WriteLine($"A pessoa mais velha é {x.Nome}, com {x.Idade}");
            }
            else
            {
                Console.WriteLine($"A pessoa mais velha é {y.Nome}, com {y.Idade}"); 
            }
            Console.ReadLine();
            
        }
    }

}
