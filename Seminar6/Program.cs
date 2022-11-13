Console.Clear();
//Проверка ДЗ начинается с 2:25:00
//Задача 39. Напишите программу, которая перевернет одномерный массив(последний элемент будет на первом месте, а первый на последнем и т.д)
void Zadacha39()
{
    int size=10;
    int [] numbers=new int[size]; //задаем массив размером с size  
    FillArray (numbers,-10,10);//но можно дополнительно значения тут, и они будут браться для заполнения в приоритете, если не укажем то будет браться из метода
    PrintArray(numbers);
    ReversArray(numbers);//метод переворота массива
    
    /* int maxIndex=size-1;// определение максимального индекса в массиве
    for (int i = 0; i < size/2; i++)
    {
        //Цикл Перебор массива и его переворот
       /*  int temp= numbers[i];
        numbers[i]=numbers[maxIndex-i];
        numbers[maxIndex-i]=temp; */
        //Еще один способ менять местами переменные-Способ называется кортеж
        //(numbers[i],numbers[maxIndex-i])=(numbers[maxIndex-i],numbers[i]);
    //}
    //массив изменили, теперь нужно сново его напечатать, вызвав метод */
    PrintArray(numbers);
}

//Задача 40. Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины
//Теорема о неравенстве треугольника: каждая сторона треугольник меньше суммы двух других сторон.
void Zadacha40()
{
int sideA=5;
int sideB=4;
int sideC=3;

if(sideA+sideB>sideC&&sideA+sideC>sideB&&sideB+sideC>sideA)
{
    Console.WriteLine("Треугольник существует");
}
else
{
    Console.WriteLine("Треугольника не существует");
}
}

//Задача 42. Напишите программу, которая будет преобразовывать десятичное число в 2ичное
//45->101101
//Нужно делить число на 2 и брать получающиеся остатки
void Zadacha42()
{
int number=243;
string result=Convert.ToString(number, 2);
Console.WriteLine(result);
}

//Не используя рекурсию, выведите первые N чисел Фибоначи.первые два числа Фибоначи: 0 и 1
void Zadacha44()
{

}

//Задача 45. Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
void Zadacha45()

{   
    int size=10;
    int [] numbers=new int[size];
    int[] other=new int[size];//второй массив который будет заполняться 
    FillArray (numbers);
    PrintArray(numbers);

    for(int i=0;i<numbers.Length;i++)
    {
        other[i]=numbers[i];
    }
    Console.WriteLine();
    PrintArray(other);
    /*int size=5;
    int [] numbers=new int[size];
    int[] numbersSecond=new int[size];
    FillArray (numbers);
    PrintArray(numbers);
    Console.ReadKey();//Задержка в  выводе до нажатия клавиши
    numbersSecond=numbers;
    FillArray (numbers);
    PrintArray(numbersSecond);*/
}

//Zadacha39();
//Zadacha40();
//Zadacha42();
//Zadacha44();
Zadacha45();













void FillArray (int[] numbers,                          //метод заполнения массива
                int minValue=0,
                int maxValue=9)//int minValue,int maxValue минимальные и максимальные значения котороми будет заполняться массив                                                                             
    
{
    maxValue++;
    int size= numbers.Length;
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        numbers[i] = random.Next(minValue, maxValue);
    }
}


void PrintArray(int[] numbers)                                                                  //метод печати массива
{
    int size= numbers.Length;
    Console.WriteLine("Вывод массива: ");
    Console.WriteLine();
    for (int i = 0; i < size; i++)
    {
        Console.Write(numbers[i] + "  ");// тут мы будем печатать наш массив
    }
    Console.WriteLine();//просто отступ после того как массив напечатается
}

void ReversArray(int[] numbers)                                                               //метод переворота массива
{
    int size=numbers.Length;
    int maxIndex=size-1;// определение максимального индекса в массиве
    for (int i = 0; i < size/2; i++)
    (numbers[i],numbers[maxIndex-i])=(numbers[maxIndex-i],numbers[i]);
}