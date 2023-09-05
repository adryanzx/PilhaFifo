public class No
    {
        public int Numero { get; set; }
        public No Proximo { get; set; }

        public No(int numero)
        {
            Numero = numero;
            Proximo = null;
        }
    }
