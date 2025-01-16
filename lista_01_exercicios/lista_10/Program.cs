/*
Ex.10 - Cálculo de desconto

 
Objetivo: Aplicar condições para cálculos. 

Descrição: Escreva um programa que solicite o valor de uma compra e verifique se o valor é maior que 100. Em caso afirmativo, aplique um desconto de 10% sobre o valor e mostre o valor final. Caso contrário, exiba o valor original.
 
Saída de amostra: "Valor descontado: [valor final]." ou "Valor original: [valor]
 
    */

Console.WriteLine("Digite o valor da conta:");
double valor = double.Parse(Console.ReadLine());

if (valor > 100)
{
    double desconto = valor * 0.10;
    double valorfinal = valor - desconto;
    Console.WriteLine("Valor com desconto: " + valorfinal);
} else
{
Console.WriteLine("Valor original" + valor);
}