using System;
class Program
{

    static void Main(string[] args)
    {

        double n = double.Parse(Console.ReadLine());

        Console.WriteLine (F(n));


    }
    static double F(double X)
    {

                if (X>-1 &&X<=0)
        return Math.Sqrt(1-(X*X));

                if (X>0 &&X<1)
        return -Math.Sqrt(1-(X*X));


        if (X <= -1)
        return F(X+2);

        return F(X-2);


    }

} 