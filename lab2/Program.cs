using System;
/*
Разбить каждую строку на отдельные слова. 
Обрамить каждое слово в рамку из ASCII-символов ('|', '=' и пр.).

*/
public class Program
{
    public static void Main()
    {
        int x = 0, y = 0, n = 0, j = 0;

        init(ref x, ref y, ref n);
        if (checkInput(x, n)) return;

        double[] resul = new double[(int)10 / n + 1];
        int i = x;

        calc(x, y, n, ref resul, j, i);
    }

    static void calc(int x, int y, int n, ref double[] resul, int j, int i)
    {
        resul[j] = fun(i, y);
        Console.WriteLine("x = " + i + " \t\t| f(x) = " + resul[j].ToString());
        j++;
        i += n;

        if (i > x + 10 )
        {
            return;
        }
        else
        {
            calc(x, y, n, ref resul, j, i);
        }
    }

    static double fun(int x, int y)
    {
        if (x * y > 0)
        {
            return Math.Pow((x * x + y), 2) - Math.Pow((x * x * y), 1 / 2);
        }
        else if (x * y < 0)
        {
            return Math.Pow((x * x + y), 2) - Math.Pow(Math.Abs(x * x * y), 1 / 2);
        }
        else
        {
            return Math.Pow((x * x + y), 2) + 1;
        }
    }
    static void init(ref int x, ref int y, ref int n)
    {
        Console.WriteLine("Введите значения переменных: \nВведите x: ");
        Int32.TryParse(Console.ReadLine(), out x);
        Console.WriteLine("Введите y: ");
        Int32.TryParse(Console.ReadLine(), out y);
        Console.WriteLine("Введите шаг n: ");
        Int32.TryParse(Console.ReadLine(), out n);

    }


    static bool checkInput(int x, int n)
    {
        if (n <= 0)
        {
            Console.WriteLine("Ошибка: шаг n должен быть больше 0");
            return true;
        }
        if (n > Math.Abs(x) + 10)
        {
            Console.WriteLine("Ошибка: шаг n должен быть меньше или раным |x|+10");
            return true;
        }
        return false;
    }


}