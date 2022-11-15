Console.Clear();

/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3*/

void Zadacha41()

{
Console.WriteLine("Сколько чисел нужно ввести? ");
int countOfNumbers=Convert.ToInt32(Console.ReadLine());
int count=0;//счетчик

for(int i=1;i<=countOfNumbers;i++)
{
    Console.WriteLine($"Введите {i} число: ");
    int inputNumber=Convert.ToInt32(Console.ReadLine());
    
    if(inputNumber>0) count++;
}
Console.WriteLine("Положительных чисел введено "+ count);

}

/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

void Zadacha43()
//Решение через кортеж
//использование не явной переменной var-автоматически поймет что нужно задать, число или строку
{
    var(k1,b1)=(1,4);
    var(k2,b2)=(5,-3);
    Console.WriteLine(k1);
    double x=(b2-b1)/(k1-k2);
    x=Math.Round(x,2);//Math.Round (,2) округление числа до указанного знака после запятой
    double y= k1*x+b1;
    y=Math.Round(y,2);
    Console.WriteLine($"Точка пересечения А ({x},{y})");
}

//Zadacha41();
Zadacha43();