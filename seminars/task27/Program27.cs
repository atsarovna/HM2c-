/* Задача 27: Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

int number;
Console.Write("Enter the number: ");
while (!int.TryParse(Console.ReadLine(), out number) || number < 0)
{
    Console.WriteLine("Wrong number, try again");
}

int sum = 0;

/* while(number > 0) */ for(int i = number;i > 0; i--) //считаем с конца
{
    sum = (number%10) + sum; //находим последнюю цифру числа(остаток от деления) и складываем с найденными последними цифрами числа в порядке очереди
    number = number / 10; //отбрасываем остаток,те избавляемся от последней цифры(целочисленное деление на 10)
}
Console.WriteLine("Sum of numbers is: " + sum);