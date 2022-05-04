/* Задача 24: Напишите программу, которая
принимает на вход число (А) и выдаёт сумму чисел
от 1 до А.
7 -> 28
4 -> 10
8 -> 36 */

/* Console.Write("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for(int i = 1;i <= number; i++)
{
    sum += i; // += - это sum + i
}
Console.WriteLine("Sum of numbers is: " + sum); */

int number;

Console.Write("Please enter positive ineger number: ");
while (!int.TryParse(Console.ReadLine(), out number) || number < 0) //введенную строку записать в переменную до тех пор пока не успешно строка преобразована в число, я буду повторять попытку ввода до тех пор пока это не будет число и не будет положительным. проверка на буквы и отрицательные, если будет так,то будет повторять ввести верное число
{
    Console.WriteLine("Wrong number, try again");
    Console.Write("Please enter positive ineger number: ");
}

int sum = 0;
for(int i = 1;i <= number; i++)
{
    sum += i;
}
Console.WriteLine("Sum of numbers is: " + sum); 