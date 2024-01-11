using Ch04Ex02PrimeFactorsLib;

namespace Ch04Ex02PrimeFactorsTests
{
    public class PrimeFactorsUnitTests
    {
        [Fact]
        public void PrimerFacto50()
        {
            // arrange 
            int a = 50;
            string expected = "2 5 5 ";

            // act
            string actual = PrimeFactors.GivePrimeFactors(a);

            // assert
            Assert.Equal(expected, actual);
        }
    }
}