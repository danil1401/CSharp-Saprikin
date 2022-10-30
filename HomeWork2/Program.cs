Console.Clear();

void Zadacha10()//Задача 10. Написать программу, которая принимает на вход трехзначное число и на выходе показывает вторую чифру этого числа.
//456->5
{
Random random = new Random();
int number = random.Next(100, 1000);
/*Console.WriteLine("Введите число: ");
int number= Convert.ToInt32(Console.ReadLine());*/

int number1=number%100;
int number2=number1/10;
Console.WriteLine("Рандомное число: "+ number);
Console.WriteLine("Вторая цифра "+number+"= "+number2);
}



void Zadacha13()//Задача 13.Написать программу, которая с помощью деления выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//654->4
//78->третьей цифры нет
{
    Random random=new Random();
    int number =random.Next(10,150);
    if(number>100)
    {
    int number1= number%100;
    int number2=number1%10;
    Console.WriteLine("Введеное число: "+ number+ " Третья цифра: "+ number2);
    }
    else
    {
        Console.WriteLine("Введеное число:" +number+ " .Третьей цифры нет");
    }
    
}

void Zadacha15()// Задача 15. Написать программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли это день выходным
//6-> да
//1-> нет
{
Random random = new Random();
int number =random.Next(1, 7);

if (number>=6)
{
    Console.WriteLine("День недели: "+ number+ " = Выходной ");
}
else
{
    Console.WriteLine("День недели: "+ number+ " = Будни");
}
}

//Zadacha10();
Zadacha13();
//Zadacha15();