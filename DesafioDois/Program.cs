using System;

namespace DesafioDois
{
    class Program
    {
        static void Main()
        {
            Console.Clear();

            Console.WriteLine("Para sair do programa, segure as teclas CTRL + C.");
            Console.Write("Escreva qualquer palavra ou texto para contagem de letras A: ");

            string texto = Console.ReadLine();
            int quantidade = ContarLetraA(texto);

            Console.WriteLine($"A letra 'a' aparece {quantidade} vezes na string.");

            Console.ReadKey();
            Main();
        }

        static int ContarLetraA(string texto)
        {
            int contador = 0;
            foreach (char c in texto)
            {
                if (char.ToLower(c) == 'a')
                {
                    contador++;
                }
            }
            return contador;
        }
    }
}


