using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// 入口
/// </summary>
class Program
{
    /// <summary>
    /// 进程入口
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
        Tester tester = new Tester();
        tester.TestDicListHashSet();
        Console.ReadLine();
        tester.TestReflection();
        Console.ReadLine();
    }
}
