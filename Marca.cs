namespace Projeto_Produtos
{
    public  class Marca
    {
        private int Codigo { get; set; }

        private string NomeMarca { get; set; }

        private DateTime DataCadastro = DateTime.Now ;

        List<Marca> listaDeMarcas = new List<Marca>();

        public Marca()
        {
            Cadastrar();
        }
        
         public void Cadastrar()

        {
            Marca _marca = new Marca();

            Console.WriteLine($"qual o codigo do produto: ");                 
            _marca.Codigo = int.Parse (Console.ReadLine());

            Console.WriteLine($"qual a marca do produto: ");
           _marca.NomeMarca = Console.ReadLine();

            listaDeMarcas.Add(_marca);
            
        }


        public void Listar()
        {
            foreach (var item in listaDeMarcas)
            {
                Console.WriteLine($"PRODUTOS CADASTRADOS");
                Console.WriteLine();
                
                Console.WriteLine($"Codigo do produto: {item.Codigo}");
                Console.WriteLine($"Codigo do produto: {item.NomeMarca}");
                
            }
        }


        public void Deletar()
        {
            this.NomeMarca = "";
            this.DataCadastro = DateTime.Parse("0000-00-00T00:00:00");
        }
       
    
    }
}