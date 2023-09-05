public class PilhaEncadeada
    {
        private No Topo { get; set; }

        public PilhaEncadeada()
        {
            Topo = null;
        }

        public bool EstaVazia()
        {
            return Topo == null;
        }

        public void Push(char letra)
        {
            No novoNo = new No(letra);

            if (EstaVazia())
            {
                Topo = novoNo;
            }
            else
            {
                novoNo.Proximo = Topo;
                Topo = novoNo;
            }
        }

        public char Pop()
        {
            if (EstaVazia())
            {
                Console.WriteLine("Pilha vazia!");
                return '\0'; 
            }

            No noremov = Topo;

            Topo = Topo.Proximo;

            return noremov.Letra;
        }

        public void Imprimir()
        {
            No noAtual = Topo;

            while (noAtual != null)
            {
                Console.Write(noAtual.Letra);
                noAtual = noAtual.Proximo;
            }
            Console.WriteLine();
        }
    }
