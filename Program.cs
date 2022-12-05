//Домашнее задание №1
//Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите 1-е число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-е число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

    if (num1>num2)
    {
    Console.Write(num1 + " больше " + num2 + " невероятно!");
    }
    else
    {
    Console.Write(num2 + " больше " + num1 + " потрясающе!");
    }



