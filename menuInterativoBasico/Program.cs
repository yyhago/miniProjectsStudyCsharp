// Desafio: Menu interativo
// Crie um programa em C# que seja um menu interativo básico, sem muitas funcionalidades. O programa deve:

// Fluxo dos caminhos dado por comando sem erro;
// Atualizar o terminal a cada comando;

string opcao;


while(true)
{

    Console.WriteLine("====== Menu Interativo ======");

    Console.WriteLine("Digite as opções que deseja:");
    Console.WriteLine("1 - Buscar clientes:");
    Console.WriteLine("2 - Cadastrar clientes:");
    Console.WriteLine("3 - Deletar clientes:");
    Console.WriteLine("4 - Encerrar");


    opcao = Console.ReadLine();

    switch(opcao)
    {
        case "1":
            Console.WriteLine("Buscando cliente...");
        break;

         case "2":
            Console.WriteLine("Cadastrando cliente...");
        break;

         case "3":
            Console.WriteLine("Deletando cliente...");
        break;

         case "4":
            Console.WriteLine("Encerrando.");
            return;
        break;

        default:
            Console.WriteLine("Digite um valor válido.");
        break;
    }


}