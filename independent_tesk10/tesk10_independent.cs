//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1


int GetRandomNum(int minValue, int maxValue)
{
    return new Random().Next(minValue, maxValue);
        
}

int GetRigthNumber(int number)
{
    while (number >= 100)
    {
        number /= 10;
    }
    return number %= 10;
}


int number = GetRandomNum(100,  1000);
Console.WriteLine(number);

int answer = GetRigthNumber(number);
Console.WriteLine(answer);

