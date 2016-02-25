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
    /// Dictionary<TKey, TValue> 性能测试
    /// </summary>
    public void TestDictionary()
    {
        // 实例化
        Dictionary<int, String> dictionary = new Dictionary<int, string>();

        // 开始测试Dictionary
        Console.WriteLine("--------Testing dictionary--------");

        // 记录测试开始时间
        DateTime start = DateTime.Now;

        // 记录测试增开始时间
        DateTime addStart = DateTime.Now;

        // 增
        for (int i  = 0; i < 10000; i++)
        {
            dictionary.Add(i, i.ToString());
        }

        // 记录测试增结束时间
        DateTime addEnd = DateTime.Now;
        
        // 打印日志
        TimeSpan span = addEnd - addStart;
        StringBuilder log = new StringBuilder("Add Useing Time: ");
        log.Append(span.TotalMilliseconds).Append("ms");
        Console.WriteLine(log);

        // 记录测试删除开始时间
        DateTime deleteStart = DateTime.Now;

        // 删
        for (int i = 0; i < 10000; i++)
        {
            dictionary.Remove(i);
        }

        // 记录测试删除结束时间
        DateTime deleteEnd = DateTime.Now;

        // 打印日志
        span = deleteEnd - deleteStart;
        log.Clear();
        log.Append("Delete Useing Time: ").Append(span.TotalMilliseconds).
            Append("ms");
        Console.WriteLine(log);

        // 记录测试改开始时间
        DateTime changeStart = DateTime.Now;

        // 改
        for (int i = 0; i < 10000; i++)
        {
            dictionary.Add(i, i.ToString());
        }
        for (int i = 0; i < dictionary.Count; i++)
        {
            dictionary[i] = (i + 1).ToString();
        }

        // 记录测试改结束时间
        DateTime changEnd = DateTime.Now;

        // 打印日志
        span = changEnd - changeStart;
        log.Clear();
        log.Append("Change Using Time: ").Append(span.TotalMilliseconds).
            Append("ms");
        Console.WriteLine(log);


        // 记录测试查开始时间
        DateTime checkStart = DateTime.Now;

        // 查
        for (int i = 1; i < 10000; i++)
        {
            if (dictionary.ContainsKey(i))
            {
                string str = null;
                dictionary.TryGetValue(i, out str);
            }
        }
        
        // 记录测试查结束时间
        DateTime checkEnd = DateTime.Now;

        // 打印日志
        span = checkEnd - checkStart;
        log.Clear();
        log.Append("Check Using Time: ").Append(span.TotalMilliseconds).
            Append("ms");
        Console.WriteLine(log);

        // 结束时间，取程序运行到此处的时间
        DateTime end = DateTime.Now;

        // 打印日志
        span = end - start;
        log.Clear();
        log.Append("All Using Time: ").Append(span.TotalMilliseconds).
            Append("ms");
        Console.WriteLine(log);

        /* 测试结果
         * --------Testing dictionary--------
         * Add Useing Time: 15.6ms
         * Delete Useing Time: 0ms
         * Change Using Time: 0ms
         * Check Using Time: 0ms
         * All Using Time: 15.6ms
         */
    }

    /// <summary>
    /// List<T> 性能测试
    /// </summary>
    public void TestList()
    {
        // 实例化
        List<String> list = new List<string>();

        // 开始测试List
        Console.Write("--------Testing List--------\r\n");

        // 开始时间，取程序运行到此处的时间
        DateTime start = DateTime.Now;

        // 记录测试增开始时间
        DateTime addStart = DateTime.Now;

        // 增
        for (int i = 1; i < 10000; i++)
        {
            list.Add(i.ToString());
        }

        // 记录测试增结束时间
        DateTime addEnd = DateTime.Now;
        
        // 打印日志
        TimeSpan span = addEnd - addStart;
        StringBuilder log = new StringBuilder("Add Using Time: ");
        log.Append(span.TotalMilliseconds).Append("ms");
        Console.WriteLine(log);

        // 记录删开始时间
        DateTime deleteStart = DateTime.Now;

        // 删
        for (int i = 0; i < 10000; i++)
        {
            list.Remove(i.ToString());
        }

        // 记录删结束时间
        DateTime deleteEnd = DateTime.Now;

        // 打印日志
        span = deleteEnd - deleteStart;
        log.Clear();
        log.Append("Delete Using Time: ").Append(span.TotalMilliseconds).
            Append("ms");
        Console.WriteLine(log);

        // 记录改开始时间
        DateTime changeStart = DateTime.Now;

        // 改
        for (int i = 0; i < 10000; i++)
        {
            list.Add(i.ToString());
        }
        for (int i = 0; i < 10000; i++)
        {
            list[i] = (i + 1).ToString();
        }

        // 记录改结束时间
        DateTime changeEnd = DateTime.Now;

        // 打印日志
        span = changeEnd - changeStart;
        log.Clear();
        log.Append("Change Using Time: ").Append(span.TotalMilliseconds).
            Append("ms");
        Console.WriteLine(log);
        // 记录查开始时间
        DateTime checkStart = DateTime.Now;

        // 查
        for (int i = 0; i < 10000; i++)
        {
            list.Find((String str) => str == i.ToString());
        }

        // 记录查结束时间
        DateTime checkEnd = DateTime.Now;

        // 打印日志
        span = checkEnd - checkStart;
        log.Clear();
        log.Append("Check Using Time: ").Append(span.TotalMilliseconds).
            Append("ms");
        Console.WriteLine(log);

        // 结束时间，取程序运行到此处的时间
        DateTime end = DateTime.Now;
        span = end - start;
        log.Clear();
        log.Append("All Using Time: ").Append(span.TotalMilliseconds).Append("ms");
        Console.WriteLine(log);

        /* 测试结果
         * --------Testing List--------
         * Add Using Time: 0ms
         * Delete Using Time: 31.2ms
         * Change Using Time: 0ms
         * Check Using Time: 7070.8127ms
         * All Using Time: 7102.0127ms
         */
    }

    /// <summary>
    /// HashSet<T> 性能测试
    /// </summary>
    public void TestHashSet()
    {
        // 实例化
        HashSet<String> hashSet = new HashSet<string>();

        // 开始测试HashSet
        Console.Write("--------Testing HashSet--------\r\n");

        // 开始时间，取程序运行到此处的时间
        DateTime start = DateTime.Now;

        // 记录测试增的开始时间
        DateTime addStart = DateTime.Now;

        // 增
        for (int i = 0; i < 10000; i++)
        {
            hashSet.Add(i.ToString());
        }

        // 记录测试增的结束时间
        DateTime addEnd = DateTime.Now;

        // 打印日志
        TimeSpan span = addEnd - addStart;
        StringBuilder log = new StringBuilder("Add Using Time: ");
        log.Append(span.TotalMilliseconds).Append("ms");
        Console.WriteLine(log);

        // 记录开始测试删的开始时间
        DateTime deleteStart = DateTime.Now;
        
        // 删
        for (int i = 0; i < 10000; i++)
        {
            hashSet.Remove(i.ToString());
        }

        // 记录开始测试删的结束时间
        DateTime deleteEnd = DateTime.Now;

        // 打印日志
        span = deleteEnd - deleteStart;
        log.Clear();
        log.Append("Delete Using Time: ").Append(span.TotalMilliseconds).
            Append("ms");
        Console.WriteLine(log);

        // 记录开始测试改的时间
        DateTime changeStart = DateTime.Now;

        // 改
        for (int i = 0; i < 10000; i++)
        {
            hashSet.Add(i.ToString());
        }
        for (int i = 0; i < 10000; i++)
        {
            hashSet.Remove(i.ToString());
            hashSet.Add((-i).ToString());
        }

        // 记录结束测试改的时间
        DateTime chengeEnd = DateTime.Now;

        // 打印日志
        span = chengeEnd - changeStart;
        log.Clear();
        log.Append("Change Using Time: ").Append(span.TotalMilliseconds).
            Append("ms");
        Console.WriteLine(log);

        // 记录测试开始查的时间
        DateTime checkStart = DateTime.Now;

        // 查
        for (int i  = 0; i < 10000; i++)
        {
            if (hashSet.Contains(i.ToString()))
            { 

            }
        }

        // 记录测试结束查的时间
        DateTime checkEnd = DateTime.Now;

        // 打印日志
        span = chengeEnd - checkStart;
        log.Clear();
        log.Append("Check Using Time: ").Append(span.TotalMilliseconds).
            Append("ms");
        Console.WriteLine(log);

        // 结束时间，取程序运行到此处的时间
        DateTime end = DateTime.Now;

        // 打印日志
        span = end - start;
        log = new StringBuilder();
        log.Append("All Using Time: ").Append(span.TotalMilliseconds).
            Append("ms");
        Console.Write(log);

        /* 测试结果
         *
         * --------Testing HashSet--------
         * Add Using Time: 15.6ms
         * Delete Using Time: 0ms
         * Change Using Time: 0ms
         * Check Using Time: 0ms
         * All Using Time: 15.6ms
         */
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

        /* 测试结果
         * 属性名 ：sex
         * 属性名 ：age
         * 属性名 ：height
         * 属性名 ：weight
         * 方法名 ：get_sex
         * 方法名 ：get_age
         * 方法名 ：get_height
         * 方法名 ：get_weight
         * 方法名 ：add_changedSex
         * 方法名 ：remove_changedSex
         * 方法名 ：add_changedAge
         * 方法名 ：remove_changedAge
         * 方法名 ：add_changedHeight
         * 方法名 ：remove_changedHeight
         * 方法名 ：add_changedWeight
         * 方法名 ：remove_changedWeight
         * 方法名 ：SetSex
         * 方法名 ：SetAge
         * 方法名 ：SetHeight
         * 方法名 ：SetWeight
         * 方法名 ：ToString
         * 方法名 ：Equals
         * 方法名 ：GetHashCode
         * 方法名 ：GetType
         * 事件名 ：changedSex
         * 事件名 ：changedAge
         * 事件名 ：changedHeight
         * 事件名 ：changedWeight
         */
    }
}
