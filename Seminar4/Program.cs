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
        sum+=i;
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
int number=456;
int current= number;
int count =0;
while (current>0)
{
    current=current/10;
    count=count+1;
}
Console.WriteLine($"Количество цифр в числе {number}= {count}");

/////////////// Решение через строку!!!)))
/*
Console.WriteLine("Введите число");// Мы уже вводим строку- тип данных тут string
string number = Console.ReadLine();
Console.WriteLine(number.Length);
*/
}

void Zadacha28()
//Задача 28.  Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N. (см зд 24.)
{

}
//Zadacha24();
//Zadacha26();
