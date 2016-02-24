using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Clear();
            List<string> list = new List<string>();
            list.Clear();
            HashSet<string> hashSet = new HashSet<string>();
            hashSet.Clear();
            for (int i = 1; i < 1000; i++)
            {
                if (!dictionary.ContainsKey(i.ToString()))
                {
                    dictionary.Add(i.ToString(), i.ToString());
                }
                list.Add(i.ToString());
                hashSet.Add(i.ToString());
            }
            Console.Write("-------------------Testing dictionary--------------------\r\n");
            DateTime start = DateTime.Now;
            for (int i = 1; i < 1000; i++)
            {
                string str = null;
                dictionary.TryGetValue(i.ToString(), out str);
            }
            DateTime end = DateTime.Now;
            TimeSpan span = end - start;
            StringBuilder log = new StringBuilder("------------------Using Time: ");
            log.Append(span.TotalMilliseconds.ToString()).Append("ms------------------\r\n");
            Console.Write(log);
            Console.Write("-------------------Testing List--------------------\r\n");
            start = DateTime.Now;
            for (int i = 1; i < 1000; i++)
            {
                string str = null;
                for (int j = 0; j < list.Count; j++)
                {
                    if(null != list[j] && j.ToString() == list[j])
                    {
                        str = list[j];
                        break;
                    }
                }
            }
            end = DateTime.Now;
            span = start - end;
            log.Clear();
            log.Append("------------------").Append(span.TotalMilliseconds).Append("ms------------------\r\n");
            Console.Write(log);
            Console.Write("-------------------Testing HashSet--------------------\r\n");
            start = DateTime.Now;
            for (int i = 1; i < 1000; i++)
            {
                string str = null;
                foreach (string obj in hashSet)
                {
                    if(null != obj && i.ToString() == obj)
                    {
                        str = obj;
                    }
                }
            }
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
        }
    }
}
