using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// 测试者
/// </summary>
public class Tester
{
    /// <summary>
    /// 构造函数
    /// </summary>
    public Tester()
    {

    }

    /// <summary>
    /// Dictionary<TKey, TValue>、List<T>、HashSet<T>性能测试
    /// </summary>
    public void TestDicListHashSet()
    {
        // 实例化
        Dictionary<string, string> dictionary = new Dictionary<string, string>();
        List<string> list = new List<string>();
        HashSet<string> hashSet = new HashSet<string>();

        // 添加一些测试数据
        for (int i = 1; i < 10000; i++)
        {
            dictionary.Add(i.ToString(), i.ToString());
            list.Add(i.ToString());
            hashSet.Add(i.ToString());
        }

        // 开始测试Dictionary
        Console.Write("--------Testing dictionary--------\r\n");
        // 开始时间，取程序运行到此处的时间
        DateTime start = DateTime.Now;
        for (int i = 1; i < 10000; i++)
        {
            if (dictionary.ContainsKey(i.ToString()))
            {
                string str = null;
                dictionary.TryGetValue(i.ToString(), out str);
            }
        }
        // 结束时间，取程序运行到此处的时间
        DateTime end = DateTime.Now;
        TimeSpan span = end - start;
        StringBuilder log = new StringBuilder("Using Time: ");
        log.Append(span.TotalMilliseconds.ToString()).Append("ms\r\n");
        Console.Write(log);

        // 开始测试List
        Console.Write("--------Testing List--------\r\n");
        // 开始时间，取程序运行到此处的时间
        start = DateTime.Now;
        for (int i = 1; i < 10000; i++)
        {
            if (list.Contains(i.ToString()))
            {

            }
        }
        // 结束时间，取程序运行到此处的时间
        end = DateTime.Now;
        span = end - start;
        log.Clear();
        log.Append("Using Time: ").Append(span.TotalMilliseconds).Append("ms\r\n");
        Console.Write(log);

        // 开始测试HashSet
        Console.Write("--------Testing HashSet--------\r\n");
        // 开始时间，取程序运行到此处的时间
        start = DateTime.Now;
        for (int i = 1; i < 10000; i++)
        {
            if (hashSet.Contains(i.ToString()))
            {

            }
        }
        // 结束时间，取程序运行到此处的时间
        end = DateTime.Now;
        span = end - start;
        log.Clear();
        log.Append("Using Time: ").Append(span.TotalMilliseconds).Append("ms\r\n");
        Console.Write(log);

        /// 测试结果
        /// --------Testing dictionary--------
        /// --------Using Time: 15.6ms--------
        /// --------Testing List--------
        /// --------Using Time: 670.8012ms--------
        /// --------Testing HashSet--------
        /// --------Using Time: 0ms--------
        /// 结论
        /// 1、Dictionary<TKey, TValue>、List<T>、HashSet<T>都是顺序存储，因为内部提供了迭代器。
        /// 2、但是Dictionary<TKey, TValue>和HashSet<T>都是根据HashCode来选择存储位置的，
        /// 所以能提供更高效的查询速度，最理想的查询时间复杂度是O(1).
    }

    /// <summary>
    /// 反射测试
    /// </summary>
    public void TestReflection()
    {
        Person p = new Person("girl", 18, 160, 50);
        //Type type = typeof(Person);
        Type type = p.GetType();
        /// 反射来获取属性
        foreach (System.Reflection.PropertyInfo pi in type.GetProperties())
        {
            /// 测试时使用字符串连接，正式环境请勿使用字符串连接
            Console.Write("属性名：" + pi.Name + "\r\n");
        }
        /// 反射来获取方法名
        foreach (System.Reflection.MethodInfo mi in type.GetMethods())
        {
            /// 测试时使用字符串连接，正式环境请勿使用字符串连接
            Console.Write("方法名: " + mi.Name + "\r\n");
        }
        /// 反射来获取事情
        foreach (System.Reflection.EventInfo ei in type.GetEvents())
        {
            /// 测试时使用字符串连接，正式环境请勿使用字符串连接
            Console.Write("事件名: " + ei.Name + "\r\n");
        }

        /// 测试结果
        /// 属性名 ：sex
        /// 属性名 ：age
        /// 属性名 ：height
        /// 属性名 ：weight
        /// 方法名 ：get_sex
        /// 方法名 ：get_age
        /// 方法名 ：get_height
        /// 方法名 ：get_weight
        /// 方法名 ：add_changedSex
        /// 方法名 ：remove_changedSex
        /// 方法名 ：add_changedAge
        /// 方法名 ：remove_changedAge
        /// 方法名 ：add_changedHeight
        /// 方法名 ：remove_changedHeight
        /// 方法名 ：add_changedWeight
        /// 方法名 ：remove_changedWeight
        /// 方法名 ：SetSex
        /// 方法名 ：SetAge
        /// 方法名 ：SetHeight
        /// 方法名 ：SetWeight
        /// 方法名 ：ToString
        /// 方法名 ：Equals
        /// 方法名 ：GetHashCode
        /// 方法名 ：GetType
        /// 事件名 ：changedSex
        /// 事件名 ：changedAge
        /// 事件名 ：changedHeight
        /// 事件名 ：changedWeight
    }
}
