﻿// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int rand = new Random().Next(100, 1000);
Console.WriteLine("Рандомное число: " + rand);
int a1 = FindFirstDigitNumber(rand);


Console.WriteLine ("Вторая цифра: " + FindFirstDigitNumber(rand));

int FindFirstDigitNumber (int x)
{
    int a = x / 10 % 10;
    return a;
}

