using NUnit.Framework;
using System;
using NancyTest;
namespace NancyTest.test
{
	[TestFixture()]
	public class Test
	{
		[Test()]
		public void TestCase()
		{
			Program myProgram = new Program();
			Assert.IsTrue(myProgram.TestMe());
		}
	}
}
