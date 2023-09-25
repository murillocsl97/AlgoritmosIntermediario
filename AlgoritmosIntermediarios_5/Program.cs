Console.Write("Digite o tamanho do lado do quadrado (entre 1 e 20): ");

int tamanho = Convert.ToInt32(Console.ReadLine());

if (tamanho < 1 || tamanho > 20)
{
    Console.WriteLine("Tamanho inválido. O tamanho deve estar entre 1 e 20.");
    return;
}

for (int i = 0; i < tamanho; i++)
{
    for (int j = 0; j < tamanho; j++)
    {
        Console.Write("* ");
    }
    Console.WriteLine();
}