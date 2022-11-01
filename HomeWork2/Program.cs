Console.Clear();
DateTime lastTime=DateTime.Now;
Console.WriteLine(DateTime.Now - lastTime);

void Zadacha10() //Задача 10. Написать программу, которая принимает на вход трехзначное число и на выходе показывает вторую чифру этого числа.
//456->5
{
    Console.WriteLine("Задача 10");
    Console.WriteLine();

    Random random = new Random();
    int number = random.Next(100, 1000);
    /*Console.WriteLine("Введите число: ");
    int number= Convert.ToInt32(Console.ReadLine());*/

    int number1 = number % 100;
    int number2 = number1 / 10;
    Console.WriteLine("Рандомное число: " + number);
    Console.WriteLine("Вторая цифра " + number + "= " + number2);
}
void ZadachaAlt10()
{
    int number=157;
    if (number>99&&number<1000)// задали проверку на 3х значность числа
    {
        Console.WriteLine("Вторая цифра числа "+ (number/10%10));
    }
    else
    {
        Console.WriteLine("Введено не 3х значное число, повторите");
    }
}

void Zadacha13() //Задача 13.Написать программу, которая с помощью деления выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//654->4
//78->третьей цифры нет
{
    Console.WriteLine("Задача 13");
    Console.WriteLine();

    Random random = new Random();
    int number = random.Next(10, 150);
    if (number > 100)
    {
        int number1 = number % 100;
        int number2 = number1 % 10;
        Console.WriteLine("Введеное число: " + number + " Третья цифра: " + number2);
    }
    else
    {
        Console.WriteLine("Введеное число:" + number + " .Третьей цифры нет");
    }
}

void ZadachaAlt13()//Лучший способ решения  
{
    DateTime lastTime=DateTime.Now;// отображение какое количество времени требуется на решение задачи
    int number=45445666;
    number=Math.Abs(number);//Возведение числа в модуль Math.Abs в случае если введено отрицательное значение. В модуле оно станет положительным
    if (number > 100)
    {
        while (number >999) //Пока введеное число будет больше 999
        {
            number /=10;// мы будет выкидывать из него последнюю цифру. делить на десять и брать толко целую часть пока оно не станет 3х значным
            //Console.WriteLine(number);
        }
        Console.WriteLine(("Введеное число: " + number + " Третья цифра: " + number%10));
        Console.WriteLine(DateTime.Now - lastTime);//печать сколько времени ушло на решение задачи
    }
    else
    {
        Console.WriteLine("Введеное число:" + number + " .Третьей цифры нет");
        Console.WriteLine(DateTime.Now - lastTime);//печать сколько времени ушло на решение задачи
    }
}


void Zadacha15() // Задача 15. Написать программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли это день выходным
//6-> да
//1-> нет
{
    Console.WriteLine("Задача 15");
    Console.WriteLine();
    Random random = new Random();
    int number = random.Next(1, 7);

    if (number >= 6)
    {
        Console.WriteLine("День недели: " + number + " = Выходной ");
    }
    else
    {
        Console.WriteLine("День недели: " + number + " = Будни");
    }
}
void ZadachaAlt15()
{
    Console.WriteLine("Введите значение от 1 до 7");

    int day= Convert.ToInt32(Console.ReadLine());

    if(day>0 && day <8)
    {
        if(day==6 || day==7)
        {
            Console.WriteLine("Введеное день Выходной");
        }
        else
        {
            Console.WriteLine("Введеный день Рабочие будни");
        }
    }
    else
    {
        Console.WriteLine("Ввод не верный, повторите ввод");
    }

}
void ZadachaAlt15_1()//РЕШЕНИЕ ЧЕРЕЗ МАССИВ
{
    Console.WriteLine("Введите значение от 1 до 7");
    int day= Convert.ToInt32(Console.ReadLine());

    string [] week={"пн", "вт", "ср", "чт", "пт", "сб", "вс"};// массив обознач. [] скобками.Массив это тип данных стринг=строка

    Console.WriteLine(week[day-1]);// обращаемся к элементу week(обращение ко всем дням недели)[day-1] конкретное значение в элементе week, 
    //-1 значит что отнимает 1 т.к индексов у значений меньше на 1 значение
    if(day>0 && day <8)
    {
        if(day==6 || day==7)
        {
            Console.WriteLine("Введеное день Выходной");
        }
        else
        {
            Console.WriteLine("Введеный день Рабочие будни");
        }
    }
    else
    {
        Console.WriteLine("Ввод не верный, повторите ввод");
    }
}

//Zadacha10();
//ZadachaAlt10();
//Zadacha13();
//ZadachaAlt13();
//Zadacha15();
//ZadachaAlt15();
ZadachaAlt15_1();