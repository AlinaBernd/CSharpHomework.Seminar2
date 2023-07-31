/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1

int ShowSecondNumber(int num)
{
    int tens = num / 10 % 10;
        return tens;
}
int randNum = new Random().Next(100, 1000);
int newNum = ShowSecondNumber(randNum);
Console.WriteLine($"Second digit of {randNum} is {newNum}");

