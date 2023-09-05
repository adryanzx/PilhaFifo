using System;

namespace PilhaFIFO
{
    class Program
    {
        static void Main(string[] args)
        {
            PilhaEncadeada pilhaInicial = new PilhaEncadeada();
            pilhaInicial.Push('I');
            pilhaInicial.Push('U');
            pilhaInicial.Push('A');
            pilhaInicial.Push('M');
            pilhaInicial.Push('O');
            pilhaInicial.Push('P');
            pilhaInicial.Push('R');
            pilhaInicial.Push('I');
            pilhaInicial.Push('G');
            pilhaInicial.Push('R');
            pilhaInicial.Push('A');
            pilhaInicial.Push('M');
            pilhaInicial.Push('A');
            pilhaInicial.Push('R');

            Console.WriteLine("Pilha Inicial: ");
            pilhaInicial.Imprimir();

            PilhaEncadeada pilhaFinal = Inverterordem(pilhaInicial);

            Console.WriteLine("Pilha Final: ");
            pilhaFinal.Imprimir();
        }

        public static PilhaEncadeada Inverterordem(PilhaEncadeada pilha)
        {
            PilhaEncadeada pilhaInvertida = new PilhaEncadeada();

            while (!pilha.EstaVazia())
            {
                char letra = pilha.Pop();
                pilhaInvertida.Push(letra);
            }

            return pilhaInvertida;
        }
    }
}
