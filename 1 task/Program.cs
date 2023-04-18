﻿// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.WriteLine("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());

string[] stringArray = new string[n];

for(int i=0; i < n; i++)
{
    stringArray[i] = Console.ReadLine();
}
