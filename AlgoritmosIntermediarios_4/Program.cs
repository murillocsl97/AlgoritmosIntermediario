// Faça um programa que leia um valor n, inteiro e positivo, calcule e mostre a seguinte soma: S = 1 + 1/2 + 1/3 + 1/4 + … + 1/n.

Int32 numero, sequencia, final = 1;

Console.WriteLine("Digite um número inteiro: ");
numero = Convert.ToInt32(Console.ReadLine());

if (numero == 0)
{
    Console.WriteLine("0! = 1");
}
else
{

    for (sequencia = 1; sequencia <= numero; sequencia++)
    {
        final +/= sequencia;
    }
    Console.WriteLine(numero + " ! = " + final);
}