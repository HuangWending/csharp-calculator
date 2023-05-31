using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("欢迎使用黄文定计算器！");

            while (true)
            {
                Console.WriteLine("请输入第一个数字：");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("请输入运算符 (+, -, *, /)：");
                char op = Convert.ToChar(Console.ReadLine());

                Console.WriteLine("请输入第二个数字：");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double result = 0;

                switch (op)
                {
                    case '+':
                        result = num1 + num2;
                        break;
                    case '-':
                        result = num1 - num2;
                        break;
                    case '*':
                        result = num1 * num2;
                        break;
                    case '/':
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                        }
                        else
                        {
                            Console.WriteLine("错误：除数不能为0！");
                            continue;
                        }
                        break;
                    default:
                        Console.WriteLine("错误：无效的运算符！");
                        continue;
                }

                Console.WriteLine("结果：" + result);

                Console.WriteLine("继续计算吗？(Y/N)");
                string choice = Console.ReadLine();
                if (choice.ToUpper() != "Y")
                {
                    break;
                }
            }

            Console.WriteLine("感谢使用黄文定计算器！");
        }
    }
}
