/*
Ex.07 -Comparação de números

 
Objetivo: Pratique a comparação de variáveis. 

Descrição: Escreva um programa que solicite ao usuário dois números e determine qual é o maior. Use if, else if e else para exibir a mensagem apropriada. 

Exemplo de saída: "O primeiro número é maior.", "O segundo número é maior." ou "Os números são iguais."
   */

Console.WriteLine("Digite o primeiro número");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo número");
int num2 = int.Parse(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine("O primeiro número e maior");
}
else if (num1 < num2)
{
    Console.WriteLine("O segundo número e maior que o primeiro");
}
else
{
    Console.WriteLine("Os números são iguais");
}
  