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

        public void Push(Documento documento)
        {
            No novoNo = new No(documento);

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

        public Documento Pop()
        {
            if (EstaVazia())
            {
                Console.WriteLine("pilha está vazia");
                return null;
            }

            No noremov = Topo;

            Topo = Topo.Proximo;

            return noremov.Data;
        }

        public bool Consulta(Documento documento)
        {
            No noAtual = Topo;

            while (noAtual != null)
            {
                if (noAtual.Data.Equals(documento))

                {
                    return true;

                }
                noAtual = noAtual.Proximo;
            }

            return false;
        }

        public void Imprimir()
        {

            No noAtual = Topo;


            while (noAtual != null)
            {
                Console.WriteLine(noAtual.Data.ToString());
                noAtual = noAtual.Proximo;
            }
        }
    }
