using Ardalis.GuardClauses;
using System;
using Xunit;

namespace GuardClauses.UnitTests
{
	public class GuardAgainstEmpty
	{
		[Fact]
		public void ThrowsGivenFoo()
		{
			Assert.Throws<ArgumentException>(() => Guard.Against.Empty(Guid.Empty, "aGuid"));
		}

		[Fact]
		public void DoesNothingGivenAnythingElse()
		{
			Guard.Against.Empty(Guid.NewGuid(), "aGuid");
		}
	}
}
