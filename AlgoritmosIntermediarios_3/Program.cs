//3. Faça um programa para o cálculo de uma folha de pagamento, sabendo que os descontos são do imposto de Renda,
// que depende do salário bruto (conforme tabela abaixo) e 3% para o Sindicato e que o FGTS corresponde a 11% do salário bruto,
// mas não é descontado (é a empresa que deposita.)
// O salário líquido corresponde ao salário bruto menos os descontos. O programa deverá pedir ao usuário o valor da sua hora e a
// quantidade de horas trabalhadas no mês. 

// a. Desconto do IR; 
// b.Salário Bruto ate R$900,00 (inclusive) – Isento;
// c.Salário Bruto de até R$ 1500, 00 (inclusive) – desconto de 5%;
// d.Salario bruto até R$ 2500,00 (Inclusive) – desconto de 10%;
// e.Salário bruto acima de 2500 – Desconto de 20%. 
// Imprima na tela as informações, dispostas conforme o exemplo abaixo, no exemplo valor da hora é 5 e a quantidade de horas é 220.  

//Salário bruto(5 * 220)           : R$   1100,00 
//( – ) IR(5 %)                             : R$     55,00 
//( – ) Sindicato(3 % )                : R$     33,00
//FGTS ( 11%)                            : R$     121,00
//Total de descontos                : R$     165,00 
//Salário Líquido                       : R$     1.012,00


Decimal valorHora, horasTrabalhadasMes, FGTS = 11, impostoDeRenda = 0, sindicato = 3, totalDescontos, salarioLiquido = 0, salarioBruto;

Console.WriteLine("Digite o valor da hora do(a) funcionário(a): R$");
valorHora = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o total de horas trabalhadas do(a) funcionário(a) no mês: ");
horasTrabalhadasMes = Convert.ToDecimal(Console.ReadLine());

salarioBruto = valorHora * horasTrabalhadasMes;
sindicato = salarioBruto * 0.03m;
FGTS = salarioBruto * 0.11m;



if (salarioBruto <= 900)
{
    salarioLiquido = salarioBruto;
    totalDescontos = impostoDeRenda + sindicato;


    Console.WriteLine("O salário bruto desse funcionário(a) foi: R$" + salarioBruto);
    Console.WriteLine("Imposto de renda descontado foi de: R$" + impostoDeRenda);
    Console.WriteLine("Com o Sindicato foi descontado: R$" + sindicato);
    Console.WriteLine("Descontos do FGTS: R$" + FGTS);
    Console.WriteLine("Total de descontos foi de: R$" + totalDescontos);
    Console.WriteLine("Salário liquido do funcionário(a) no mês foi de: R$" + salarioLiquido);

}
if (salarioBruto >= 901 && salarioBruto <= 1500)
{
    impostoDeRenda = salarioBruto * 0.10m;
    totalDescontos = impostoDeRenda + sindicato;
    salarioLiquido = salarioBruto - totalDescontos;

    Console.WriteLine("O salário bruto desse funcionário(a) foi: R$" + salarioBruto);
    Console.WriteLine("Imposto de renda descontado foi de: R$" + impostoDeRenda);
    Console.WriteLine("Com o Sindicato foi descontado: R$" + sindicato);
    Console.WriteLine("Descontos do FGTS: R$" + FGTS);
    Console.WriteLine("Total de descontos foi de: R$" + totalDescontos);
    Console.WriteLine("Salário liquido do funcionário(a) no mês foi de: R$" + salarioLiquido);

}
if (salarioBruto >= 1501 && salarioBruto <= 2500)
{
    impostoDeRenda = salarioBruto * 0.10m;
    totalDescontos = impostoDeRenda + sindicato;
    salarioLiquido = salarioBruto - totalDescontos;
    Console.WriteLine("O salário bruto desse funcionário(a) foi: R$" + salarioBruto);
    Console.WriteLine("Imposto de renda descontado foi de: R$" + impostoDeRenda);
    Console.WriteLine("Com o Sindicato foi descontado: R$" + sindicato);
    Console.WriteLine("Descontos do FGTS: R$" + FGTS);
    Console.WriteLine("Total de descontos foi de: R$" + totalDescontos);
    Console.WriteLine("Salário liquido do funcionário(a) no mês foi de: R$" + salarioLiquido);

}
else if (salarioBruto > 2500)
{
    impostoDeRenda = salarioBruto * 0.10m;
    totalDescontos = impostoDeRenda + sindicato;
    salarioLiquido = salarioBruto - totalDescontos;

    Console.WriteLine("O salário bruto desse funcionário(a) foi: R$" + salarioBruto);
    Console.WriteLine("Imposto de renda descontado foi de: R$" + impostoDeRenda);
    Console.WriteLine("Com o Sindicato foi descontado: R$" + sindicato);
    Console.WriteLine("Descontos do FGTS: R$" + FGTS);
    Console.WriteLine("Total de descontos foi de: R$" + totalDescontos);
    Console.WriteLine("Salário liquido do funcionário(a) no mês foi de: R$" + salarioLiquido);

}




