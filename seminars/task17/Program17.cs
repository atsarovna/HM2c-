// напишите программу, которая принимает на вход координаты точки (x и y), причем x не равно 0 и y не равно 0 
// и выдает номер четверти плоскости, в которой находится эта точка
Console.Write("Enter coordinates (x): ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter coordinates (y): ");
int y = Convert.ToInt32(Console.ReadLine());

int q = getQuadrant(x,y);

if (q == 0) {
    Console.WriteLine("This point is on a ax");
} else {
    Console.WriteLine("This point is in quadrant #" + q);
}

//функция, которая будет определять номер квадранта
int getQuadrant(int x, int y) //имя функции и два аргумента-координаты точки и возвращает номер квадранта,т.е. целое число
{
    if (x > 0 && y > 0)
        return 1; //говорим,что это первый квадрант
    else if (x < 0 && y > 0)
        return 2;
    else if (x < 0 && y < 0)
        return 3;
    else if (x > 0 && y < 0)
        return 4;
    else
        return 0;
}

// либо без else можно. return - прекращение выполнения функции/вовзрат из нее, то есть дальше идти не надо.
//{
 //   if (x > 0 && y > 0)
//      return 1; //говорим,что это первый квадрант
 //   if (x < 0 && y > 0)
 //       return 2;
 //   if (x < 0 && у < 0)
 //       return 3;
 //   if (x > 0 && y < 0)
 //       return 4;
    
 //   return 0;
//}
