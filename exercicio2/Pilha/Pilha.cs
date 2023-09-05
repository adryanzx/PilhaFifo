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


        public int contarnums()
        {
            No noAtual = Topo;
            int count = 0;

            while (noAtual != null)
            {
                if (noAtual.Data is Documento doc && doc.tamarquivo % 2 != 0)
                {
                    count++;
                }
                noAtual = noAtual.Proximo;
            }

            return count;
        }

        public int ContarElementos()
        {
            No noAtual = Topo;
            int count = 0;

            while (noAtual != null)
            {
                count++;
                noAtual = noAtual.Proximo;
            }

            return count;
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