//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5

//78 -> третьей цифры нет

//32679 -> 6

int number =0;
Console.Write("Enter integer: ");


while (!int.TryParse(Console.ReadLine(), out number))
{
    Console.WriteLine("input error!");
}


int GetRigthNumber(int number)
{
    while (number >= 1000)
    {
        number /= 10;
    }
    return number;
}

int GetRigthDigit(int number)
{
    while (number >= 10)
    {
        number %= 10;
    }
    return number;
}


if (number > 100)
{
    int rigthNumber = GetRigthNumber(number);
    int answer = GetRigthDigit(rigthNumber);
    Console.WriteLine($"third digit = {answer}");
}
else
{
    Console.WriteLine("no third number");
}








