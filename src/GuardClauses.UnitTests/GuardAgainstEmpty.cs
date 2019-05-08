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
			Assert.Throws<ArgumentException>(() => Guard.Against.Empty(String.Empty, "aString"));
		}

		[Fact]
		public void DoesNothingGivenAnythingElse()
		{
			Guard.Against.Empty(Guid.NewGuid(), "aGuid");
			Guard.Against.Empty("test", "aString");
		}
	}
}
