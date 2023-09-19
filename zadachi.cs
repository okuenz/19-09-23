// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Begin1.
//Дана сторона квадрата а. Найти его периметр Р=4*а
/*Console.WriteLine("Введите сторону a");
int a = int.Parse(Console.ReadLine());
int p = 4 * a;
Console.WriteLine($"Периметр квадрата равен {p}");*/

//Begin2.
//Дана сторона квадрата a. Найти его площадь S = a^2
/*Console.WriteLine("Введите сторону a: ");
int a = int.Parse(Console.ReadLine());
int S = a*a;
Console.WriteLine($"Площадь квадрата равна {S}");*/

//Begin3.
//Даны стороны прямоугольника a и b. Найти его площад S = a·b и периметр P = 2·(a + b).
/*Console.WriteLine("Введите сторону a: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine($"Сторона a равна {a} ");
Console.WriteLine("Введите сторону b: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine($"Сторона b равна {b} ");
int S = a * b;
int P = 2*(a + b);
Console.WriteLine($"Площадь прямоугольника - {S}. Периметр прямоугольника - {P}");*/

//Begin4.
//Дан диаметр окружности d. Найти ее длину L = π·d.
//В качестве значения π использовать 3.14.
/*Console.WriteLine("Введите диаметр окружности: ");
int d = int.Parse(Console.ReadLine());
double pi = 3.14;
double L = pi * d;
Console.WriteLine($"Длина окружности {L}");*/

//Begin5.
//Дана длина ребра куба a.
//Найти объем куба V = a^3 и площадь его поверхности S = 6·a^2.
/*Console.WriteLine("Введите длину ребра куба ");
int a = int.Parse(Console.ReadLine());
int V = a * a * a;
int S = 6 * a * a;
Console.WriteLine($"Объем куба - {V}. Площадь его поверхности - {S}.");*/

//Begin6.
//Даны длины ребер a, b, c прямоугольного параллелепипеда.
//Найти его объем V = a·b·c и площадь поверхности S = 2·(a·b + b·c + a·c).
/*Console.WriteLine("Введите сторону a: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите сторону b: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите сторону c: ");
int c = int.Parse(Console.ReadLine());
int V = a * b * c;
int S = 2 * (a * b + b * c + a * c);
Console.WriteLine($"Объем прямоугольного параллелепипеда - {V}. Площадь его поверхности - {S}");*/

//Begin7.
//Найти длину окружности L и площадь круга S заданного радиуса R:
//L = 2·π·R, S = π·R^2.
//В качестве значения π использовать 3.14.
/*Console.WriteLine("Введите значение радиуса - ");
int R = int.Parse(Console.ReadLine());
double pi = 3.14;
double L = 2 * pi * R;
double S = pi * R * R;
Console.WriteLine($"Длина окружности - {L}. Площадь круга - {S}");*/

//Begin8.
//Даны два числа a и b. Найти их среднее арифметическое: (a + b) / 2
/*Console.WriteLine("Введите число a: ");
double a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b: ");
double b = int.Parse(Console.ReadLine());
double c = (a + b) / 2;
Console.WriteLine($"Среднее арифметическое - {c}");*/

//Begin9.
//Даны два неотрицательных числа a и b.
//Найти их среднее геометрическое,
//то есть квадратный корень из их произведения: √a·b.
/*Console.WriteLine("Введите два неотрицательных числа: ");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
if (a >= 0 && b >= 0)
{
    double c = Math.Sqrt(a * b);
    Console.WriteLine($"Среднее геометрическое чисел равно {c}");
}
else
{
    Console.WriteLine("Введите другие числа >:( ");
}  */

//Begin10.
//Даны два ненулевых числа.
//Найти сумму, разность, произведение и частное их квадратов.
/*Console.WriteLine("Введите два числа не равных 0: ");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
if (a == 0 && b == 0)
{
    int c = a + b;
    int d = a - b;
    int e = a * b;
    int f = a * a / b * b;
    Console.WriteLine($"Сумма - {c}. Разность - {d}. Произведение - {e}. Частное квадратов - {f}");
}
else
{
    Console.WriteLine("Вводи другие числа(((((((((((");
}*/

//Begin11.
//Даны два ненулевых числа. Найти сумму, разность, произведение и частное их модулей.
/*Console.WriteLine("Введите два числа не равных 0: ");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
if (a == 0 && b == 0)
{
    int c = a + b;
    int d = a - b;
    int e = a * b;
    int f = Math.Abs(a)/Math.Abs(b);
    Console.WriteLine($"Сумма - {c}. Разность - {d}. Произведение - {e}. Частное модулей - {f}");
}
else
{
    Console.WriteLine("Вводи другие числа(((((((((((");
}*/

//Begin12.
//Даны катеты прямоугольного треугольника a и b.
//Найти его гипотенузу c и периметр P.
//c =√a^2 + b^2
//P = a + b + c.
/*Console.WriteLine("Введите значение двух катетов: ");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
double c = Math.Sqrt(a * a + b * b);
double P = a + b + c;
Console.WriteLine($"Третий катет - {c}. Периметр - {P}.");*/

//Begin13.
//Даны два круга с общим центром и радиусами R1 и R2 (R1 > R2).
//Найти площади этих кругов S1 и S2, а также площадь S3 кольца, внешний
//радиус которого равен R1, а внутренний радиус равен R2:
//S1 = π·(R1)^2
//S2 = π·(R2)^2
//S3 = S1 − S2.
/*double pi = 3.14;
Console.WriteLine("Введите значение для двух радиусов: ");
int R1 = int.Parse(Console.ReadLine());
int R2 = int.Parse(Console.ReadLine());
if (R1 > R2)
{
    double S1 = pi * R1 * R1;
    double S2 = pi * R2 * R2;
    double S3 = S1 - S2;
    Console.WriteLine($"Площадь первого круга - {S1}. Площадь второго круга - {S2}. Площадь третьего круга - {S3}");
}
else
{
    Console.WriteLine("Вводи другие числа.");
}*/

//Begin14.
//Дана длина L окружности.
//Найти ее радиус R и площадь S круга,
//ограниченного этой окружностью, учитывая, что L = 2·π·R, S = π·R^2
//В качестве значения π использовать 3.14.
/*double pi = 3.14;
Console.WriteLine("Введите длину окружности: ");
double L = double.Parse(Console.ReadLine());
double R = L / 2 * pi;
double S = pi * R * R;
Console.WriteLine($"Радиус - {R}. Площадь - {S}.");*/

//Begin15◦
//Дана площадь S круга. Найти его диаметр D и длину L окружности,
//ограничивающей этот круг, учитывая, что L = 2·π·R, S = π·R^2
//В качестве
//значения π использовать 3.14
/*double pi = 3.14;
Console.WriteLine("Введите площадь круга: ");
double S = double.Parse(Console.ReadLine());
double R = Math.Sqrt(S/pi);
double D = R + R;
double L = 2*pi*R;
Console.WriteLine($"Длина окружности - {L}. Диаметр - {D}.");*/

//Begin16.
//Найти расстояние между двумя точками с заданными координатами x1 и x2 на числовой оси:
//| x2 − x1 |.
/*Console.WriteLine("Введите два числа: ");
int x1 = int.Parse(Console.ReadLine());
int x2 = int.Parse(Console.ReadLine());
int x = Math.Abs(x1 - x2);
Console.WriteLine($"Расстояние - {x}");*/

//Begin17.
//Даны три точки A, B, C на числовой оси.
//Найти длины отрезков AC и BC и их сумму.
/*Console.WriteLine("Введите три числа: ");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
int AC = Math.Abs(a + c);
int BC = Math.Abs(b + c);
int Summ = AC + BC;
Console.WriteLine($"Длина отрезка АС - {AC}. Длина отрезка ВС - {BC}. Сумма отрезков - {Summ}");*/

//Begin18.
//Даны три точки A, B, C на числовой оси.
//Точка C расположена между точками A и B.
//Найти произведение длин отрезков AC и BC.
/*Console.WriteLine("Введите значения трех точек: ");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
if (c > b && c < a)
{
    int AC = Math.Abs(a + b);
    int BC = Math.Abs(a + b);
    int D = AC * BC;
    Console.WriteLine($"Произведение длинн отрезков - {D}");
}
else 
{
    Console.WriteLine("Введите другое значение");
}*/









