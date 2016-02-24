using System;

public class Person
{
    public string sex { get; private set; }

    public int age { get; private set; }

    public float height { get; private set; }

    public float weight { get; private set; }

    public delegate void ChangedSexHandler(string sex);

    public delegate void ChangedAgeHandler(int age);

    public delegate void ChangedHeightHandler(float height);

    public delegate void ChangedWeightHandler(float weight);

    public event ChangedSexHandler changedSex;

    public event ChangedAgeHandler changedAge;

    public event ChangedHeightHandler changedHeight;

    public event ChangedWeightHandler changedWeight;

    public Person(string sex, int age, float height, float weight)
    {
        this.sex = sex;
        this.age = age;
        this.height = height;
        this.weight = weight;
    }

    public void SetSex(string sex)
    {
        this.sex = sex;
        if(null != changedSex)
        {
            changedSex(sex);
        }
    }

    public void SetAge(int age)
    {
        this.age = age;
        if (null != changedAge)
        {
            changedAge(age);
        }
    }

    public void SetHeight(float height)
    {
        this.height = height;
        if (null != changedHeight)
        {
            changedHeight(height);
        }
    }

    public void SetWeight(float weight)
    {
        this.weight = weight;
        if (null != changedWeight)
        {
            changedWeight(weight);
        }
    }
}


