﻿Console.Write("Digite um numero positivo para saber a sua respectiva tabuada: ");
int numero = int.Parse(Console.ReadLine());
int num2 = numero * 10;


Console.WriteLine($"\nNumeros de 0 até {numero}");
for (int i = 0; i <= num2; i += numero)
{
    Console.WriteLine(i);
}

Console.WriteLine("Digite uma tecla para sair! ");
Console.ReadKey();