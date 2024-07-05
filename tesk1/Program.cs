// Напишите программу, которая выводит случайное число их отрезка [10, 99] и показывает наибольшею цифру числа:

//int GetRandomNum()
//{
//    int resolt = new Random().Next(10, 100);
//    return resolt;
//}

//int resolt = GetRandomNum();
//Console.WriteLine(resolt);

//int ShowMaxDigit(int number)
//{
//    if (number >= 10)
//    { 
//        number = 
//    }
//}


int GetRandomNumber(int minValue = 10, int maxValue = 99)
{
    return new Random().Next(minValue, maxValue + 1);
}


int GetMaxTwoDigit(int number)
{
    int digit1 = number / 10;
    int digit2 = number % 10;
    if (digit1 > digit2) return digit1;
    else return digit2;
}

int number = GetRandomNumber();
Console.WriteLine(number);
int maxDigit = GetMaxTwoDigit(number);
Console.WriteLine(maxDigit);
 