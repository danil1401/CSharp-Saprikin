Console.Clear();

void Метод()
{
    /*Методы делятся на 2 вида:
    1. Процедуры-ничего нам не возращает(кинул камен в воду-процесс выполнился и нам ничего не вернулось)
    2. Функции (return)-возращает значение после обработки(мясорубка заложили мясо, получили фарш)
    
    Процедура(что бы не комментировать задачи иожно использовать процедуру.)*/

    void Zadacha() //-void это тип данных, т.е это процедура которая ничего не выводит(можно свернуть/развернуть)
    {
        //Вся задача между фигурными скобками
    }
}

void Zadacha9() //Задача 9. Напишите программу, которая выводи случайное число из отрезка [10,99] и показывает наибольшую цифру числа
{
    //Задача 9. Напишите программу, которая выводи случайное число из отрезка [10,99] и показывает наибольшую цифру числа
    //78->8
    Random random = new Random(); //Создаем переменную Тип Random с именем random= закладываем в него рандом случайного числа new Random();
    int number = random.Next(10, 99); // присваиваем имени random любое рандомное числа в заданном диапозоне random.Next(1,99);
    Console.WriteLine(number); // выводим рандомное числа обращаясь к имени random
    //двухзначное число это десятки и единицы->нужно создать переменные десятки и единицы
    int tens = number / 10;
    int ones = number % 10;
    Console.WriteLine(tens);
    Console.WriteLine(ones);

    if (tens > ones)
    {
        Console.WriteLine($"Число {tens} максимальное");
    }
    else if (tens < ones)
    {
        Console.WriteLine($"Число {ones} максимальное");
    }
    else
        Console.WriteLine("Числа равны");
}

void Zadacha11() //Задача 11. Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа
{ //456->46
    Random random = new Random();
    int number = random.Next(100, 1000);
    Console.WriteLine(number);
    int num1 = number / 100; //деля на 100 получается 1ая цифра
    int num2 = number % 10; //%10 остаток получается последняя цифра
    Console.WriteLine($"{num1} {num2}");
}

void Zadacha12() //Задача 12. Написать программу, которая будет принимать на вход 2 числа и выводить, является ли второе число кратным первому.
//Если числа 2 не кратно числу 1, то программа выводит остаток от деления.
/*
34,5->не кратно, остаток 4
16,4-> кратно
*/
{
    Console.WriteLine("Число 1: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Число 2: ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    if (num1 % num2 == 0) // первое число делим с остатком на 2ое
    {
        Console.WriteLine("Кратно");
    }
    else
    {
        Console.WriteLine($"Не кратно. Остаток= {num1 % num2}");
    }
}

void Zadacha14() //Задача 14. Написать программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
//14->нет
//161->да
//&= "И"
//&&= "И ИЛИ"
//||= "ИЛИ"
//sting number="15165431" || "одиндватри"- строка это массив символов у которых есть свой индекс 0 1 2 3 4...

/*DateTime lastTime=DateTime.Now;// отображение какое количество времени требуется на решение задачи
Console.WriteLine(DateTime.Now - lastTime);//печать сколько времени ушло на решение задачи
*/

{ 
    Console.WriteLine("Введите число для проверки кратности числам: ");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Число 1 для проверки кратности: ");
    int numb1=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Число 2 для проверки кратности: ");
    int numb2=Convert.ToInt32(Console.ReadLine());

    if(number%(numb1*numb2)==0)// делаем деление с отстатком, если остатка нет (==0(cтрогое равенство нулю)) то число является кратным введеному числу
    //так же кратность можно проверить произведение чисел (numb1*numb2) которые нужно проверить на кратность введеному числу
    //if(number%numb1==0 && number%numb2==0)- является СЛОЖНЫМ условием, можно использовать его

    {
        Console.WriteLine("Число "+ number+ " кратно числам: " + numb1+ " и " +numb2 );
    }
    else
    {
        Console.WriteLine($"Число {number} не кратно числам {numb1} и {numb2}");
    }
}

void Zadacha16() //Задача 16. Написать программу, которая принимает на вход два числа и проверяет, ялвялется ли одно число квадратом другого.
{
    
    /*Ввод можео записать в функцию
    int Input()
    {
        Console.WriteLine("Число 1: ");
        return Convert.ToInt32(Console.ReadLine());//return возвращает что указано в фунции, а далее присваиваем функцию
    }
    int numb1=Input();
    int numb2=Input();
    */

    Console.WriteLine("Число 1: ");
    int numb1=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Число 2: ");
    int numb2=Convert.ToInt32(Console.ReadLine());

    if(numb1==numb2*numb2)
    //if (numb1==numb2*numb2||numb2==numb1*numb1)
    {
        Console.WriteLine("Квадрат числа "+numb2+" = "+ numb2 *numb2);
        Console.WriteLine($"Число {numb2} является квадратом числа {numb1}");
    }
    else
    {
        Console.WriteLine($"Число {numb2} не явяляется квадратом {numb1}");
    }

}

//Zadacha9();//вызываем нужную задача
//Zadacha11();
//Zadacha12();
//Zadacha14();
Zadacha16();