using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            //字符串，字符串连接
            string s1 = "hello";
            string s2 = "body";
            System.Console.WriteLine(s1 + " " + s2);
            System.Console.WriteLine("{0} {1}", s1, s2);
            System.Console.WriteLine("==========");

            //通过使用 string 构造函数
            char[] ch = { 'a' };
            String s11 = new String(ch);
            String s22 = "66";
            string s33=new string(ch);
            System.Console.WriteLine(s11);
            System.Console.WriteLine(s22);
            System.Console.WriteLine("===========");


            //关于String类的静态方法Join的具体博客(https://www.cnblogs.com/haley24/p/10074111.html)
            //方法返回字符串
            char[] ch1 = new char[5] { 'a', 'b', 'c', 'd', 'e' };
            String s111 = String.Join("+", ch1);
            System.Console.WriteLine("String类静态方法Join：：" + s111);
            System.Console.WriteLine("-------------");
            List<Char> listChar = new List<char>();
            List<String> listString = new List<String>();
            listChar.Add('A');
            listChar.Add('B');
            listChar.Add('C');
            listString.Add("AA");
            listString.Add("BB");
            listString.Add("CC");
            String test = String.Join("-", listChar);
            String test2 = String.Join("-", listString);
            System.Console.WriteLine("{0} $$$ {1}", test, test2);

            //用于转化值的格式化方法
            String str = String.Format("{0},{1},{2}", 1, "hh", 'A');
            System.Console.WriteLine(str);


            //String类的两个重要属性(Char  Length)
            //Char：在当前 String 对象中获取 Char 对象的指定位置 https://learn.microsoft.com/zh-cn/dotnet/api/system.string.chars?view=net-6.0
            //Length：获取字符串长度
            String str1 = "abcdefg";
            for (int i = 0; i < str.Length; i++) {
                System.Console.Write(str1[i] + " ");
            }

            System.Console.ReadKey();
        }
    }
}
