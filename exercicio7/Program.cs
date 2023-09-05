using System;

namespace PilhaFIFO
{
    class Program
    {
        static void Main(string[] args)
        {
            PilhaEncadeada pilha1 = new PilhaEncadeada();
            pilha1.Push(1);
            pilha1.Push(2);
            pilha1.Push(5);
            pilha1.Push(7);
            pilha1.Push(10);

            Console.WriteLine("Pilha1: ");
            pilha1.Imprimir();

            PilhaEncadeada pilha2 = new PilhaEncadeada();

            transferirpilha(pilha1, pilha2);

            Console.WriteLine("Pilha2: ");
            pilha2.Imprimir();
        }

        public static void transferirpilha(PilhaEncadeada pilhaorigem, PilhaEncadeada pilhadest)
        {
            PilhaEncadeada pilhaTemporaria = new PilhaEncadeada();

            
            while (!pilhaorigem.EstaVazia())
            {
                int elemento = pilhaorigem.Pop();
                pilhaTemporaria.Push(elemento);
            }

            
            while (!pilhaTemporaria.EstaVazia())
            {
                int elemento = pilhaTemporaria.Pop();
                pilhadest.Push(elemento);
            }
        }
    }
}
