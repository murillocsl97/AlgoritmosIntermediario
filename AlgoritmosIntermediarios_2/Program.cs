//2. Faça um programa que leia três números e mostre-os em ordem decrescente.  (Não utilize estrutura de repetição)

using System.ComponentModel.Design;

Int32 numero1, numero2, numero3, maior = 0, meio = 0, menor = 0;

Console.WriteLine("Digite o primeiro número: ");
numero1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o segundo número: ");
numero2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o terceiro número: ");
numero3 = Convert.ToInt32(Console.ReadLine());


if (numero1 > numero2 && numero1 > numero3)
{
    maior = numero1;
}
if (numero2 > numero1 && numero2 > numero3)
{
    maior = numero2;
}
else if (numero3 > numero1 && numero3 > numero2)
{
    maior = numero3;
}
if (numero1 < numero2 && numero1 < numero3)
{
    menor = numero1;
}
if (numero2 < numero1 && numero2 < numero3)
{
    menor = numero2;
}
else if (numero3 < numero1 && numero3 < numero2)
{
    menor = numero3;
}
if (numero1 > numero2 && numero1 < numero3 || numero1 < numero2 && numero1 > numero3)
{
    meio = numero1;
}
if (numero2 > numero1 && numero2 < numero3 || numero2 < numero1 && numero2 > numero3)
{
    meio = numero2;
}
else if (numero3 > numero1 && numero3 < numero2 || numero3 < numero1 && numero3 > numero2)
{
    meio = numero3;
}

    Console.WriteLine("\n" +maior);
    Console.WriteLine(meio);
    Console.WriteLine(menor);


