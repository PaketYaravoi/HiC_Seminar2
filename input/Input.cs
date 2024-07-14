//int a = 0; 

//int MyFunction();  // создание метода

//int MyFunctions(int arg1,int arg2)  // создание метода с аргументами , которая ничего не возращает void , она только печатает
//{
//    Console.WriteLine($"1 - {arg1} and {arg2}");
//}

//Приветственная функция:

void Hello(string name = "Roman")
{
    Console.WriteLine($" Hello {name} !");
}
Hello();
Hello("New User");