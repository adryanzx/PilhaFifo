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
            pilha.Push(new Documento("Programacao Avancada", ".pdf", 123));
            pilha.Push(new Documento("matematica discreta", ".word", 129));

            Console.WriteLine("Documentos na Pilha: ");
            pilha.Imprimir();

            int quantelementos = pilha.ContarElementos();
            Console.WriteLine($"A pilha possui {quantelementos} elementos");


        
        }
    }
}
