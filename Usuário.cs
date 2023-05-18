namespace Projeto_Produtos
{
    public class Usuario
    {
        private int Codigo { get; set; }

        private string Nome { get; set; }

        private string Email { get; set; }

        private string Senha { get; set; }

        private DateTime DataCadastro { get; set; }

        public Usuario ()
        {
            Cadastrar();
        }

        public void Cadastrar()
        {
            Console.WriteLine($"Insira seu nome :");
            this.Nome = Console.ReadLine();
            
            Console.WriteLine($"Insira seu email : ");
            this.Email = Console.ReadLine();
            
            Console.WriteLine($"Insira sua senha : ");
            this.Senha = Console.ReadLine();
            
            this.DataCadastro = DateTime.Now;

        }
        
        public void Deletar()
        {
            this.Nome = "";
            this.Email = "";
            this.Nome = "";
            this.DataCadastro = DateTime.Parse("0000-00-00T00:00:00");
        }
    }
}