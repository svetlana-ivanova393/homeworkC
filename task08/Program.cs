// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a < 2)
Console.WriteLine("Недопустимое число");
else
{
    int count = 2;
    // count % 2 == 0;
    while (count <= a)
    {
        if (count % 2 == 0)
        {
          Console.Write($"{count} ");
        count++;  
        }
    }
}

// {
//     int count = a;
//     while (count <= a)
//     {
//     // count % 2 == 0;
//         Console.Write($"{count} "); 
//         count++;
//     }
// }