using System;
using System.Collections.Generic;
using System.Text;

namespace ClassStudy
{
    class test
    {
        public static void Main1() {
            var names = new List<string>();
            names.Add("sdfd");
            names.Add("jhfg");
            foreach (var ret in names) {
                System.Console.Write(ret + " ");
            }

            //可以像数组定义那样进行初始化
            var name2 = new List<String> { "11","22","33"};
            foreach (var ret in name2)
            {
                System.Console.Write(ret + " ");
            }

        }
    }
}
