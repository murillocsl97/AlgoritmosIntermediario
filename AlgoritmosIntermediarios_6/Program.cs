

Decimal  valorCarro, compraAVista = 0.0m, descontoAVista = 0.0m;

Console.WriteLine("Digite o preço do carro: R$");
valorCarro = Convert.ToDecimal(Console.ReadLine());

descontoAVista = valorCarro * 0.20m;
compraAVista = valorCarro - descontoAVista;

Console.WriteLine("Se o carro for pago á vista, o valor total tem 20% de desconto. o preço fica :R$" + compraAVista);
Console.WriteLine("\nA quantidades de parcelas pode ser: 6, 12, 18, 24, 30, 36, 42, 48, 54 e 60.");
Console.WriteLine("\nSe for em 6 parcelas tem o juros de: R$" + valorCarro * 0.03m + " a mais no preço final!");
Console.WriteLine("\nSe for em 12 parcelas tem o juros de: R$" + valorCarro * 0.06m + " a mais no preço final!");
Console.WriteLine("\nSe for em 18 parcelas tem o juros de: R$" + valorCarro * 0.09m + " a mais no preço final!");
Console.WriteLine("\nSe for em 24 parcelas tem o juros de: R$" + valorCarro * 0.12m + " a mais no preço final!");
Console.WriteLine("\nSe for em 30 parcelas tem o juros de: R$" + valorCarro * 0.15m + " a mais no preço final!");
Console.WriteLine("\nSe for em 36 parcelas tem o juros de: R$" + valorCarro * 0.18m + " a mais no preço final!");
Console.WriteLine("\nSe for em 42 parcelas tem o juros de: R$" + valorCarro * 0.21m + " a mais no preço final!");
Console.WriteLine("\nSe for em 48 parcelas tem o juros de: R$" + valorCarro * 0.24m + " a mais no preço final!");
Console.WriteLine("\nSe for em 54 parcelas tem o juros de: R$" + valorCarro * 0.27m + " a mais no preço final!");
Console.WriteLine("\nSe for em 60 parcelas tem o juros de: R$" + valorCarro * 0.30m + " a mais no preço final!");

