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

            Console.WriteLine($"INFORME O NOME DE USUARIO:");
            this.Nome = Console.ReadLine();

            Console.WriteLine($"INFORME O E-MAIL:");
            this.Email = Console.ReadLine();

            Console.WriteLine($"INFORME A SENHA:");
            this.Senha = Console.ReadLine();

            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine($"Informacoes salvas!");
            Console.ResetColor();
            
            

        }

          public void Logar(bool logado)
        {
            do
            {
            Console.WriteLine($"LOGIN:");
            Console.WriteLine($"Informe o email cadastrado:");
            string email = Console.ReadLine();
            Console.WriteLine($"Informe a senha:");
            string senha = Console.ReadLine();
            if (email == Email && senha == Senha)
            {
               logado = true;
               
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Email ou senha invalido");
                Console.ResetColor();
                
            }
            } while (logado != true);
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