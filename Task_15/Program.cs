﻿// // Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите цифру, обозначающую день недели");
int N = Convert.ToInt32(Console.ReadLine());

if (N == 6 || N == 7)
{
    Console.WriteLine("Этот день выходной");
}
else if (N>7 || N<1)
{
    Console.WriteLine("Введённая цифра не соответсвует дню недели. Введите цифру от 1 до 7");
}
else
{
    Console.WriteLine("Этот день не выходной");
}