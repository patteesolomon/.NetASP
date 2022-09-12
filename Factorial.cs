namespace ASPTUTGANAMEDE
{
    public class Factorial
    {
        static void FactorialN()
        {
            int factorial = 1;

            int number = 6;

            if (number < 0)
            {
                throw new ArgumentException(
                    "Can't find the " +
                    "factorial of negative" +
                    "number");
            }
            else if (number <= 1)
            {
                Console.WriteLine("{0}! = {1}", number, factorial);
            }
            else
            {
                for ( int counter = number;
                    counter >= 2; counter--)
                {
                    factorial *= counter;
                }
            }
        }
    }
}
