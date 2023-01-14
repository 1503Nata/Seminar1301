Console.WriteLine("Определить все четные числа от 1 до N");

Console.Write("Введите любое целое число:   ");
Console.Write("N = ");
int N = Convert.ToInt32(Console.ReadLine());
int i=1;

Console.Write("Числовой ряд четных чисел:   ");
while (i<=N-1)   
{
  if ( i % 2 == 1)
     { 
      Console.Write(i+1 + "  ");
     }      
  if ( i % 2 == 0)
     { 
      Console.Write(i + "  ");
     }      
i=i+2;
}      
