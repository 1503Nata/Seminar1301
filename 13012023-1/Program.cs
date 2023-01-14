
Console.WriteLine("Нахождение максимального числа");

Console.WriteLine("Введите числа : ");
Console.Write("A = ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("B = ");
int B = Convert.ToInt32(Console.ReadLine());
Console.Write("C = ");
int C = Convert.ToInt32(Console.ReadLine());

int max=A;

if (B>max) max=B;
if (C>max) max=C;

Console.WriteLine("Максимальное из трех чисел -" + max);