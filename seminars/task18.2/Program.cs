// Напишите программу, которая по заданному номеру четверти, показывает диапазон 
// возможных координат точек этой четверти (x и y) 

// Чтобы выделить сразу весь текст - использовать /* и */ без // на каждой строке

/*Console.Write("Enter quater from 1 to 4: ");
int quarter = Convert.ToInt32(Console.ReadLine());

if (quarter == 1)
{
    Console.WriteLine("range of coordinates for X from 0 to +infinity");
    Console.WriteLine("range of coordinates for Y from 0 to +infinity");
}
if (quarter == 2)
{
    Console.WriteLine("range of coordinates for X from -infinity to 0");
    Console.WriteLine("range of coordinates for Y from 0 to +infinity");
}
if (quarter == 3)
{
    Console.WriteLine("range of coordinates for X from -infinity to 0");
    Console.WriteLine("range of coordinates for Y from -infinity to 0");
}
if (quarter == 4)
{
    Console.WriteLine("range of coordinates for X from 0 to +infinity");
    Console.WriteLine("range of coordinates for Y from -infinity to 0");
}
if (quarter < 1 || quarter > 4)
{
    Console.WriteLine("Enter correct number of quarter");
}
*/

//решение 2
/*Console.Write("Enter quater from 1 to 4: ");
int quarter = Convert.ToInt32(Console.ReadLine());

if (quarter < 1 || quarter > 4)
{
    Console.WriteLine("Enter correct number of quarter");
    return;
}
GetCoordinates(quarter);
//метод
void GetCoordinates(int quater)
{
    if (quarter == 1)
    {
        Console.WriteLine($"X = from 1 to + {Int64.MaxValue} \nY = from 1 to +{Int64.MaxValue}"); //\nY - это перенос на новую строку. вместо Y можно указать любое значение
        Console.WriteLine("range of coordinates for Y from 0 to +infinity");
    }
    if (quarter == 2)
    {
        Console.WriteLine($"X = from -{Int64.MaxValue} to 0 \nY = from 0 to +{Int64.MaxValue}");
    }
    if (quarter == 3)
    {
        Console.WriteLine($"X = from {Int64.MaxValue} to 0 \nY = from -{Int64.MaxValue} to 0");
    }
    if (quarter == 4)
    {
        Console.WriteLine($"X = from 0 to +{Int64.MaxValue} \nY = -{Int64.MaxValue} to 0");
    }
}
*/

// решение 3

/*Console.Write("Enter quater from 1 to 4: ");
int quarter = Convert.ToInt32(Console.ReadLine());

if (quarter <= 0 || quarter >= 5)
{
    Console.WriteLine("Enter correct number of quarter");
    return;
}

if (quarter == 1)
{
    Console.WriteLine($"Range for quarter № {quarter} - x (0, {Int16.MaxValue}) и y (0, {Int16.MaxValue})");
}
if (quarter == 2)
{
    Console.WriteLine($"Range for quarter № {quarter} - x ({Int16.MinValue}, 0) и y (0, {Int16.MaxValue})");
}
if (quarter == 3)
{
    Console.WriteLine($"Range for quarter № {quarter} - x ({Int16.MinValue}, 0) и y ({Int16.MinValue}, 0)");
}
if (quarter == 4)
{
    Console.WriteLine($"Range for quarter № {quarter} - x (0, {Int16.MaxValue}) и y ({Int16.MinValue}, 0)");
}
*/

// решение 4
Console.Write("Enter quater from 1 to 4: ");
int quarter = Convert.ToInt32(Console.ReadLine());

if (quarter < 1 || quarter > 4)
{
    Console.WriteLine("Enter correct number of quarter");
    return;
}

int minX = 0;
int minY = 0;
int maxX = 0;
int maxY = 0;

if (quarter == 1)
{
    minX = 1;
    minY = 1;
    maxX = Int16.MaxValue;
    maxY = Int16.MaxValue;
}
if (quarter == 2)
{
    minX = Int16.MinValue;
    minY = 1;
    maxX = -1;
    maxY = Int16.MaxValue;
}
if (quarter == 3)
{
    minX = Int16.MinValue;
    minY = Int16.MinValue;
    maxX = -1;
    maxY = -1;
}
if (quarter == 4)
{
    minX = 1;
    minY= Int16.MinValue;
    maxX = Int16.MaxValue;
    maxY = -1;
}
Console.WriteLine($"Range X is: from {minX} to {maxX}");
Console.WriteLine($"Range Y is: from {minY} to {maxY}");

