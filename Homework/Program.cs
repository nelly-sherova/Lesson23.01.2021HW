using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            /*{
                Console.WriteLine("ДЗ 1 Задание 2");
                Console.Write("A = "); int.TryParse(Console.ReadLine(), out int a);
                Console.Write("B = "); int.TryParse(Console.ReadLine(), out int b);
                int sum = 0;
                for (int i  = a + 1; i < b; i++) sum += i;
                Console.WriteLine($"Sum is {sum}");
                Console.WriteLine($"Нечетные значения  расположенные между {a} и {b}");
                for(int i  = a + 1; i < b; i++) if (i % 2 != 0) Console.Write($"{i} ");
            }
            {
                Console.WriteLine("\nДЗ 1 Задание 3");
                Console.WriteLine("Прямоугольник");
                Console.Write("Введите длину прямоугольника: "); int.TryParse(Console.ReadLine(), out int a);
                Console.Write("Введите ширину прямоугольника: "); int.TryParse(Console.ReadLine(), out int b);
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                for(int i=1; i<=a; i++)
                {
                    for(int j=1; j<=b; j++)
                    {
                       if ((i>1 && i<a) && (j>1 && j<b))Console.Write("  ");
                       else Console.Write("* ");
                    } 
                    Console.WriteLine();
                }
                Console.ForegroundColor = ConsoleColor.White;
            }
            {
                Console.WriteLine("Прямоугольный треугольник: ");
                Console.Write("Введите длину катета: "); int.TryParse(Console.ReadLine(), out int a);
                int b = a + 1;
                Console.ForegroundColor = ConsoleColor.Green;
                for (int i=1; i<=a; i++)
                {
                    for (int j=1; j<=b; j++)
                    {
                        if (i>=1 && i==(j-1) && j<b) Console.Write("*");
                        if (i>=1 && j==1) Console.Write("*");
                        if (i==a) Console.Write("*");
                        else Console.Write(" ");  
                    }
                    Console.WriteLine();
                }
                Console.ForegroundColor = ConsoleColor.White;
            }
            {
                Console.WriteLine("Равносторонний треугольник ");
                Console.Write("Введите сторону равностороннего треугольника: "); int.TryParse(Console.ReadLine(), out int a);
                int t = a;
                a = a*2+1;
                int ai=1;
                Console.ForegroundColor = ConsoleColor.Blue;
                for (int i=1; i<=t+1; i++)
                {
                    for (int j=1; j<=a; j++)
                    {
                        if (i==1 && j==a/2+1) Console.Write("*");
                        if (i==ai && j==t+1-ai && i!=1) Console.Write("*");
                        if (i==ai && j==t+1+ai-1 && i!=1) Console.Write("*");
                        if (i==t && j%2>0 && j<a-1 && j!=1 && j!=a-2) Console.Write("*");
                        else Console.Write(" ");      
                    }
                    Console.WriteLine();
                    if(ai<t)ai++;   
                }  
                Console.ForegroundColor = ConsoleColor.White;
            }
            {
                Console.WriteLine("Ромб");
                Console.Write("Введите сторону ромба: "); int.TryParse(Console.ReadLine(), out int a);
                a = a-1;
                Console.ForegroundColor = ConsoleColor.Yellow;
                for (int i=a; i>=-a; i--)
                {
                    for (int j=1; j<=Math.Abs(i); j++)Console.Write(" ");
                    for(int k=a; k>=Math.Abs(i); k--)
                    {
                        Console.Write("*");
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
                Console.ForegroundColor = ConsoleColor.White;
            }
            {
                Console.WriteLine("ДЗ1 Задание 4");
                double s = 1000;
                Console.Write("P = "); double.TryParse(Console.ReadLine(), out double p);    
                int k=0;
                do
                {
                    s =  s * (p / 100 + 1);
                    k++;
                }while (s <= 1100);
                Console.WriteLine($"k = {k} ");
                Console.WriteLine($"S = {s}");
            }*/
            {
                Console.WriteLine("ДЗ2 Задание 2");
                Console.Write("N = "); int.TryParse(Console.ReadLine(), out int n);
                int[] arr = new int[n];
                for (int i  = 0; i < arr.Length; i++)
                    arr[i] = new Random().Next(-9,9);
                Console.Write("Ваш массив: "); writeArray(arr);
                int max = arr[0], min = arr[0];
                double sum = 0;;
                Console.Write("\nНечетные значения вашего массива: ");
                for(int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] < min) min = arr[i];
                    if (arr[i] > max) max = arr[i];
                    sum+=arr[i];
                    if (arr[i] % 2 != 0) Console.Write($"{arr[i]} ");
                }
                Console.WriteLine($"\nМаксимальный элемент вашего массива: {max}");
                Console.WriteLine($"Минимальный элемент вашего массива: {min}");
                Console.WriteLine($"Сумма всех элементов массива: {sum}");
                Console.WriteLine($"Среднее арифметическое всех элементов: {sum / n}");
            }
            
        }
        static void writeArray(int[] arr)
        {
            foreach (var item in arr) Console.Write($"{item} ");
        }
    }
}
