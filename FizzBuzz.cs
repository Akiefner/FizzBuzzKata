using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzzKata2
{
	public class FizzBuzz
	{
		public bool IsDivisbleByThree(int p)
		{
			return (p % 3) == 0;
		}

		public string GetTextForNumber(int p)
		{
			bool isDivisbleByThree = IsDivisbleByThree(p);
			bool isDivisibleByFive = IsDivisbleByFive(p);

			if (isDivisibleByFive && isDivisbleByThree)
			{
				return "FIZZBUZZ";
			}
			if(isDivisibleByFive)
			{
				return "BUZZ";
			}
			else if (isDivisbleByThree)
			{
				return "FIZZ";
			}
			return p.ToString();
		}

		public bool IsDivisbleByFive(int p)
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
