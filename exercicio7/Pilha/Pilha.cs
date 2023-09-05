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

        public void Push(int elemento)
        {
            No novoNo = new No(elemento);

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

        public int Pop()
        {
            if (EstaVazia())
            {
                Console.WriteLine("Pilha vazia");
                return 0; 
            }

            No noremov = Topo;

            Topo = Topo.Proximo;

            return noremov.Elemento;
        }

        public void Imprimir()
        {
            No noAtual = Topo;

            while (noAtual != null)
            {
                Console.Write(noAtual.Elemento);
                noAtual = noAtual.Proximo;
            }
            Console.WriteLine();
        }
    }
