Console.Clear();

void Zadacha2()
{
//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/


Console.WriteLine("Введите первое число: ");
int num1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2=Convert.ToInt32(Console.ReadLine());

if (num1>num2)
{
    Console.WriteLine($"Число {num1} максимальное");
}
else if (num1<num2)
{
Console.WriteLine($"Число {num2} максимальное");
}
else
Console.WriteLine ("Числа равны");

}

void Zadacha4()
{
//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;

if (num2 > max)
{
max = num2;
}
if (num3 > max)
{
max = num3;
}
Console.WriteLine("Максимальное число: " + max);
}

void Zadacha6()
{
/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет*/

Console.WriteLine("Введите первое число: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num%2==0)// Пример с конфетами-есть 2 ребенка и 12 конфет, если поделить на 2 и раздать конфеты, получится на каждого ребенка по 6 конфет, а 0 конфет останется у меня (остатка нет-значит число четное)
{
    Console.WriteLine("Четное число");
}
else Console.WriteLine("Число не четное");
}

void Zadacha8()
{
/*Задача 8: Напишите программу, которая на вход принимает число (N > 0), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
num=Math.Abs(num);
int i=2;// обозначаем новую переменную сразу с первым четным числом
while (i<=num)// пока 2 меньше вводимого числа
{
    Console.Write(i + " ");// выводим 2 + итерация(ниже) к следующему четному числу. и так по кругу пока не дойдем до введеного числа.
  i+=2;//в итерации сразу будем увеличивать на 2(2 4 6 и т.д)
}
}
//Zadacha2(); комментируем те задачи которые не нужны для вывода решения
//Zadacha4();
//Zadacha6();
Zadacha8();// вызов метода void/ вызов одной из задач в терминале