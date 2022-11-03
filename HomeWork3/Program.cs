Console.Clear();
DateTime lastTime = DateTime.Now;
Console.WriteLine(DateTime.Now - lastTime);
Console.WriteLine();

void Zadacha19()
//Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, явялется ли оно палиндромом
//14212-нет
//23432-да
{
    //САМОЕ УНИВЕРСАЛЬНОЕ РЕШЕНИЕ НА ПАЛИНДРОМ
    Console.WriteLine("Введите цифры");
    int number = Convert.ToInt32(Console.ReadLine());
    int current_number= number;
    int result = 0;
    while (current_number > 0)
    {
        int digit = current_number % 10; //создали новую переменную только в цикле вайл
        result = result * 10 + digit;
        current_number /= 10;
        Console.WriteLine(result);
    }
    
    if (number==result)
    {
        Console.WriteLine("Палиндром " + number+ " и " + result );
    }
    else
    {
        Console.WriteLine("Не Палиндром " + number+ " и " + result );
    }
}

void ZadachaMy21()//Мое решение
//Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит растояние между ними в 3D пространстве.
{
    Random random = new Random();
    int x1 = random.Next(-10, 10);
    int y1 = random.Next(-10, 10);
    int z1 = random.Next(-10, 10);
    int x2 = random.Next(-10, 10);
    int y2 = random.Next(-10, 10);
    int z2 = random.Next(-10, 10);
    Console.WriteLine($"A({x1}, {y1}, {z1}), B({x2},{y2},{z2})");
    Console.WriteLine();

    Math.Pow(x1 - x2, 2);
    Math.Pow(y1 - y2, 2);
    Math.Pow(z1 - z2, 2);
    Console.WriteLine(
        "Растояние между координатами: "
            + Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2))
    );
}

void Zadacha21()// Решение Преподавателя
{
    Random random = new Random();
    int a_x=random.Next(-10, 10);;
    int a_y=random.Next(-10, 10);;
    int a_z=random.Next(-10, 10);;
    int b_x=random.Next(-10, 10);;
    int b_y=random.Next(-10, 10);;
    int b_z=random.Next(-10, 10);;

    double result= Math.Sqrt(Math.Pow(a_x - b_x, 2)
                        + Math.Pow(a_y - b_y, 2)
                        + Math.Pow(a_z - b_z, 2));
    Console.WriteLine(result);

}
void Zadacha23()
//Задача 23. Напишите программу, которая принимает на вход число (N) и выдает таблицу кубов чисел от 1 до N
//3->1, 8, 27
{
   int number=15;
   
   for(int i=1; i<=number; i++)
   {
        Console.WriteLine($"{i}*{i}*{i} = {Math.Pow(i, 3)}");
   }
}

//Zadacha19();
//Zadacha21();
Zadacha23();

