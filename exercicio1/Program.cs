using System;

namespace PilhaFIFO
{
    class Program
    {
        static void Main(string[] args)
        {
            PilhaEncadeada pilha = new PilhaEncadeada();

            
            pilha.Push(new Documento("Estrutura de dados", ".php", 400));
            pilha.Push(new Documento("engenharia de software", ".txt", 200));
            pilha.Push(new Documento("projeto integrador", ".docx", 170));

            
            Console.WriteLine("Documento na Pilha: ");

            pilha.Imprimir();


            Console.WriteLine("Remover documentos da pilha:");
            pilha.Pop();
            pilha.Pop();
            pilha.Imprimir();
        }
    }

}
