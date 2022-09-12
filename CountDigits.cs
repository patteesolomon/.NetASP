namespace ASPTUTGANAMEDE
{
    public class CountDigits
    {
        public void CountD()
        {
            int num1;
            int num2;
            int num3;
            int num4;
            int num5;

            int pos=0;
            int neg=0;
            int zero = 0;

            Console.WriteLine("number 1? : ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("number 2? : ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("number 3? : ");
            num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("number 4? : ");
            num4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("number 5? : ");
            num5 = Convert.ToInt32(Console.ReadLine());

            if( num1 > 0)
            {
                pos += 1;
            }

            if(num1 < 0)
            {
                neg += 1;

            }
            if(num1 ==0)
            {
                zero += 1;
            }
            if (num2 > 0)
            {
                pos += 1;
            }

            if (num2 < 0)
            {
                neg += 1;

            }
            if (num2 == 0)
            {
                zero += 1;
            }

            if (num3 > 0)
            {
                pos += 1;
            }

            if (num3 < 0)
            {
                neg += 1;

            }
            if (num3 == 0)
            {
                zero += 1;
            }

            if (num4 > 0)
            {
                pos += 1;
            }

            if (num4 < 0)
            {
                neg += 1;

            }
            if (num4 == 0)
            {
                zero += 1;
            }

            if (num5 > 0)
            {
                pos += 1;
            }

            if (num5 < 0)
            {
                neg += 1;

            }
            if (num5 == 0)
            {
                zero += 1;
            }

            Console.WriteLine("You wrote {0} positive numbers", pos);
            Console.WriteLine("You wrote {0} positive numbers", neg);
            Console.WriteLine("You wrote {0} zero numbers", pos);
        }
    }
}
