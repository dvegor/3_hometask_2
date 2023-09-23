// Урок 2. Базовые алгоритмы

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// void SecondDigit(int num)
// {
//     int digit1 = num/10;
//     int digit2 = digit1%10;
//     Console.WriteLine($"Second digit is {digit2}");
// }

// Console.WriteLine("Input your three digit number");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number>99 && number<1000)
// SecondDigit(number);
// else if (number<-99 && number>-1000)
// SecondDigit(number*-1);
// else
// Console.WriteLine("Please, input three digit number");

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// void ThirdDigit(int num)
// {
//     for (int i = 0; num > 1000; i++)
//     {
//         num = num/10;
//     }
//     int digit = num%10;
//     Console.WriteLine($"Third digit is {digit}");
// }

// Console.WriteLine("Input number");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number>99)
// ThirdDigit(number);
// else if (number<-99)
// ThirdDigit(number*-1);
// else
// Console.WriteLine("There is no third digit");

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// void CheckWeekEnd(int num)
// {
//     if(num<6)
// Console.WriteLine("It's a working day:(");
//     else
// Console.WriteLine("It's weekend!");    
// }

// Console.WriteLine("Input the number of the day of the week");
// int day = Convert.ToInt32(Console.ReadLine());
// if (day<8 && day>0)
// CheckWeekEnd(day);
// else
// Console.WriteLine("You wrong, mf!");