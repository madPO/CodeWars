namespace KataTest._7_Kyu
{
    using Kata._7_Kyu;
    using Xunit;

    public class SquareDigitsTest
    {
        [Fact]
        public void FirstTestCase()
        {
            Assert.Equal(811181, SquareDigits.Test(9119));
        }
        
        [Fact]
        public void SecontTestCase()
        {
            Assert.Equal(9414, SquareDigits.Test(3212));
        }
    }
}