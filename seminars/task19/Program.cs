/* Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да */

Console.Write("Enter 5 digit number: ");
int n = Convert.ToInt32(Console.ReadLine());
//проверка на отрицательные числа и на > 5 цифр в числе
if (n < 99999 && n > 0)
{
    int dig1 = n / 10000;
    int dig2 = (n / 1000) % 10;
    int dig4 = (n / 10) % 10;
    int dig5 = n % 10;
    if ((dig1 == dig5) && (dig2 == dig4))
        Console.WriteLine($"{n} -> Polindrom.");
    else
        Console.WriteLine($"{n} -> Not polindrom.");
}
else
    Console.WriteLine("Incorrect number.Enter 5 digit number: ");




















    // пыталась придумать другое решение, но не додумалась как правильно. оставляю для себя на будущее.

/* string number = n.ToString();
if(number.Length == 5) // проверка на 5 значное число
if(n<0) n=-n; //проверка на отрицательные числа



Console.WriteLine("Работает");
else
Console.WriteLine("Incorrect.Enter 5 digit number: "); */

/* int temp = n; // временная переменная со значением числа n
int rev = 0; // переменная для числа в обратном порядке

while (n > 0)
{
    /* int dig1 = n/1000;
    int dig2 = dig1 % 10;
    int dig4 = (n/10) % 10; */
/* int dig5 = n % 10; // 5 цифра
int rev = rev * 10 + dig5;
n = n/10;
}
if (temp == rev)
Console.WriteLine("Палиндром");   */