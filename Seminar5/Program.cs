Console.Clear();

void Task31()
/*Задача 31. Задать массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
Найдите сумму отрицательных и положительных элементов массива.
*/
{
    int size = 12; // создали размер массива
    int[] numbers = new int[size];
    FillArray(numbers, -9, 9); // -9 и 9-можно указать любые значения для заполнения массива. если не казываем, то можно прописать значения по умолчанию в методе FillArray- int minValue-int maxValue
    PrintArray(numbers);
    Console.WriteLine("Сумма положительных чисел: " + GetSummPositive(numbers));
    Console.WriteLine("Сумма отрицательных чисел: " + GetSummNegative(numbers));
}


void Task32()
//Задача 32.Напишите программу замены элементов массива: положительные элементы заменить на соответсвующте отрицательные, и наоборот.
// -4,-8,8,2 -> 4, 8,-8, -2
{
    int size = 12;
    int[] numbers = new int[size];
    FillArray(numbers, -9, 10);
    PrintArray(numbers);
    ChangeValues(numbers);
    PrintArray(numbers);
}


void Task33()
//Задача 33. Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве?
//3; массив 6, 7, 3, 7, 1 ->да
{
    Console.WriteLine("Введите число для поиска в массиве: ");
    int check=Convert.ToInt32(Console.ReadLine());
    int size = 12;
    int[] numbers = new int[size];
    FillArray(numbers, -9, 10);
    CheckArray(numbers, check);
    PrintArray(numbers);

}

void Task35()
//Задача 35. Задайте одномерный массив, состоящий из случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10, 99]
//5, 18 ,123, 10, 1->1

{
    int size = 12;
    int[] numbers = new int[size];
    FillArray(numbers);
    PrintArray(numbers);
    FindArray(numbers);
}

void Task37()
//Задача 37. Найдите проиведение пар чисел в одномерном массиве.Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
{
    int size = 5;
    int[] numbers = new int[size];
    FillArray(numbers,-9,9);
    PrintArray(numbers);

    int maxIndex= size-1;
    for (int i=0;i<size/2;i++)
    {
        Console.WriteLine($"{numbers[i]} * {numbers[maxIndex-i]} = {numbers[i]*numbers[maxIndex-i]}");
    }
    if (size%2==1)//Если размер массива является не четным, мы так же должны вывести элемент массива без пары 
    {
        Console.WriteLine(numbers[size/2]);
    }
    Console.WriteLine();
}

//Task31();
//Task32();
//Task33();
//Task35();
Task37();

////////////////////////////////////////////////////////МЕТОДЫ///////////////////////////////////////////////////////////////////////


int GetSummPositive(int[] numbers)                                                             //МЕтод суммы положительных чисел //Тип метода int для того что бы возращать число из return
{
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0)
        {
            sum += numbers[i];
        }
    }
    return sum;
}

int GetSummNegative(int[] numbers)                                                              //Метод суммы отрицательных чисел
{
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] < 0)
        {
            sum += numbers[i];
        }
    }
    return sum;
}

void FillArray(
    int[] numbers,                                                                              //метод заполнения массива
    int minValue = 0,
    int maxValue = 100
)
{
    maxValue++;
    Random random = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = random.Next(-9, 9);
    }
}

void PrintArray(int[] numbers)                                                                  //метод печати массива
{
    Console.WriteLine("Ввыод массива: ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + "  ");
    }
    Console.WriteLine();
}

void ChangeValues(int[] numbers)                                                                //Метод замены знаков (+ или -) элементов массива (был -1 стал 1 и наоборот)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] *= -1; //тоже самое как numbers[i]*(-1)
    }
}

void CheckArray(int[] numbers, int check)                                                       // Метод поиска числа в массиве
{
    bool flag = false; //переменная отражающая суть нашли мы число или нет-у нее только true и false
    for (int i = 0; !flag && i < numbers.Length; i++)
    {
        if(check==numbers[i])
        {
            flag=true;
        }
    }
    if (flag==true)
    Console.WriteLine($"Число {check} находится в массиве");
    else
    Console.WriteLine($"Число {check} НЕ находится в массиве");
}

void FindArray(int[] numbers)                                                                   // Метод поиска колличесво элементов массива в определенном отрезке.
{
    int count=0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if(numbers[i]>=10 && numbers[i]<=99)
        {
            count++;
        }
    }
    Console.WriteLine("Количество элементов: "+ count);

}
