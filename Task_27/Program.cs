// Напишите программу, 
// которая принимает на вход число 
// и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

int Sum(int num)
{
    int result = 0;
    for (int i = 0; i < number; i++)
    {
        result += num % 10;
        num /= 10;
    }

    Console.WriteLine($"{number} -> {result}");

    return result;
}
Sum(number);



