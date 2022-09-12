namespace ASPTUTGANAMEDE
{
    public class Palindrome_Numbers
    {
        public static void Palin()
        {
            int num = 0;
            int temp = 0;
            int revNum = 0;
            int rem=0;
            Console.WriteLine("Enter a NUMBER : ");
            num = Convert.ToInt32(Console.ReadLine());
            temp = num;
            while (num >0)
            {
                rem = num % 10;
                revNum = revNum * 10 + rem;
                num = num / 10;
            }
            Console.ReadLine();
        }
    }
}
