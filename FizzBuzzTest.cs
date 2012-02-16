using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace FizzBuzzKata4
{
	[TestFixture]
	public class FizzBuzzTest
	{
		[Test]
		public void CanInstantiate()
		{
			FizzBuzz fb = new FizzBuzz();
			Assert.That(fb, Is.Not.Null);
		}
		[Test]
		public void ThreeIsDivisibleByThree()
		{
			FizzBuzz fb = new FizzBuzz();
			bool isDivisibleByThree = fb.IsDivisibleByThree(3);
			Assert.That(isDivisibleByThree, Is.True);
		}
		[Test]
		public void ReturnFIZZIfDivisibleByThreeTest()
		{
			FizzBuzz fb = new FizzBuzz();
			string returnTextForNumber = fb.GetTextForNumber(6);
			Assert.That(returnTextForNumber, Is.EqualTo("FIZZ"));
		}
		[Test]
		public void IsFiveDivisbleByFiveTest()
		{
			FizzBuzz fb = new FizzBuzz();
			bool isDivisibleByFive = fb.IsDivisibleByFive(5);
			Assert.That(isDivisibleByFive, Is.True);
		}
		[Test]
		public void ReturnBUZZIfDivisibleByFiveTest()
		{
			FizzBuzz fb = new FizzBuzz();
			string returnTextForNumber = fb.GetTextForNumber(10);
			Assert.That(returnTextForNumber, Is.EqualTo("BUZZ"));
		}
		[Test]
		public void ReturnFIZZBUZZIfDivisbleByFiveAndThreeTEst()
		{
			FizzBuzz fb = new FizzBuzz();
			string returnTextForNumber = fb.GetTextForNumber(15);
			Assert.That(returnTextForNumber, Is.EqualTo("FIZZBUZZ"));
		}
		[Test]
		public void AllOtherValuesTest()
		{
			FizzBuzz fb = new FizzBuzz();
			string returnNumber = fb.GetTextForNumber(13);
			Assert.That(returnNumber, Is.EqualTo("13"));
		}
		[Test]
		public void ReturnsFizzbuzzValuesTest()
		{
			FizzBuzz fb = new FizzBuzz();
			fb.Process(100);
		}

	
	}
}
