Console.Clear();
DateTime lastTime = DateTime.Now;
Console.WriteLine("Время выполнения задачи");
Console.WriteLine(DateTime.Now - lastTime);
Console.WriteLine();

// void - метод решает одну задачу- один метод=одна задача


void Zadacha17() // ТАК выглядит правильное решение и оформление С импользованием метода для какого то действия
//Задача 17. Напишите программу, которая принимает на вход координаты точки (X и Y), причем X не равно 0, и Y не равно 0,
// , и выдает номер четверти плоскости, в которой находится эта точка.
{
    Random random = new Random(); // рандом можно задать один раз и присвоить нескольким переменным.
    int x = random.Next(-10, 10);
    int y = random.Next(-10, 10);
    Console.WriteLine($"A({x}, {y})"); // печать точки которая имеет координаты рандомные х и у
    CoordCheck(x, y); // вызов метода выдающего четверть плоскости
}
void CoordCheck(int x, int y) // МЕТОД К ЗАДАЧА 17. метод выдающий четверть плоскости по заданным координатам и обращается к заданным переменным х и у
{
    if (x > 0 && y > 0)
    {
        Console.WriteLine("1-ая четверть");
    }
    else if (x < 0 && y > 0)
    {
        Console.WriteLine("2-ая четверть");
    }
    else if (x < 0 && y < 0)
    {
        Console.WriteLine("3-ая четверть");
    }
    else if (x > 0 && y < 0)
    {
        Console.WriteLine("4-ая четверть");
    }
    else
    {
        Console.WriteLine("Точка лежит на одной из осей"); //в случае если х или у равны 0
    }
}

void Zadacha18()
//Задача 18. Напишите программу, которая по заданному номеру четверти, показывает диапозон возможных координат точек в этой четверти (х и у)
{
    Console.WriteLine("Введите от 1 до 4");
    int number = Convert.ToInt32(Console.ReadLine());
    CoordTochek(number);
}
void CoordTochek(int number) //Метод к ЗАДАЧА 18- вывода координат четверти от 1 до 4ой по осям х и у
{
    if (number == 1)
    {
        Console.WriteLine("Первая четверть x>0 и y>0");
    }
    else if (number == 2)
    {
        Console.WriteLine("Вторая четверть x<0 и y>0");
    }
    else if (number == 3)
    {
        Console.WriteLine("Третья четверть x<0 и y<0");
    }
    else if (number == 4)
    {
        Console.WriteLine("Четвертая четверть x>0 и y<0");
    }
    else
    {
        Console.WriteLine("Введено не верное значение, повторите");
    }
}

void Zadacha21() //
// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве
// A(3,6);B(2,1)->5,09
//
{
    Random random = new Random();
    int x1 = random.Next(-10, 10);
    int y1 = random.Next(-10, 10);
    int x2 = random.Next(-10, 10);
    int y2 = random.Next(-10, 10);
    Console.WriteLine($"A({x1}, {y1}), B({x2},{y2})");
    Console.WriteLine();

    Math.Pow(x1 - x2, 2);
    Math.Pow(y1 - y2, 2);
    Console.WriteLine(
        "Растояние между координатами: " + Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2))
    );

    //Квадрат разности (х1-х2)*(х1-х2) и (у1-у2)*(у1*у2) либо через функцию ниже
    //Math.Pow(х1-х2,2);, Math.Pow-функция возведения в квадрат, х1-х2-значение которое возводим в квадрат, 2- на сколько возводим
    //Math.Sqrt(); функция поиска квадратного корня, в () укызвается из чего находим корень
}

void Zadacha22()
// Задача 22. Написать программу, которая принимает на вход число N и выдает таблицу квадратов чисел от 1 до N

{
    Console.WriteLine("Введите число N: ");
    int number = Convert.ToInt32(Console.ReadLine());
    number=Math.Abs(number);// преобразование отрицательных чисел в положительные
    Console.WriteLine("Число\t Квадрат");
    tkvadratov_for(number);
}
void tkvadratov_for(int number) // Метод к Задаче 22- Возведение числа N в квадрат
{
    for (int i = 1; i <= number; i++)
    {
        Console.WriteLine($"{i} * {i}\t {i * i} "); // \t позволяет красиво оформить двемерный массив/таблицу на выводе
    }
}

void Zadacha22_while()// Решение Задача 22 через цикл while
{   
    Console.WriteLine("Введите число N: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int i=1;
    while (i<=number)
    {
        Console.WriteLine($"{i}*{i} = {i * i}");
        i++;
    }
}

//void Zadacha(); //
//Zadacha17();
//Zadacha18();
//Zadacha21();
//Zadacha22();
Zadacha22_while();