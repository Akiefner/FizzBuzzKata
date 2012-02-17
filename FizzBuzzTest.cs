using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace FizzBuzzKata2
{
	[TestFixture]
	public class FizzBuzzTest
	{
		[Test]
		public void CanInstantiateTest()
		{
			FizzBuzz fb = new FizzBuzz();
			Assert.That(fb, Is.Not.Null);
		}
		[Test]
		public void IsThreeDivisibleByTHreeTEst()
		{
			FizzBuzz fb = new FizzBuzz();
			bool isDivisibleByThree = fb.IsDivisbleByThree(3);
			Assert.That(isDivisibleByThree, Is.True);
		}
		[Test]
		public void ReturnFizzIfDIvisbleByTHreeTest()
		{
			FizzBuzz fb = new FizzBuzz();
			string returnTextForNumber = fb.GetTextForNumber(6);
			Assert.That(returnTextForNumber, Is.EqualTo("FIZZ"));
		}
		[Test]
		public void IsFiveDivisibleByFIveTest()
		{
			FizzBuzz fb = new FizzBuzz();
			bool isDivisiblByFive = fb.IsDivisbleByFive(5);
			Assert.That(isDivisiblByFive, Is.True);
		}
		[Test]
		public void ReturnBUZZIfDivisbileByFiveTest()
		{
			FizzBuzz fb = new FizzBuzz();
			string returnTextForNumber = fb.GetTextForNumber(10);
			Assert.That(returnTextForNumber, Is.EqualTo("BUZZ"));
		}
		[Test]
		public void ReturnFIZZBUZZIdDivisbleByThreeANdFiveTest()
		{
			FizzBuzz fb = new FizzBuzz();
			string returnTextForNumber = fb.GetTextForNumber(15);
			Assert.That(returnTextForNumber, Is.EqualTo("FIZZBUZZ"));
		}
		[Test]
		public void ReturnAllOtherValues()
		{
			FizzBuzz fb = new FizzBuzz();
			string returnTextForNumber = fb.GetTextForNumber(4);
			Assert.That(returnTextForNumber, Is.EqualTo("4"));
		}
		[Test]
		public void ReturnAllValueTest()
		{
			FizzBuzz fb = new FizzBuzz();
			fb.Process(200);
		}

	}
}
