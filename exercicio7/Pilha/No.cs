public class No
    {
        public int Elemento { get; set; }
        public No Proximo { get; set; }

        public No(int elemento)
        {
            Elemento = elemento;
            Proximo = null;
        }
    }