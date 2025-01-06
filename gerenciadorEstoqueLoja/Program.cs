// Desafio: Gerenciador de Estoque de Loja
// Crie um programa em C# simples para gerenciar o estoque de uma loja. O programa deve permitir ao usuário realizar as seguintes operações:

// Adicionar um produto ao estoque; 
// Listar todos os produtos do estoque;
// Atualizar o estoque de um produto;
// Remover um produto do estoque;
// Buscar um produto específico no estoque;

// Regras:
// Use uma List para armazenar os produtos. Cada produto pode ser representado como uma classe com as propriedades Nome e Quantidade.
// Utilize loops (foreach, for ou while) para interagir com os produtos.
// Certifique-se de validar entradas, como verificar se o produto já existe antes de adicionar ou atualizar.
// Ofereça um menu para o usuário escolher a operação desejada.



// Importação da minha classe e da biblioteca Linq
using Models.gerenciadorEstoqueLojaClass;
using System;
using System.Linq;

List<Produto> produtos = new List<Produto>(); // Criação da minha variável list de produtos (inicialmente vazia)
string opcao; // Criação da variável opcao

while (true)
{
    Console.WriteLine("====== Gerenciador de Estoque de Loja ======");

    // Comandos principais para o terminal
    Console.WriteLine("Gerencie sua loja aqui! | Comandos abaixo:");
    Console.WriteLine("1 - Adicionar produto ao estoque:");
    Console.WriteLine("2 - Listar todos produtos do estoque:");
    Console.WriteLine("3 - Atualizar o estoque de um produto:");
    Console.WriteLine("4 - Remover um produto do estoque");
    Console.WriteLine("5 - Buscar um produto específico do estoque");
    Console.WriteLine("6 - Encerrar sistema");

    // Variável opcao que ira guardar o valor do input selecionado
    opcao = Console.ReadLine() ?? "";

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Nome do produto que deseja adicionar:");
            string NomeProduto = Console.ReadLine() ?? "";

            // Validação para nome em branco 
            if (string.IsNullOrWhiteSpace(NomeProduto))
            {
                Console.WriteLine("Nome do produto não pode ser vazio.");
                break;
            }

            Console.WriteLine("Quantidade do produto que deseja adicionar:");
            string quantProdutoInput = Console.ReadLine() ?? "";

            // Validação de entrada numérica
            if (!int.TryParse(quantProdutoInput, out int quantProduto))
            {
                Console.WriteLine("Quantidade inválida. Por favor, insira um número inteiro.");
                break;
            }

            // Validação para não duplicar nome do produto já existente!
            if (produtos.Any(p => p.NomeProduto == NomeProduto))
            {
                Console.WriteLine("Não pode duplicar produtos, escolha outro nome por favor.");
                break;
            }

            // Criação do objeto novoProduto apartir da class Produto
            Produto novoProduto = new Produto
            {
                NomeProduto = NomeProduto, // Passandos as propriedades
                quantProduto = quantProduto // Passandos as propriedades
            };

            produtos.Add(novoProduto); // Adicionando o novoProduto a minha list produtos
            Console.WriteLine($"Produto {NomeProduto} adicionado com sucesso!"); // Output de saída com sucesso!

            break;

        case "2":
            // Verifica se há produtos
            if (produtos.Count == 0)
            {
                Console.WriteLine("Não há produtos no estoque.");
                break;
            }

            // Percorre a List Produto que é nomeado temporariamente de produto dentro dos meus produtos adicionados
            foreach (Produto produto in produtos)
            {
                Console.WriteLine($"Nome: {produto.NomeProduto}, Quantidade: {produto.quantProduto}"); // Output de saída com sucesso!
            }

            break;

        case "3":
            Console.WriteLine("Digite o nome do produto que deseja atualizar:");
            string nomedoProduto = Console.ReadLine() ?? "";

            Produto? produtoEncontrado = produtos.FirstOrDefault(p => p.NomeProduto == nomedoProduto);

            // Verificar se o produto foi encontrado
            if (produtoEncontrado == null)
            {
                Console.WriteLine("Produto não encontrado.");
                break;
            }

            // Solicitar a nova quantidade
            Console.WriteLine("Digite a nova quantidade do produto:"); 
            string entrada = Console.ReadLine() ?? "";

            // Converte a novaQuantidadeProduto para int e verifica se é um número válido
            if (int.TryParse(entrada, out int novaQuantidadeProduto) && novaQuantidadeProduto >= 0)
            {
                // Adiciona a novaQuantidadeProduto a quantProduto já existente.
                produtoEncontrado.quantProduto = novaQuantidadeProduto; 
                Console.WriteLine("Estoque atualizado com sucesso!"); // Output de sucesso!
            }
            else
            {
                Console.WriteLine("Entrada inválida. A quantidade deve ser um número inteiro positivo.");
            }

            break;

        case "4":
            // Solicita ao usuário o input do nome do produto
            Console.WriteLine("Digite o nome do produto que deseja remover:");
            string nomeProdutoRemover = Console.ReadLine() ?? ""; 

            // Busca com ajuda do Linq, dentro de produtos o NomeProduto igual ao nome que o usuário digitou!
            Produto? produtoParaRemover = produtos.FirstOrDefault(p => p.NomeProduto == nomeProdutoRemover);

            // Se não der nulo, é que encontrou o produto. Assim avançando o programa!
            if (produtoParaRemover != null)
            {
                produtos.Remove(produtoParaRemover); // Remove o produto apenas que ele escreveu
                Console.WriteLine($"Produto '{nomeProdutoRemover}' removido com sucesso!"); // output de sucesso!
            }
            else
            {
                Console.WriteLine("Produto não encontrado.");
            }

            break;

        case "5":
            // Solicita a entrada do usuario
            Console.WriteLine("Digite o nome do produto que deseja buscar:");
            string nomeProdutoBuscar = Console.ReadLine() ?? "";

            // Busca com ajuda do Linq, dentro de produtos o NomeProduto igual ao nome que o usuário digitou!
            Produto? produtoParaBuscar = produtos.FirstOrDefault(p => p.NomeProduto == nomeProdutoBuscar);

           // Verificar se o produto foi encontrado, caso achado prossegue com o programa!
            if (produtoParaBuscar != null)
            {
                // output de sucesso!
                Console.WriteLine($"Seu produto foi encontrado! Nome: {produtoParaBuscar.NomeProduto}, Quantidade: {produtoParaBuscar.quantProduto}");
            }
            else
            {
                Console.WriteLine("Não encontramos seu produto.");
            }

            break;

        case "6":
            Console.WriteLine("Encerrando o sistema.");
            return;

        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }
}