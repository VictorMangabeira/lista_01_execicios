﻿/*
Ex.03 -Aprovação do aluno

 
Objetivo: Compreender a aplicação das condições para a tomada de decisão. 

Descrição: Escreva um programa que solicite a nota de um aluno. Se a nota for maior ou igual a 6, o aluno é considerado "Aprovado". Caso contrário, ele está "falhando". Exiba a situação do aluno na tela. 

Exemplo de saída: "Aluno aprovado." ou "Aluno reprovado".

   */

Console.WriteLine("insira a pimeira nota: ");
double nota1 = Double.Parse(Console.ReadLine());


    if ( nota1 >= 6)
{
    Console.WriteLine("Aprovado");
}
else if (nota1 < 6)
{
    Console.WriteLine("Reprovado");
}

