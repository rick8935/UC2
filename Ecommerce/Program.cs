using System;
using System.ComponentModel.Design;

namespace Ecommerce
{

    internal class Program
    {
        const int LIMITE = 30;
        static string[] categorias = new string[LIMITE];
        static string[] fornecedores = new string[LIMITE];
        static string[] produtos = new string[LIMITE];
        static int[] produtoCategorias = new int[LIMITE];
        static int[] produtoFornecedor = new int[LIMITE];
        static int contadorCategoria = 0;
        static int contadorFornecedor = 0;
        static int contadorProduto = 0;

        static void Main(string[] args)
        {
            int opcao = 0;

            do
            {
                Console.WriteLine("BEM VINDO AO MEU ERP DE VENDAS DE CELULARES");
                separador('=', 100);
                Console.WriteLine("CADASTRO GERAL DO SISTEMA");
                Console.WriteLine("(1) - Cadastro de Categorias");
                Console.WriteLine("(2) - Cadastro de Fornecedores");
                Console.WriteLine("(3) - Cadastro de Produtos");
                Console.WriteLine("(4) - Listar Categorias");
                Console.WriteLine("(5) - Listar Fornecedores");
                Console.WriteLine("(6) - Listar Produtos");
                Console.WriteLine("(0) - Sair");
                Console.WriteLine("Digite sua opção: ");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        modulo_categoria();
                        break;
                    case 2:
                        modulo_fornecedor();
                        break;
                    case 3:
                        modulo_produto();
                        break;
                    case 4:
                        listar_categorias();
                        break;
                    case 5:
                        listar_fornecedores();
                        break;
                    case 6:
                        listar_produtos();
                        break;
                    case 0:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

            } while (opcao != 0);
        }

        static void separador(char simbolo, int quantidade)
        {
            for (int i = 0; i < quantidade; i++)
            {
                Console.Write(simbolo);
            }
            Console.Write("\n");
        }

        static void modulo_categoria()
        {
            if(contadorCategoria < 10)
            {
                Console.WriteLine("Digite o nome da nova categoria (ex: Smartphones, Acessórios, etc.): ");
                categorias[contadorCategoria] = Console.ReadLine();
                contadorCategoria++;
                Console.WriteLine("Categoria cadastrada com sucesso!");
            }
            else
            {
                Console.WriteLine("Limite de categorias atingido");
            }
        }

        static void modulo_fornecedor()
        {
            if(contadorFornecedor < 10)
            {
                Console.WriteLine("Digite o nome do fornecedor (ex: Samsung, Apple, Xiaomi): ");
                fornecedores[contadorFornecedor] = Console.ReadLine();
                contadorFornecedor++;
                Console.WriteLine("Fornecedor cadastrado com sucesso!");
            }
            else
            {
                Console.WriteLine("Limite de fornecedores atingido!");
            }
        }

        static void modulo_produto()
        {
            int categoria_escolhida = 0;
            int fornecedor_escolhido = 0;

            if(contadorProduto < 10)

            {
                Console.WriteLine("Digite o nome do produto (ex: iPhone 13, Galaxy S21): ");
                produtos[contadorProduto] = Console.ReadLine();

                Console.WriteLine("Escolha uma categoria para o produto: ");
                listar_categorias();
                Console.WriteLine("Digite o número da categoria: ");
                categoria_escolhida = int.Parse(Console.ReadLine());
                produtoCategorias[contadorProduto] = categoria_escolhida - 1;
                Console.WriteLine("Escolha um fornecedor para o produto: ");
                listar_fornecedores();
                Console.WriteLine("Digite o número do fornecedor: ");
                fornecedor_escolhido = int.Parse(Console.ReadLine());
                produtoFornecedor[contadorProduto] = fornecedor_escolhido - 1;

                contadorProduto++;
                Console.WriteLine("Produto cadastrado com sucesso!");
            }
            else
            {
                Console.WriteLine("Limite de produtos atingido!");
            }
        }

        static void listar_categorias()
        {

            if(contadorCategoria > 0)
            {
                    Console.WriteLine("CATEGORIAS CADASTRADAS: ");

                for(int i = 0; i < contadorCategoria; i++)
			    {
                    Console.WriteLine (i + 1 + ". " + int.Parse(categorias[i]));
                }
            }
            else
            {
                Console.WriteLine("Nenhuma categoria cadastrada.");
            }
        }

        static void listar_fornecedores()
        {
            if (contadorFornecedor > 0)
            {
                Console.WriteLine("FORNECEDORES CADASTRADOS: ");

                for (int i = 0; i < contadorFornecedor; i++)
                {
                    Console.WriteLine(i + 1 + ". " + fornecedores[i]);
                }
            }
            else
            {
                Console.WriteLine("Nenhum fornecedor cadastrado.");
            }
        }

        static void listar_produtos()
        {
            if(contadorProduto > 0)
            {
                Console.WriteLine("PRODUTOS CADASTRADOS: ");

                for(int i = 0; i < contadorProduto; i++)
			    {
                    Console.WriteLine(i + 1 + ". Produto: " + produtos[i] + ", Categoria: " + categorias[produtoCategorias[i]] + ", Fornecedor: " + fornecedores[produtoFornecedor[i]]);
                }
            }
            else
            {
                Console.WriteLine("Nenhum produto cadastrado.");
            }
        }

        static void popular_banco_dados()
        {
            string[] categorias_lote = new string[5] { "Smartphones", "Acessórios", "Carregadores", "Capinhas", "Fones de ouvido" };
            string[] fornecedores_lote = new string[5] { "Samsung", "Apple", "Xiaomi", "Motorola", "LG" };
            string[] produtos_lote = new string[5] { "Galaxy S21", "iPhone 13", "Redmi Note 10", "Moto G100", "LG Velvet" };


            // Cadastrar categorias em lote
            for(int i = 0; i < 5; i++)
		    {
                if(contadorCategoria < 10)
                {
                    categorias[contadorCategoria] = categorias_lote[i];
                    contadorCategoria++;
                }
            }

            // Cadastrar fornecedores em lote
            for(int i = 0; i < 5; i++)
		    {
                if(contadorFornecedor < 10)
                {
                    fornecedores[contadorFornecedor] = fornecedores_lote[i];
                    contadorFornecedor++;
                }
            }

            // Cadastrar produtos em lote com suas respectivas categorias e fornecedores
            for(int i = 0; i < 5; i++)
		    {
                if(contadorProduto < 10)
                {
                    produtos[contadorProduto] = produtos_lote[i];
                    produtoCategorias[contadorProduto] = i; // Cada produto recebe a categoria correspondente
                    produtoFornecedor[contadorProduto] = i;  // Cada produto recebe o fornecedor correspondente
                    contadorProduto++;
                }
            }

            Console.WriteLine("Banco de dados inicializado com sucesso!");
        }
    }
 }