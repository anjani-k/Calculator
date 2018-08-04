using System;
using System.Collections.Generic;



    class Program
    {
       private static void Main(string[] args)
        {
        Calculator.Add(10, 20);
        }
    }
public class Calculator
{
    [Obsolete]
    public static int Add(int FirstNum, int SecondNum)
    {
        return FirstNum + SecondNum;
    }
    public static int Add(List<int> Numbers)
    {
        int sum = 0;
        foreach(int Number in Numbers)
        {
            sum = sum + Number;
        }
    }
}

