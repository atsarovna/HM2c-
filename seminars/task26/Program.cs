/* Задача 26: Напишите программу, которая принимает
на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5 */

//1 способ:через строку
/* Console.Write("Enter the number: ");
string number = Console.ReadLine();
int count = number.Length;
Console.WriteLine($"Count of numbers is: {count}"); */

//2 способ:через цикл for 
/* Console.Write("Enter the number: ");
string number = Console.ReadLine();
int count = 0;
for(int i = 0; i < number.Length; i++)
{
    count ++;
}
Console.WriteLine($"Count of numbers is: {count}");  */

//3 способ
/* Console.Write("Enter the number: ");
int number = Convert.ToInt32(Console.ReadLine());

int index = 0;
while(number > 0)
{
    number = number / 10; //считаем сколько раз делим - это количество цифр.например,456/10(1),450/10(2),400/10(3) = 3 цифры.// пока число делится на 10,Мы прибавляем 1 к счетчику
    index ++;
}
Console.WriteLine($"Count of numbers is: {index}"); */

//4 способ
Console.Write("Enter the number: ");
int number = Convert.ToInt32(Console.ReadLine());

int count = 0;

for(int numberTemp = number; numberTemp > 0; numberTemp /= 10, count++);  

Console.WriteLine($"Count of numbers in {number} = {count}");

//цикл for используется,когда нужно что-то перебрать или дойти до определенного значения
//цикл while используется,когда есть единственное условие и пока это условие повторяется нужно что-то делать. если в условии задачи есть "пока" или " до тех пор"