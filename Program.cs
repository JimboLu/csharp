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
        tester.TestDictionary();
        tester.TestList();
        tester.TestHashSet();
        Console.ReadLine();

        /* 测试结果
        --------Testing dictionary--------
        --------Using Time: 0ms--------
        --------Testing List--------
        --------Using Time: 670.8012ms--------
        --------Testing HashSet--------
        --------Using Time: 0ms-------- 

           结论
        1、Dictionary<TKey, TValue>、List<T>、HashSet<T>都是顺序存储，因为内部提供了迭代器。
        2、但是Dictionary<TKey, TValue>和HashSet<T>都是根据HashCode来选择存储位置的，
        所以能提供更高效的查询速度，最理想的查询时间复杂度是O(1). */
        
        tester.TestReflection();
        Console.ReadLine();

        /* 测试结果
         属性名 ：sex
         属性名 ：age
         属性名 ：height
         属性名 ：weight
         方法名 ：get_sex
         方法名 ：get_age
         方法名 ：get_height
         方法名 ：get_weight
         方法名 ：add_changedSex
         方法名 ：remove_changedSex
         方法名 ：add_changedAge
         方法名 ：remove_changedAge
         方法名 ：add_changedHeight
         方法名 ：remove_changedHeight
         方法名 ：add_changedWeight
         方法名 ：remove_changedWeight
         方法名 ：SetSex
         方法名 ：SetAge
         方法名 ：SetHeight
         方法名 ：SetWeight
         方法名 ：ToString
         方法名 ：Equals
         方法名 ：GetHashCode
         方法名 ：GetType
         事件名 ：changedSex
         事件名 ：changedAge
         事件名 ：changedHeight
         事件名 ：changedWeight
         */
    }
}
