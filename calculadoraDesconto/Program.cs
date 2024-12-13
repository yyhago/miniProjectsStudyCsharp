// Desafio: Calculadora de Descontos
// Crie um programa em C# que calcule o valor final de um produto após a aplicação de um desconto. O programa deve:

// Solicitar ao usuário o preço final do produto (um número decimal);
// Solicitar a porcentagem do desconto (um número decimal);
// Calcular o valor do desconto;
// Subtrair o desconto do preço original para obter o preço final;
// Exibir o valor do desconto e preço final;


Console.WriteLine("=========== Calculadora de Descontos ===========");

Console.WriteLine("Digite o valor do produto:");
decimal precoOriginal = decimal.Parse(Console.ReadLine());  

Console.WriteLine("Digite a porcentagem do valor de desconto:");
decimal percentualDesconto = decimal.Parse(Console.ReadLine());  


decimal valorDesconto = precoOriginal * (percentualDesconto / 100);


decimal precoFinal = precoOriginal - valorDesconto;


Console.WriteLine($"O valor do desconto é: {valorDesconto}");
Console.WriteLine($"O valor original era: {precoOriginal}");
Console.WriteLine($"E o preço final após o desconto é: {precoFinal}");
