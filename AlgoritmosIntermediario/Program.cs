//1. Faça um programa que leia três números, verifique (usando if e else) e mostre o maior e o menor deles;  (Não utilize estrutura de repetição)

Int32 numero1, numero2, numero3;

Console.WriteLine("Digite o primeiro número: ");
numero1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o segundo número: ");
numero2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o terceiro número: ");
numero3 = Convert.ToInt32(Console.ReadLine());

if(numero1 > numero2 && numero1 > numero3)
{
    Console.WriteLine("O maior número foi: " + numero1);
}
if(numero2 > numero1 && numero2 > numero3)
{
    Console.WriteLine("O maior nUmero foi: " + numero2);
}
else if (numero3 > numero1 && numero3 > numero2)
{
    Console.WriteLine("O maior número foi: " + numero3);
}
if(numero1 < numero2 && numero1 < numero3)
{
    Console.WriteLine("O menor número foi: " + numero1);
}
if(numero2 < numero1 && numero2 < numero3)
{
    Console.WriteLine("O menor número foi: " + numero2);
}
else if(numero3 < numero1 && numero3 < numero2)
{
    Console.WriteLine("O menor número foi: " + numero3);
}


