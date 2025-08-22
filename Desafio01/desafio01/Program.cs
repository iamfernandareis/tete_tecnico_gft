using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite a primeira palavra:");
        string palavra1 = Console.ReadLine().ToLower().Replace(" ", "");

        Console.WriteLine("Digite a segunda palavra:");
        string palavra2 = Console.ReadLine().ToLower().Replace(" ", "");

        char[] letras1 = palavra1.ToCharArray();
        char[] letras2 = palavra2.ToCharArray();

        Array.Sort(letras1);
        Array.Sort(letras2);

        string ordenada1 = new string(letras1);
        string ordenada2 = new string(letras2);

        if (ordenada1 == ordenada2)
        {
            Console.WriteLine("Resultado: As palavras são anagramas!");
        }
        else
        {
            Console.WriteLine("Resultado: As palavras NÃO são anagramas.");
        }
    }
}
