// Напишите программу,
//  которая задаёт массив из 8 элементов 
//  и выводит их на экран.
//  1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.Write("Введите колчисетво элементов массива: ");
int number = int.Parse(Console.ReadLine());
int[] arr = new int[number];

void FillArray(int num, int[] array)
{
    for (int i = 0; i < num; i++)
    {
        array[i] = new Random().Next(1,99); 
    }
}

void PrintArray(int num_2, int[] array_2)
{
    Console.Write($"array = [ ");
    for (int i = 0; i < num_2; i++)
    {
        Console.Write($"{array_2[i]} ");
    }
    Console.Write($"]");
}


FillArray(number, arr);
PrintArray(number, arr);