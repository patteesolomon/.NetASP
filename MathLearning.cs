using System;
namespace ASPTUTGANAMEDE
{
    public class MathLearning
    {
        public void meh()
        {
            double x = 4;
            double y = -3,
                z = 4;
            double f = Math.Abs(x);
            double e = Math.Ceiling(y);
            double g = Math.Sqrt(z);
            Console.WriteLine(e * f * g);
            double d = Math.Round(x);
            double p = Math.Pow(x,y);
            double u = Math.Max(d, p);
            // more methods and such
            Math.Cbrt(d);
            Math.Cos(e);
            // and so on
        }
    }
}
