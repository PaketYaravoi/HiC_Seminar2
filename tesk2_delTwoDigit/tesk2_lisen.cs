// Напишите программу , которая выдает случайное трехзначное число и удаляет вторую цифру этого числа.


int GetRandomNum(int maxValue, int minValue)
{
   int number = new Random().Next(maxValue, minValue);
    return number;
}

int GetNewNumber(int number)
{
    int number1 = number / 100;
    int number2 = number % 10;
    int numberNew = (number1 * 10) + number2;
    return numberNew;
}

int number = GetRandomNum(100, 1000);
Console.WriteLine(number);

int otherNum = GetNewNumber(number);
Console.WriteLine(otherNum);



