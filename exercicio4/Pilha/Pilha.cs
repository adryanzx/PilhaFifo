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

        public void Push(int numero)
        {
            No novoNo = new No(numero);

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
                Console.WriteLine("Pilha está vazia");
                return 0; // Você pode ajustar o valor de retorno conforme necessário
            }

            No noremov = Topo;

            Topo = Topo.Proximo;

            return noremov.Numero;
        }

        public void Imprimir()
        {
            No noAtual = Topo;

            while (noAtual != null)
            {
                Console.Write(noAtual.Numero + " ");
                noAtual = noAtual.Proximo;
            }
            Console.WriteLine();
        }
    }