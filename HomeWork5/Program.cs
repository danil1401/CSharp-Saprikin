Console.Clear();

/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/

void Task34()

{  
    Random random = new Random();
    int size =random.Next(0, 15);
    int[] numbers = new int[size];
    FillArray(numbers, 10, 100);
    PrintArray(numbers);
    GetFindChet(numbers);
}

/*Задача 36. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов с нечётными индексами.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

void Task36()

{
    Random random=new Random();
    int size=5;
    int[] numbers=new int[size];
    FillArray(numbers);
    PrintArray(numbers);
    GetSummNechet(numbers);
    /*int sum=0;
    for(int i=0;i<size;i++)
    {
        if (i%2==1)
        {
            sum+=numbers[i];
            Console.WriteLine($"{sum}");
        }
    }
    Console.WriteLine("Сумма элементов под нечетным индексом: "+sum);*/
    
}


/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3,21 7,04 22,93 -2,71 78,24] -> max = 78,24, min = - 2,71, difference = 80,95*/
void Task38()
{
    int size=15;
    double[] numbers=new double[size];// тип double обозначает вещественные числа
    FillArrayDouble(numbers);
    PrintArrayDouble(numbers);
}

//Task34();
//Task36();
//Task38();
Test();

void Test(int test=0)// Рекурсия это метод который ссылается сам на себя
{   
    if(test==100) return;//когда рекурсия дойдет до 100, рекурсия закончится
    test++;
    Console.WriteLine(test);
    Test(test);
    
}










void FillArrayDouble(
    double[] numbers,                                                                              //метод заполнения массива DOUBLE
    int minValue = 0,
    int maxValue = 10
)
{
    maxValue++;
    Random random = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        //numbers[i] = random.NextDouble()*20-10;// смотри разницу *10, *20,*20-10.
        //numbers[i] = Math.Round(random.NextDouble()*20-10, 3);//Math.Round-это округление числа Что округляем(random.NextDouble()*20-10)., до скольки знаком (3)
        double value=random.NextDouble()*20-10;
        numbers[i]=Math.Round(value,2);
    }
}

void PrintArrayDouble(double[] numbers)                                                                  //метод печати массива DOUBLE
{
    Console.WriteLine("Ввыод массива: ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + "  ");
    }
    Console.WriteLine();
}








int GetFindChet(int[] numbers)                                                              //Метод поиска четных элементов массива
{
    int count=0;
    for (int i=0;i<numbers.Length;i++)
    {
        if (numbers[i] %2==0)
        {
            count++;
        }
    }
    Console.WriteLine("Количество четных элементов: "+ count);
    return count;
}

int GetSummNechet(int[] numbers)                                                                //Метод суммы элементов массива под нечетным индексом
{
    int sum=0;
    for(int i=0;i<numbers.Length;i++)
    {
        if (i%2==1)
        {
            sum+=numbers[i];
            Console.WriteLine($"{sum}");
        }
    }
    Console.WriteLine("Сумма элементов под нечетным индексом: "+sum);
    return sum;
}

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
    int maxValue = 10
)
{
    maxValue++;
    Random random = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = random.Next(1, 10);
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