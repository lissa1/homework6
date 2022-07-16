﻿// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
double k1 = InputInt("Введите k1: ");
double b1 = InputInt("Введите b1: ");
double k2 = InputInt("Введите k2: ");
double b2 = InputInt("Введите b2: ");
int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

double x = -(b1 - b2) / (k1 - k2);
double y = k1 * x + b1;
 
Console.WriteLine($"Пересечение в точке: ({x};{y})");