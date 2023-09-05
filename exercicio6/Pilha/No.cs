public class No
    {
        public char Letra { get; set; }
        public No Proximo { get; set; }

        public No(char letra)
        {
            Letra = letra;
            Proximo = null;
        }
    }