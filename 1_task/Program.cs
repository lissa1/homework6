﻿// //Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь
Console.WriteLine("Введите числа через запятую: ");
string numbersString = Console.ReadLine() ?? "";
int[] numbers = ParseArray(numbersString, ',');
int count = 0;
for(int i = 0; i< numbers.Length; i++)
{
    if(numbers[i] > 0)
        count++;
}
Console.WriteLine($"пользовательввел {count} чисел больше нуля");


int[] ParseArray(string input, char separator)
{
    int[] numbers = new int[GetCountNumbersInString(input)];
    string subString = String.Empty;
    int numbersIndex = 0;
    for(int i = 0; i < input.Length; i++)
    {
        if(input[i] == separator)
        {
            numbers[numbersIndex++] = Convert.ToInt32(subString);
            subString = String.Empty;
        }
        else
        {
            subString += input[i];
        }
    }
    numbers[numbersIndex] = Convert.ToInt32(subString);
    return numbers;
}
int GetCountNumbersInString(string numbers)
{
    int countNumbers = 1;
    for(int i = 0; i < numbers.Length; i++)
    {
        if(numbers[i] == ',')
            countNumbers++;
    }
    return countNumbers;
}