using System;

namespace PilhaFIFO
{
    class Program
    {
        static void Main(string[] args)
        {
            PilhaEncadeada pilha1 = new PilhaEncadeada();
            pilha1.Push('R');
            pilha1.Push('I');
            pilha1.Push('D');
            pilha1.Push('I');
            pilha1.Push('R');
            

            Console.WriteLine("Pilha: ");
            pilha1.Imprimir();

            bool ehPalindromo = verificarpalindromo(pilha1);

            if (ehPalindromo)
            {
                Console.WriteLine("É PALÍNDROMO!!");
            }
            else
            {
                Console.WriteLine("NÃO É PALÍNDROMO!!");
            }
        }

        public static bool verificarpalindromo(PilhaEncadeada pilha)
        {
            PilhaEncadeada pilhaInvertida = new PilhaEncadeada();

            
            while (!pilha.EstaVazia())

            {
                char letra = pilha.Pop();
                pilhaInvertida.Push(letra);
            }

            
            while (!pilha.EstaVazia() && !pilhaInvertida.EstaVazia())

            {
                char letraOriginal = pilha.Pop();
                char letraInvertida = pilhaInvertida.Pop();


                if (letraOriginal != letraInvertida)

                {
                    return false;
                }
            }

            return pilha.EstaVazia() && pilhaInvertida.EstaVazia();
        }
    }
}