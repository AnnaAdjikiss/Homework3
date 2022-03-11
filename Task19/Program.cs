//Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.
// Пример: 14212 -> нет     12821 -> да     23432 -> да
Console.WriteLine("Введите пятизначное целое число");
int number = Convert.ToInt32(Console.ReadLine());
int digit1 = number / 10000;
int digit2 = (number % 10000) / 1000;
int digit4 = (number % 100) / 10;
int digit5 = number % 10;
//Console.WriteLine("первая цифра - " + digit1);
//Console.WriteLine("вторая цифра - " + digit2);
//Console.WriteLine("четвертая цифра - " + digit4);
//Console.WriteLine("пятая цифра - " + digit5);
if (digit1 == digit5 && digit2 == digit4) 
Console.WriteLine("введенное число является палиндромом");
else Console.WriteLine("введенное число не является палиндромом");