using System;
using Xunit;
using ModelLayer;
using BusinessLogicLayer;

namespace _12142020_MvcRpsDemo.Tests
{
	public class UnitTest1
	{
		[Fact]
		public void GetNextRoundReturnsaRound()
		{
			BusinessLogicClass blc = new BusinessLogicClass();
			int hundred = blc.SaveGame(10);
			Assert.Equal(100, hundred);
		}
	}
}
