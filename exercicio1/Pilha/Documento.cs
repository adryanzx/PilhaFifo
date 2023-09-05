public class Documento
    {
        public string nomearquivo { get; set; }
         public int tamarquivo { get; set; }

        public string extensaoarquivo { get; set; }
       

        public Documento(string nome, string extensao, int tamanho)
        {
            nomearquivo = nome;
            extensaoarquivo = extensao;
            tamarquivo = tamanho;
        }

        
        public override string ToString()
        {
            return $"{nomearquivo}{extensaoarquivo} ({tamarquivo} KB)";
        }
    }