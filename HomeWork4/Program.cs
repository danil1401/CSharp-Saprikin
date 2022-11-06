Console.Clear();

void Task25()
//Задача 25. Используя определение степени числа, напишите цикл, который принимает на вход 2 натуральных числа А и В и возводит число А в степень В
//3,5->243
//2,4->16
{
    Console.Write("Введите число A  : ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число B: ");
    int b = Convert.ToInt32(Console.ReadLine());
    //a^b=a*a*a*....*a - b раз
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result *= a;
    }
    Console.Write($"число {a} в степени {b} = {result}");
}

void Task27()
//ЗАдача 27.Напишите программ, которая принимает на вход число и выдает сумму цифр в числе
// 452-11//82-10.
{
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    number = Math.Abs(number);
    int sum = 0;

    while (number > 0) // пока число больше 0
    {
        sum += number % 10; // к sum прибавляем последнюю цифру number с помощью остатка от деления на 10
        number /= 10; //сам number уменьшаем на эту последнюю цифру (действие выше)
    }
    Console.Write($"Сумма цифр в числе {number} = {sum}");
}

void Task29()//ПРОБЛЕМЫ
//Задача 29. Напишите программу, которая задает массив из 8 случайных чисел и выводи отсоритированный массив по модолю числа
//6,1,-33->[1,6,-33]
{
    
    /*int size = 5;
    int[] numbers = new int[size];
    FillArray(numbers);
    PrintArray(numbers);

    for (int i=0;i<size;i++)
    {
        for (int j=0;j<size-i;j++)
        {
            Console.Write(numbers[j]);
        }
        Console.WriteLine();
    }
    
void FillArray(int[] num) 
{
    Random random = new Random();
    for (int i = 0; i < num.Length; i++)
    {
        num[i] = random.Next(0, 2);
    }
}

void PrintArray(int[] num)
{
    for (int i = 0; i < num.Length; i++)
    {
        Console.Write(num[i] + ",   ");
    }
    Console.Write("\b\b\b");
    Console.WriteLine();
}
*/
// Задача 29: Напишите программу, которая задаёт массив произвольной длины, заполняет произвольными элементами и выводит их на экран.
int[] array = new int[5];// задаем длину массива
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"\nВведите элемент массива под индексом {i}:\t ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.Write("\nМассив из введённых чисел:\t ");
Console.WriteLine($"[{string.Join(", ", array)}]");
}

//Task25();
//Task27();
Task29();
