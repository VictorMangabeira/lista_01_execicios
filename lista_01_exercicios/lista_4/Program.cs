﻿/*
Ex.04 -Faixa de valor

 
Objetivo: Familiarizar -se com a verificação de intervalos numéricos. 

Descrição: Crie um programa que verifique se um número inserido pelo usuário está dentro do intervalo de 1 a 100. Use uma condição if para verificar se o número está dentro do intervalo e exiba uma mensagem informando o resultado. 

Exemplo de saída: "O número está entre 1 e 100." ou "O número não está entre 1 e 100."
 
 */

Console.WriteLine("Digite um número");
double num1 = double.Parse(Console.ReadLine());


if (num1 > 1 && num1 < 100)
{
    Console.WriteLine("O número está entre 1 e 100");
}
else
{
    Console.WriteLine("O número não esta entre 1 e 100");
}