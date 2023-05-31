# c1-calculator
C#计算器
using System;
这行代码引入了System命名空间，其中包含了Console类等基本输入输出功能。
namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // 主程序的入口点，程序从这里开始执行
这部分代码定义了一个名为Calculator的命名空间，其中包含了一个名为Program的类。在这个类中，我们定义了一个Main方法，这是程序的入口点，程序从这里开始执行。
Console.WriteLine("欢迎使用黄文定计算器！");
使用Console.WriteLine函数在控制台上输出欢迎消息。
while (true)
{
    // 无限循环，直到用户选择退出
使用一个while循环来创建一个无限循环。程序将在用户选择退出时中断循环。
Console.WriteLine("请输入第一个数字：");
double num1 = Convert.ToDouble(Console.ReadLine());
提示用户输入第一个数字，并使用Convert.ToDouble方法将用户输入的字符串转换为double类型的数值，并将其赋值给num1变量。
Console.WriteLine("请输入运算符 (+, -, *, /)：");
char op = Convert.ToChar(Console.ReadLine());
这部分代码提示用户输入运算符，并使用Convert.ToChar方法将用户输入的字符串转换为char类型，并将其赋值给op变量。
Console.WriteLine("请输入第二个数字：");
double num2 = Convert.ToDouble(Console.ReadLine());
提示用户输入第二个数字，并使用Convert.ToDouble方法将用户输入的字符串转换为double类型的数值，并将其赋值给num2变量。
double result = 0;
这行代码定义一个名为result的变量，用于存储计算结果，默认初始化为0。
switch (op)
{
    // 根据运算符执行相应的操作
使用switch语句根据运算符执行相应的操作。根据用户输入的运算符，程序将执行不同的代码块。
case '+':
    result = num1 + num2;
    break;
如果运算符是+，则将num1和num2相加，将结果赋值给result变量。
case '-':
    result = num1 - num2;
    break;
如果运算符是-，则将num1减去num2，将结果赋值给result变量。
case '*':
    result = num1 * num2;
    break;
如果运算符是*，则将num1和num2相乘，将结果赋值给result变量。
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
如果运算符是/，则将num1除以num2，将结果赋值给result变量。但是，如果num2为0，则输出错误消息并使用continue语句继续下一次循环，以便用户可以重新输入。
default:
    Console.WriteLine("错误：无效的运算符！");
    continue;
如果运算符不是以上任何一种情况，则输出错误消息，并使用continue语句继续下一次循环。
Console.WriteLine("结果：" + result);
这行代码将计算结果输出到控制台。
Console.WriteLine("继续计算吗？(Y/N)");
string choice = Console.ReadLine();
if (choice.ToUpper() != "Y")
{
    break;
}
询问用户是否要继续计算。用户可以输入Y继续计算，输入其他任何字符则退出循环，程序结束。
Console.WriteLine("感谢使用黄文定计算器！");
在程序结束时输出感谢消息。
    }
}
}
这部分代码是对应的大括号，用于结束命名空间、类和Main方法的定义。
