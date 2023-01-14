Console.Write("Нахождение большего и меньшего из двух чисел");

Console.Write("Введите целое число a = ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите целое число b = ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
  {
  Console.Write(" Большее число =  ");
  Console.Write(a);
  
  Console.Write(" Меньшее число =  ");
  Console.Write(b);
  }
else
  {
  Console.Write("Большее число =  ");
  Console.Write(b);
  
  Console.Write(" Меньшее число = ");
  Console.Write(a);
  } 