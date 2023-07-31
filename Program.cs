/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
int ShowSecondNumber(int num)
{
    int tens = num / 10 % 10;
        return tens;
}
int randNum = new Random().Next(100, 1000);
int newNum = ShowSecondNumber(randNum);
Console.WriteLine($"Second digit of {randNum} is {newNum}");
/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа ( или -1, если третьей цифры нет).
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

int ShowThirdNumber(int num)
{
    if (num < 100)
        return num = -1;
    else
    {
        int thirdNumber = num /= 100;
        return thirdNumber % 10;
    }
}
int randNum = new Random().Next(1,1000);
int newNum = ShowThirdNumber(randNum);
Console.WriteLine($"Third digit of {randNum} is {newNum}");
/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
bool Weekend(int num)
{
    return num >= 1 && num <= 5;
}
Console.Write("Write the day of the week from 1 to 7:");
int number = Convert.ToInt32(Console.ReadLine());
    bool day = Weekend(number);
    if (day) Console.Write("No");
    else Console.Write("Yes");
