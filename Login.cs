namespace Projeto_Produtos
{
    public class Login
    {
        public bool logado { get; set; }


        static void BarraCarregamento(string texto, int quantidadePontinhos, int tempo)
        {
            Console.Write(texto);

            for (var i = 0; i < quantidadePontinhos; i++)
            {
                Console.Write($".");
                Thread.Sleep(tempo);
            }
        }

        public Login()
        {
            Usuario user = new Usuario();
            
            // user.Cadastrar();
            user.Logar(logado);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine($"LOGIN EFETUADO!");
            BarraCarregamento("ENTRANDO", 6, 400);
            Console.ResetColor();
            
            GerarMenu();
        }


        public void  GerarMenu()
        {
            Produto _produto = new Produto();
            Marca _marca = new Marca();
            int opcao;

            do
            {

                Console.WriteLine(@$"
           ======================================
                      MENU DE OPÇOES 
                Escolha a opçao desejada:

            [1] - CADASTRAR PRODUTO
            [2] - LISTAR PRODUTOS
            [3] - CADASTRAR MARCA
            [4] - LISTAR MARCAS
            [5] - REMOVER UM PRODUTO
            [6] - REMOVER UMA MARCA

            [0] - SAIR DO SISTEMA

           ====================================== 
            ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:

                        _produto.Cadastrar();

                        break;
                    case 2:

                        _produto.Listar();

                        break;
                    case 3:
                        _marca.Cadastrar();
                        break;
                    case 4:
                        _marca.Listar();
                        break;
                    case 5:
                        Console.WriteLine($"INFORME O CODIGO DO PRODUTO NA QUAL DESEJA REMOVER:");
                        int codigo = int.Parse(Console.ReadLine()); Console.WriteLine($"Text");
                        // produto.Deletar(codigo);
                        
                        break;
                    case 6:
                        Console.WriteLine($"INFORME O CODIGO DA MARCA NA QUAL DESEJA REMOVER:");
                        int codigos = int.Parse(Console.ReadLine());
                        // marca.Deletar(codigos);
                        break;
                    case 0:
                        
                        BarraCarregamento("SAINDO DO SISTEMA", 3, 1000);
                        break;

                    default:
                        Console.WriteLine($"OPCAO INVALIDA, ESCOLHA UMA OPCAO VALIDA!");

                        break;
                }
            } while (opcao != 0);

        }
    }
    
}