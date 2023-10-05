using System;
using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        StringBuilder b;

        if (args.Length > 0)
        {
            string fileName = @".\" + args[0];
            string outFile = @".\" + args[1];

            if (!File.Exists(fileName))
            {
                Console.WriteLine("Ошибка: Файл не существует");
                return;
            }

            string[] csFile = File.ReadAllLines(fileName);
 
            b = fun(csFile);
            File.WriteAllText(@".\" + outFile, b.ToString());
        }
        else
        {
            string s;
            int i = 0, n;

            Console.WriteLine("Введите количество строк и сами строки:");

            Int32.TryParse(Console.ReadLine(), out n);
            string[] arr = new string[n];

            while (i < n)
            {
                s = Console.ReadLine();
                if (s == "") break;
                arr[i] = s;

                i++;
            }

            b = fun(arr);

            string res = b.ToString();
            Console.WriteLine(res);
        }
 
    }

    static StringBuilder fun(string[] s)
    {

        StringBuilder b = new StringBuilder();

        foreach (var item in s)
        {
            string[] itemArr = item.Split(" ");
            string[] wordArr = new string[itemArr.Length+1];

            string[] item1 = new string[itemArr.Length+1];
            for (int i = 0; i < itemArr.Length; i++)
            {
                var word = itemArr[i];

                wordArr[i] = "|" + word + "|";
                item1[i] = new string('=', word.Length + 2);
            }

            b.AppendJoin(" ",item1);
            b.Append("\n");
            b.AppendJoin(" ",wordArr);
            b.Append("\n");
            b.AppendJoin(" ",item1);
            b.Append("\n\n"); 
        } 

        return b;
    }



}
