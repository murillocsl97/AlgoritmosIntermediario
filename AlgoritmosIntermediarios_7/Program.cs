// 7. Faça um programa para calcular n! (Fatorial de n), sendo que o valor inteiro de n é fornecido pelo usuário. Sabe-se que: 
// N! = 1 * 2 * 3 * … (n – 1) * n
// 0! = 1, por definição;

Int32 numero, sequencia, final = 1;

Console.WriteLine("Digite um número positivo e inteiro: N ");
numero = Convert.ToInt32(Console.ReadLine());

if (numero == 0)
{
    Console.WriteLine("0! = 1");
}
else
{

    for (sequencia = 1; sequencia <= numero; sequencia++)
    {
        final *= sequencia;
    }
    Console.WriteLine(numero + " ! = " + final);
}

