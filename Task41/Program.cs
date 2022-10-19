// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int m = GetNumbersQuantity();
int[] array = GetNumbers(m);
PositiveNumbersCount(array);

int GetNumbersQuantity()
{
    Console.WriteLine("Enter M: ");
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[] GetNumbers(int size)
{
    int[] res = new int[m];
    for (int i = 0; i < m; i++)
    {
        Console.Write($"Enter number {i}: ");
        res[i] = int.Parse(Console.ReadLine());
    }
    return res;
}

void PositiveNumbersCount(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;        
    }
    Console.Write($"Quantity of positive numbers = {count}");
}


