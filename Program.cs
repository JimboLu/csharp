using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// 1、Dictionary<T,T>、List<T>、HashSet<T>性能测试。
/// 2、反射测试。
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        // 实例化
        Dictionary<string, string> dictionary = new Dictionary<string, string>();
        List<string> list = new List<string>();
        HashSet<string> hashSet = new HashSet<string>();

        // 添加一些测试数据
        for (int i = 1; i < 1000; i++)
        {
            dictionary.Add(i.ToString(), i.ToString());
            list.Add(i.ToString());
            hashSet.Add(i.ToString());
        }

        // 开始测试Dictionary
        Console.Write("------------------Testing dictionary------------------\r\n");
        // 开始时间，取程序运行到此处的时间
        DateTime start = DateTime.Now;
        for (int i = 1; i < 1000; i++)
        {
            string str = null;
            dictionary.TryGetValue(i.ToString(), out str);
        }
        // 结束时间，取程序运行到此处的时间
        DateTime end = DateTime.Now;
        TimeSpan span = end - start;
        StringBuilder log = new StringBuilder("------------------Using Time: ");
        log.Append(span.TotalMilliseconds.ToString()).Append("ms------------------\r\n");
        Console.Write(log);

        // 开始测试List
        Console.Write("------------------Testing List------------------\r\n");
        // 开始时间，取程序运行到此处的时间
        start = DateTime.Now;
        for (int i = 1; i < 1000; i++)
        {
            string str = null;
            for (int j = 0; j < list.Count; j++)
            {
                if (null != list[j] && j.ToString() == list[j])
                {
                    str = list[j];
                    break;
                }
            }
        }
        // 结束时间，取程序运行到此处的时间
        end = DateTime.Now;
        span = start - end;
        log.Clear();
        log.Append("------------------").Append(span.TotalMilliseconds).Append("ms------------------\r\n");
        Console.Write(log);

        // 开始测试HashSet
        Console.Write("------------------Testing HashSet------------------\r\n");
        // 开始时间，取程序运行到此处的时间
        start = DateTime.Now;
        for (int i = 1; i < 1000; i++)
        {
            if (hashSet.Contains(i.ToString()))
            {

            }
        }
        // 结束时间，取程序运行到此处的时间
        end = DateTime.Now;
        span = end - start;
        log.Clear();
        log.Append("------------------").Append(span.TotalMilliseconds).Append("ms------------------\r\n");
        Console.Write(log);
        
        /// 测试结果
        /// -------------------Testing dictionary--------------------
        /// ------------------Using Time: 0ms------------------
        /// -------------------Testing List--------------------
        /// ------------------Using Time: 156.0003ms------------------
        /// -------------------Testing HashSet--------------------
        /// ------------------Using Time: 135.8009ms------------------
        /// 结论
        /// Dictionary<TKey, TValue>可以根据Key提供高效的查询，理想状态是o(1)的时间复杂度，但Key值不能重复，Key值重复反而会使得查询效率大大降低--哈希查找的缘故
        /// List<T>是顺序存储，虽然public List<T>.Enumerator GetEnumerator()能提供迭代查询，但是其中的insert操作会使得迭代器失效，同时也实现了Sort()方法
        /// HashSet<T>也是顺序存储，只提供了public HashSet<T>.Enumerator GetEnumerator();迭代器查询，并未提供insert方法，也没有提供Sort()方法
        /// 本来估计HashSet<T>采用迭代器查询应该会比List<T>速度快的，可能是数据范围较小的原因，使得测试结果没有拉开
        /// 但是采用迭代查询会在内存中每一次迭代产生24字节的内存垃圾，因为迭代器是接口类型，在迭代的时候向接口转型是在堆上开辟的

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
