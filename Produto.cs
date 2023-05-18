namespace Projeto_Produtos
{
    public class Produto
    {
        private int Codigo { get; set; }

        private string NomeProduto { get; set; }
        
        private string Preco { get; set; }

        private string Marca { get; set; }

        private string CadastradoPor { get; set; }

        private DateTime DataCadastro = DateTime.Now ;

        List<Produto> listaDeProdutos = new List<Produto>();

        public void Cadastrar()
        {
            Produto _produto = new Produto();

            Console.WriteLine($"Insira o codigo do produto : ");
            _produto.Codigo = int.Parse (Console.ReadLine());

            Console.WriteLine($"Insira o nome do produto : ");
            _produto.NomeProduto = Console.ReadLine();
            
            Console.WriteLine($"Insira o preco do produto : ");
            _produto.Preco = Console.ReadLine();

            Console.WriteLine($"Insira a marca do produto : ");
            _produto.Marca = Console.ReadLine();

            Console.WriteLine($"Produto cadastrado pelo usuario : ");
            _produto.CadastradoPor = Console.ReadLine();
            
            listaDeProdutos.Add(_produto);
        }

        public void Listar()
        {
            foreach (var item in listaDeProdutos)
            {
                Console.WriteLine($"PRODUTOS CADASTRADOS");
                Console.WriteLine();
                
                Console.WriteLine($"Codigo do produto: {item.Codigo}");
                Console.WriteLine($"Nome do produto: {item.NomeProduto}");
                Console.WriteLine($"Preco do produto: {item.Preco}");
                Console.WriteLine($"Marca do produto: {item.Marca}");
                Console.WriteLine($"O item foi cadastrado pelo usuario: {item.CadastradoPor}");
            }
        }


        public void Deletar()
        {
            this.NomeProduto = "";
            this.Preco = "";
            this.DataCadastro = DateTime.Parse("0000-00-00T00:00:00");

        }

    }
}