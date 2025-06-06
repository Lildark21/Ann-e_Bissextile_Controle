using Xunit;
using Année_Bissextile_Controle;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void YearDivisibleBy100ButNot400_IsNotLeap()
        {
            Assert.False(LeapYear.IsLeap(1900));
        }
    }
}