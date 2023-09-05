 public class No
    {
        public Documento Data { get; set; }
        public No Proximo { get; set; }

        public No(Documento data)
        {
            Data = data;
            Proximo = null;
        }
    }