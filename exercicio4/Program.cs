using System;

namespace PilhaFIFO
{
    class Program
    {
        static void Main(string[] args)
        {
            PilhaEncadeada pilha1 = new PilhaEncadeada();
            pilha1.Push(-23);
            pilha1.Push(51);
            pilha1.Push(-15);
            pilha1.Push(7);
            pilha1.Push(-2);
            pilha1.Push(1);

            Console.WriteLine("Pilha1: ");
            pilha1.Imprimir();

            var resultado = SepararNumeros(pilha1);

            Console.WriteLine("Pilha2 (Números Positivos): ");
            resultado.PilhaPositivos.Imprimir();

            Console.WriteLine("Pilha3 (Números Negativos): ");
            resultado.PilhaNegativos.Imprimir();
        }

        public static SeparacaoNumeros SepararNumeros(PilhaEncadeada pilha)
        {
            SeparacaoNumeros resultado = new SeparacaoNumeros();

            while (!pilha.EstaVazia())
            {
                int numero = pilha.Pop();

                if (numero >= 0)
                {
                    resultado.PilhaPositivos.Push(numero);
                }
                else
                {
                    resultado.PilhaNegativos.Push(numero);
                }
            }

            return resultado;
        }
    }
    }
