// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int rand = new Random().Next();
Console.WriteLine("Рандомное число: " + rand);

FindLergestNumbers(rand);

void FindLergestNumbers(int a)
{
    if (a < 100)
    {
        Console.WriteLine("Третьей цифры нет");
    }
    else
    {
        Console.WriteLine("Третья цифра в числе: " + a.ToString()[2]);
    }
}
