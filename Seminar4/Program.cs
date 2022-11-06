Console.Clear();

void Zadacha24()
//Задача 24. Напишите программу, которая принимает на вход число (А) и выдает сумму чисел
//4->10
{
    int number = 4;
    int sum = 0; //Создаем переменную накопитель для сумму чисел
    for (int i = 1; i <= number; i++)
    {
        //Console.Write($"{i} + ");
        //или
        sum += i;
    }
    Console.Write($"{sum}");
}

void Zadacha26()
//Задача 26. Напишите программу, которая принимает на вход число и выдает количество цифр в числе.
//456->3
//Можно решить через строку, через цикл, через математику.
{
    //Решение через Цикл
    //Math.Abs(number)- модуль для преобразования в положительное число
    int number = 456;
    int current = number;
    int count = 0;
    while (current > 0)
    {
        current = current / 10;
        count = count + 1;
    }
    Console.WriteLine($"Количество цифр в числе {number}= {count}");

    /////////////// Решение через строку!!!)))
    /*
    Console.WriteLine("Введите число");// Мы уже вводим строку- тип данных тут string
    string number = Console.ReadLine();
    Console.WriteLine(number.Length);
    */

    ////////////////МАТЕМАТИЧЕСКОЕ решение через логарифм
    /*
    Console.Write("Введите число");
    int num=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"{nun}= {Math.Ceiling(Math.Log(num))}");
    
    */
}

void Zadacha28()
//Задача 28.  Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N. (см зд 24.)
//5-120
{
    Console.WriteLine("\n \t Задача 28");
    int number = 5;
    int result = 1; // переменная накопитель в которой будет храниться результат
    for (int i = 1; i <= number; i++)
    {
        result = result * i;
        Console.WriteLine(result);
    }
    Console.WriteLine($"Произведение чисел= {result}");
}

void Task30()
// Задача 30. Написать программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке. [1,0,1,1,0,1,0,0]
{
    Random random = new Random();
    int size = random.Next(4, 10); // присваивание переменной  size значения рандома от 4 до 10
    int[] numbers = new int[size]; // array-так называют массив

    FillArray(numbers);

    PrintArray(numbers);

    //Console.WriteLine(array[0]); //Вывод на печать значения массива под 0 индексом, в [] указывается ИНДЕКС элемента
}
void FillArray(int[] num) //Метод для заполнения массива к задача 30
{
    Random random = new Random();
    for (int i = 0; i < num.Length; i++)
    {
        num[i] = random.Next(0, 2);
    }
}

void PrintArray(int[] num) //Метод для печатанья массива к задача 30
{
    for (int i = 0; i < num.Length; i++)
    {
        Console.Write(num[i] + ",   ");
    }
    Console.Write("\b\b\b");
    Console.WriteLine();
}


//Zadacha24();
//Zadacha26();
//Zadacha28();
Task30();
