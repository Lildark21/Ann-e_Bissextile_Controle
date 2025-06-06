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
    }
}