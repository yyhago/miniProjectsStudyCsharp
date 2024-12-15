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
using Models.gerenciadorEstoqueLojaClass
using System.Linq


List<Produto> produtos = new List<Produto>(); // Criação da minha variável list de produtos (inicialmente vazia)
string opcao; // Criação da variável opcao

while(true)
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
    opcao = Console.ReadLine();

    switch(opcao)
    {
        case "1":
            Console.WriteLine("Nome do produto que deseja adicionar:");
            string NomeProduto = Console.ReadLine(); // Guarda o input escrito
            Console.WriteLine("Quantidade do produto que deseja adicionar:");
            int quantProduto = Console.ReadLine(); // Guarda o input escrito

            // Validação para não duplicar nome do produto já existente!
            if(produtos.Any(p => p.NomeProduto == NomeProduto)){
                Console.WriteLine("Não pode duplicar produtos, escolha outro nome por favor.");
                return;
            }   

            // Criação do objeto novoProduto apartir da class Produto
            Produto novoProduto = new Produto
            {
                NomeProduto = NomeProduto, // Passandos as propriedades
                quantProduto = int.Parse(quantProduto) // Passandos as propriedades
            };

            produtos.Add(novoProduto); // Adicionando o novoProduto a minha list produtos
            Console.WriteLine($"Produto {NomeProduto} adicionado com sucesso!"); // Output de saída com sucesso!

            break;

        case "2":
            // ANALISAR
            break;

        case "3":
            // ANALISAR
            break;

        case "4":
            // ANALISAR
            break;

        case "5":
            // ANALISAR
            break;

        case "6":
            Console.WriteLine("Você digitou algo inválido!");
            return;
            break;
    }



}
