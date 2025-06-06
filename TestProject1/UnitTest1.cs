using Xunit;
using Année_Bissextile_Controle;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void YearDivisibleBy400_IsLeap()
        {
            Assert.True(LeapYear.IsLeap(2000));
        }
        [Fact]
        public void YearDivisibleBy100ButNot400_IsNotLeap()
        {
            Assert.False(LeapYear.IsLeap(1900));
        }
        [Fact]
        public void YearDivisibleBy4ButNot100_IsLeap()
        {
            Assert.True(LeapYear.IsLeap(2004));
        }
        [Fact]
        public void YearNotDivisibleBy4_IsNotLeap()
        {
            Assert.False(LeapYear.IsLeap(2001));
        }
    }
}