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
    Random random=new Random();
    int rows=random.Next(4,8);
    int colums=random.Next(4,8);
    Console.WriteLine($"Массив размера {rows}*{colums}");
    Console.WriteLine();
    int [,] numbers=new int[rows,colums];
    FillArray(numbers);
    PrintArray(numbers);

    for (int i=0;i<rows;i+=2)//перепрыгиваем на четные числа массива
    {
        for(int j=0;j<colums;j+=2)//перепрыгиваем на четные числа массива
        {
            numbers[i,j]=numbers[i,j]*numbers[i,j];//умножаем что бы получить квадрат
        }
    }
    Console.WriteLine();
    Console.WriteLine("Массив с значениями в квадрате:");
    PrintArray(numbers);
}

//Задача 51. Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами 0,0...1,1 и т.д)
void Zadacha51()
{
Random random=new Random();
int rows=random.Next(4,8);
int colums=random.Next(4,8);
Console.WriteLine($"Массив размера {rows}*{colums}");
Console.WriteLine();
int [,] numbers= new int[rows, colums];
int sum=0;// создали накопитель
FillArray(numbers);
PrintArray(numbers);

for (int i=0;i<rows;i++)//перепрыгиваем на четные числа массива
    {
        for(int j=0;j<colums;j++)//перепрыгиваем на четные числа массива
        if(i==j)
        {
            sum= sum+ numbers[i,j];
        }
    }
Console.WriteLine();
Console.WriteLine($"Сумма всех элементов главной диалгонали массива= {sum}");
}

/*Дополнительная задача:
Дан двумерный массив из двух строк и двадцати двух столбцов. В его первой строке записанно количество мячей,
забитых футбольной коммандой в игре, во второй- количество пропущенных мячей в игре.
а) Для каждой проведенной игры напечатать словесный результат: "выигрыш", "ничья", "проигрыш"
б) Определить количество выигрышей данной команды
в) Определить количество выигрышей и количество проигрышей данной команды
г) Определить количество выигрышей, количество ничьих и количество проигрышей данной команды
д) Определить в скольких играх разность в забитых и пропущенных мячей была большей или равна трем
е) Определить общее число очков, набранных командой (за выигрыш даются 3 очка, за ничью 1, за проигрыш 0)*/

void DopZadacha()
{
    int rows=2;
    int colums=10;
    int [,] numbers= new int[rows,colums];
    FillArrayDop(numbers,0,10);
    PrintArray(numbers);
    
    int win=0;
    int losse=0;
    int drew=0;
    int points=0;

    for (int i=0;i<colums;i++)
    {
        if(numbers[0,i]>numbers[1,i])
        {
            win++;//счетчик для подсчета количества побед
            Console.WriteLine("Выигрыш! " + numbers[0,i]+" : "+ numbers[1,i]);
        }
        if(numbers[0,i]<numbers[1,i])
        {
            losse++;//счетчик для подсчета количества поражений
            Console.WriteLine("Проигрыш "+ numbers[0,i]+" : "+ numbers[1,i]);
        }
        if(numbers[0,i]==numbers[1,i])
        {
            drew++;//счетчик для подсчета количества ничьих
            Console.WriteLine("Ничья " + numbers[0,i]+" : "+ numbers[1,i]);
        }
    }
    points=win*3+drew;

    Console.WriteLine("Количество побед: "+ win+" Количество поражений: "+ losse+ " Количество ничьих: "+ losse);
    Console.WriteLine("Количество очков комманды: "+ points);
}
void FillArrayDop(int [,]numbers,
                    int minBalls=0,
                    int maxBalls=1)                      
    {
    maxBalls++;
    Random random=new Random();
    int rows= numbers.GetLength(0);
    int colums= numbers.GetLength(1);
    for (int i=0;i<rows;i++)
        {
        for(int j=0;j<colums;j++)
            {
            numbers[i,j]=random.Next(minBalls,maxBalls);//random.Next(-10,11)в скобках любые числа которые будут заполнять массив
            }
        }
    }


//Zadacha46();
//Zadacha48();
//Zadacha49();
//Zadacha51();
DopZadacha();


void FillArray(int [,]numbers)                      //МЕТОД ЗАПОЛНЕНИЯ 2МЕРНОГО МАССИВА
{
    Random random=new Random();
    int rows= numbers.GetLength(0);
    int colums= numbers.GetLength(1);
    for (int i=0;i<rows;i++)
    {
        for(int j=0;j<colums;j++)
        {
            numbers[i,j]=random.Next(1,9);//random.Next(-10,11)в скобках любые числа которые будут заполнять массив
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