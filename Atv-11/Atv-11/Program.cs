
try
{
  Console.Write("Digite o primeiro número para realizar sua soma: ");
    double num1 = double.Parse(Console.ReadLine());

    Console.Write("Digite o segundo número: ");
   double num2 = double.Parse(Console.ReadLine());

    double resultado = num1 + num2;
    Console.Write($"O resultado da soma é: {resultado}");
}

catch (FormatException)
{
   Console.WriteLine("Erro: por favor, degite numeros válidos");
}

Console.WriteLine("\nDigite qualquer tecla para encerrar o programa");
Console.ReadKey();