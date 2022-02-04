// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroDeVezes = 10;

            for(int i=0; i < numeroDeVezes; i++)
            {
                Console.WriteLine($"Bem-vindo ao curso de .NET {i}");
            }
            
        }
    }
}
