//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

int number;

Console.Write("Please, enter the day of the week: ");
while (!int.TryParse(Console.ReadLine(), out number))
{ 
    Console.WriteLine("Input error");
}



if (number >= 8 || number <= 0)
{
    Console.WriteLine("not day of week");
}
else if (number == 6 || number == 7)
{
    Console.WriteLine($"{number} - day off!!!");
}
else
{
    Console.WriteLine($"{number} - not day off!!!");
}





