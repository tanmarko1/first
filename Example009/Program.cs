// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет


Console.WriteLine("Напишите число, чтобы определить, является ли оно четным");
double num = Convert.ToInt32(Console.ReadLine());
double div = num%2;
    if (div > 0)
    Console.WriteLine($"нет");
    else 
    Console.WriteLine($"да");