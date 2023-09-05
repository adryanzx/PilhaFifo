 public class SeparacaoNumeros
    {
        public PilhaEncadeada PilhaPositivos { get; set; }
        public PilhaEncadeada PilhaNegativos { get; set; }

        public SeparacaoNumeros()
        {
            PilhaPositivos = new PilhaEncadeada();
            PilhaNegativos = new PilhaEncadeada();
        }
    }