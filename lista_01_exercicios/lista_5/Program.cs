﻿/*
Ex.05 -Verificação de idade

 
Objetivo: Aplicar condições para classificar os dados. 

Descrição: Desenvolva um programa que pergunte a idade de uma pessoa e determine se ela é maior de idade (18 anos ou mais) ou menor de idade. Use if e else para exibir a mensagem apropriada. 

Exemplo de saída: "Você é maior de idade." ou "Você é menor de idade".

   */

Console.WriteLine("Qual sua idade? ");
int num1 = int.Parse(Console.ReadLine());

if (num1 > 18)
{
    Console.WriteLine("Você é maior de idade");
}
else
{
    Console.WriteLine("Você é menor de idade");
}