using System;

public class Fibbon
{
	// 

	public Fibbon() // ctr
	{
		int next = 0;
		int prev = 0;
		for (int i = 0; i <= 10; i++)
        {
			Console.WriteLine(next);
			if (next == 0)
            {
				next = 1;
            }
            else
            {
				int temp = next;
				next = next + prev;
				prev = next;
            }
        }
	}
}
