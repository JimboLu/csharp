using System;

/// <summary>
/// Person类
/// 
/// </summary>
public class Person
{
    /// <summary>
    /// 性别
    /// </summary>
    public string Sex { get; private set; }

    /// <summary>
    /// 年龄
    /// </summary>
    public int Age { get; private set; }

    /// <summary>
    /// 身高
    /// </summary>
    public float Height { get; private set; }

    /// <summary>
    /// 体重
    /// </summary>
    public float Weight { get; private set; }

    delegate void ChangedSexHandler(string sex);

    delegate void ChangedAgeHandler(int age);

    delegate void ChangedHeightHandler(float height);

    delegate void ChangedWeightHandler(float weight);

    /// <summary>
    /// 性别发生改变
    /// </summary>
    public event ChangedSexHandler ChangedSex;

    /// <summary>
    /// 年龄发生改变
    /// </summary>
    public event ChangedAgeHandler ChangedAge;

    /// <summary>
    /// 身高发生改变
    /// </summary>
    public event ChangedHeightHandler ChangedHeight;

    /// <summary>
    /// 体重发生改变
    /// </summary>
    public event ChangedWeightHandler ChangedWeight;

    /// <summary>
    /// 构造函数
    /// </summary>
    /// <param name="sex">性别</param>
    /// <param name="age">年龄</param>
    /// <param name="height">身高</param>
    /// <param name="weight">体重</param>
    public Person(string sex, int age, float height, float weight)
    {
        this.Sex = sex;
        this.Age = age;
        this.Height = height;
        this.Weight = weight;
    }

    /// <summary>
    /// 性别发生改变
    /// </summary>
    /// <param name="sex"></param>
    public void SetSex(string sex)
    {
        this.Sex = sex;
        if(null != ChangedSex)
        {
            ChangedSex(sex);
        }
    }

    /// <summary>
    /// 年龄发生改变
    /// </summary>
    /// <param name="age"></param>
    public void SetAge(int age)
    {
        this.Age = age;
        if (null != ChangedAge)
        {
            ChangedAge(age);
        }
    }

    /// <summary>
    /// 身高发生改变
    /// </summary>
    /// <param name="height"></param>
    public void SetHeight(float height)
    {
        this.Height = height;
        if (null != ChangedHeight)
        {
            ChangedHeight(height);
        }
    }

    /// <summary>
    /// 体重发生改变
    /// </summary>
    /// <param name="weight"></param>
    public void SetWeight(float weight)
    {
        this.Weight = weight;
        if (null != ChangedWeight)
        {
            ChangedWeight(weight);
        }
    }
}


