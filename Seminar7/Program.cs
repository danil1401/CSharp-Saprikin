Console.Clear();

// Задача 46. Задайте двумерный массив размером m*n, заполненный случайными числами.

void Zadacha46()
{
    Random random=new Random();
    int rows= random.Next(4,8);//строки
    int colums= random.Next(4,8);//столбцы
    Console.WriteLine($"Массив размера {rows}*{colums}");
    Console.WriteLine();
    int[,] numbers= new int[rows,colums];
    FillArray(numbers);
    PrintArray(numbers);
}

//Задача 48. Задайте двумерный массив размера m*n, каждый элемент в массиве находится по формуле A=i+j. 
//Выведете полученный массив на экран.
//m=3,n=4
//0123
//1234
//2345

void Zadacha48()
{
      Random random=new Random();
    int rows= random.Next(4,8);//сколько строк-можно изменить 
    int colums= random.Next(4,8);//сколько столбцов-можно изменить 
    Console.WriteLine($"Массив размера {rows}*{colums}");
    Console.WriteLine();
    int[,] numbers= new int[rows,colums];
    FillArraySumIndex(numbers);
    PrintArray(numbers);
}
void FillArraySumIndex(int [,]numbers)                      //МЕТОД ЗАПОЛНЕНИЯ 2МЕРНОГО МАССИВА по формуле A=i+j- По сумме индексов
{
    
    int rows= numbers.GetLength(0);
    int colums= numbers.GetLength(1);
    for (int i=0;i<rows;i++)
    {
        for(int j=0;j<colums;j++)
        {
            numbers[i,j]=i+j;//заполнение 
        }
    }
}

//Задача 49. Задайте двумерный массив. Найдите элементы, у которых оба индекса четные, и замените эти элементы на их квадраты
void Zadacha49()
{
    
}
//Zadacha46();
Zadacha48();




void FillArray(int [,]numbers)                      //МЕТОД ЗАПОЛНЕНИЯ 2МЕРНОГО МАССИВА
{
    Random random=new Random();
    int rows= numbers.GetLength(0);
    int colums= numbers.GetLength(1);
    for (int i=0;i<rows;i++)
    {
        for(int j=0;j<colums;j++)
        {
            numbers[i,j]=random.Next(-10,11);//заполнение 
        }
    }
}

void PrintArray(int [,] numbers)                //МЕТОД ПЕЧАТИ 2МЕРНОГО МАССИВА
{
    int rows= numbers.GetLength(0);// обращение к заданному массиву и прописывается количество для печати строк
    int colums= numbers.GetLength(1);// обращение к заданному массиву и прописывается количество для печати столбцов
    for (int i=0;i<rows;i++)
    {
        for(int j=0;j<colums;j++)
        {
            Console.Write(numbers[i,j]+"\t");//заполнение //\t делает табиляцию что бы массив не разъезжался и выводился ровно
        }
        Console.WriteLine();
    }
}