Console.WriteLine("Определение является ли число четным");

Console.Write("Введите любое целое число:   ");
Console.Write("f = ");
int f = Convert.ToInt32(Console.ReadLine());

if (f % 2 ==0)
  {
  Console.Write("Число " + f + " является четным");
  }
else
  {
  Console.Write("Число " + f + " является нечетным");
  } 