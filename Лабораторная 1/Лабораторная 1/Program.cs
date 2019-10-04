using System;  //подключённая библиотека
using System.Collections.Generic;  //подключённая библиотека
using System.Linq;  //подключённая библиотека
using System.Text;  //подключённая библиотека
using System.Threading.Tasks;  //подключённая библиотека

namespace ConsoleApplication1  //подключение пространства имён
{
    class Program  //класс
    {

        static void Main(string[] args)  //метод класса
        {
            Console.WriteLine("Ковалев Сергей ИУ5-32Б");
            double a, b, c, D, x1, x2, x3, x4, t1, t2;

            D = 0;
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите первое число");
                    a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите второе число");
                    b = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите третье число");
                    c = double.Parse(Console.ReadLine());
                    if (a == 0)// при а равном 0
                    {
                        c = -1 * (c / b);
                        if (c < 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Нет корней");
                            Console.ReadKey();
                            System.Environment.Exit(0);
                        }
                        if (c == 0)
                        {
                            x1 = 0;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("x1 =  ");
                            Console.WriteLine(x1);
                            Console.ReadKey();
                            System.Environment.Exit(0);
                        }
                        if (c > 0)
                        {
                            x1 = Math.Sqrt(c);
                            x2 = -Math.Sqrt(c);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("x1 =  ");
                            Console.WriteLine(x1);
                            Console.Write("x2 =  ");
                            Console.WriteLine(x2);
                            Console.ReadKey();
                            System.Environment.Exit(0);
                        }
                    }
                    if (b == 0)// при б равном 0
                    {
                        c = -1 * (c / a);
                        if (c < 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Нет корней");
                            Console.ReadKey();
                            System.Environment.Exit(0);
                        }
                        if (c == 0)
                        {
                            x1 = 0;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("x1 =  ");
                            Console.WriteLine(x1);
                            Console.ReadKey();
                            System.Environment.Exit(0);
                        }
                        if (c > 0)
                        {
                            t1 = Math.Sqrt(c);
                            t2 = -Math.Sqrt(c);
                            if (t1 < 0)
                            {
                                x1 = Math.Sqrt(t2);
                                x2 = -Math.Sqrt(t2);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("x1 =  ");
                                Console.WriteLine(x1);
                                Console.Write("x2 =  ");
                                Console.WriteLine(x2);
                                Console.ReadKey();
                                System.Environment.Exit(0);
                            }
                            if (t2 < 0)
                            {
                                x1 = Math.Sqrt(t1);
                                x2 = -Math.Sqrt(t1);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("x1 =  ");
                                Console.WriteLine(x1);
                                Console.Write("x2 =  ");
                                Console.WriteLine(x2);
                                Console.ReadKey();
                                System.Environment.Exit(0);
                            }

                        }
                    }
                    if (c == 0)// при с равном 0
                    {
                        c = -1 * (b / a);
                        if (c < 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Нет корней");
                            Console.ReadKey();
                            System.Environment.Exit(0);
                        }
                        if (c == 0)
                        {
                            x1 = 0;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("x1 =  ");
                            Console.WriteLine(x1);
                            Console.ReadKey();
                            System.Environment.Exit(0);
                        }
                        if (c > 0)
                        {
                            x1 = 0;
                            x2 = Math.Sqrt(c);
                            x3 = -Math.Sqrt(c);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("x1 =  ");
                            Console.WriteLine(x1);
                            Console.Write("x2 =  ");
                            Console.WriteLine(x2);
                            Console.Write("x3 =  ");
                            Console.WriteLine(x3);
                            Console.ReadKey();
                            System.Environment.Exit(0);
                        }
                    }
                    D = (b * b) - 4 * a * c;
                    if (D > 0)// Дискриминант больше 0
                    {
                        t1 = (-b + Math.Sqrt(D)) / (2 * a);
                        t2 = (-b - Math.Sqrt(D)) / (2 * a);
                        x1 = Math.Sqrt(t1);
                        x2 = -Math.Sqrt(t1);
                        x3 = Math.Sqrt(t2);
                        x4 = -Math.Sqrt(t2);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Дескриминант =  ");
                        Console.WriteLine(D);
                        Console.Write("x1 =  ");
                        Console.WriteLine(x1);
                        Console.Write("x2 =  ");
                        Console.WriteLine(x2);
                        Console.Write("x3 =  ");
                        Console.WriteLine(x3);
                        Console.Write("x4 =  ");
                        Console.WriteLine(x4);
                        Console.ReadKey();
                        System.Environment.Exit(0);
                    }
                    if (D == 0)// Дискриминант равен 0
                    {
                        t1 = (-b) / (2 * a);
                        x1 = Math.Sqrt(t1);
                        x2 = -Math.Sqrt(t1);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Дескриминант =  ");
                        Console.WriteLine(D);
                        Console.Write("x1 =  ");
                        Console.WriteLine(x1);
                        Console.Write("x2 =  ");
                        Console.WriteLine(x2);
                        Console.ReadKey();
                        System.Environment.Exit(0);
                    }
                    if (D > 0)// Дискриминант меньше 0
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Нет корней");
                        Console.ReadKey();
                        System.Environment.Exit(0);
                    }
                }
                catch//если введено неправильное значение

                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Неправильное значение");
                    Console.ReadKey();
                    System.Environment.Exit(0);
                }
            }

        }

    }
}
