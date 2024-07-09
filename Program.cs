using System;
class HelloWorld
{
    static void Main()
    {
        Function obj = new Function();//task1
        obj.SumOfNumbers();//task1
        Even ev = new Even();//task2
        ev.Numbers();//task2
        LeapYear ly = new LeapYear();//task3
        ly.year1();//task3
        Conversion cn = new Conversion();
        cn.kilometer();
        Check ck = new Check();
        ck.buzz();

    }
}
class Function//task1
{
    public void SumOfNumbers()
    {
        double sum;
        Console.Write("Enter 1st number:");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter 2nd number:");
        double num2 = Convert.ToDouble(Console.ReadLine());
        sum = num1 + num2;
        Console.Write("Sum :" + sum);
    }
}


//task2
class Even
{
    public void Numbers()
    {
        for (int i = 1; i <= 100; i++) 
        {
            if(i%2==0)
                {
                Console.WriteLine(i);
                }
        }
    }
}

//task3
class LeapYear
{
    public void year1()
    {
        Console.Write("Enter Year:");
        int year = Convert.ToInt32(Console.ReadLine());
        if(year%100!=0&&year%4==0)
        {
            Console.WriteLine("Year is Leap");

        }
        else
        {
            Console.WriteLine("Year is not leap");
        }
    }
}
//task#4
class Conversion
{
    public void kilometer()
    {
        Console.Write("Enter kilometers:");
        double a = Convert.ToDouble(Console.ReadLine());
        double miles = a * 0.621371;
        Console.Write("Conversion:"+miles);
    }
}
//task5
class Check
{
    public void buzz()
    {
        Console.Write("Enter kilometers:");
        int a = Convert.ToInt32(Console.ReadLine());
        if(a%10==7||a/7==0)
        {
            Console.WriteLine("number is buzz");
        }
        else
        {
            Console.WriteLine("number is not buzz");
        }
    }
}

