using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzzKata4
{
	public class FizzBuzz
	{
		public bool IsDivisibleByThree(int p)
		{
			return (p % 3)==0;
		}

		public string GetTextForNumber(int p)
		{
			bool isDivisibleByThree = IsDivisibleByThree(p);
			bool isDivisibleByFive = IsDivisibleByFive(p);

			if (isDivisibleByFive && isDivisibleByThree)
			{
				return "FIZZBUZZ";
			}
			else if (isDivisibleByFive)
			{
				return "BUZZ";
			}
			else if (isDivisibleByThree)
			{
				return "FIZZ";
			}
			return p.ToString();
		}

		public bool IsDivisibleByFive(int p)
		{
			return (p % 5) == 0;
		}

		public void Process(int p)
		{

			for (int i = 1; i <= p; i++)
			{
				Console.WriteLine(GetTextForNumber(i));
			}
		}
	}
}
