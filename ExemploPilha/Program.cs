using System;

namespace ExemploPilha
{
    class Program
    {
        static void Main(string[] args)
        {
            Pilha s = new Pilha();
            s.Empilha(1);
            s.Empilha(10);
            s.Empilha(1000);
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
        }
    }
}
