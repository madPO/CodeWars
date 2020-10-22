namespace KataTest._8_Kyu
{
    using Kata._8_Kay;
    using Xunit;

    public class BasicOpTest
    {
        [Fact]
        public void FirstTestCase()
        {
            Assert.Equal(11, BasicOp.Test('+', 4, 7));
        }
        
        [Fact]
        public void SecondTestCase()
        {
            Assert.Equal(-3, BasicOp.Test('-', 15, 18));
        }
        
        [Fact]
        public void ThirdTestCase()
        {
            Assert.Equal(25, BasicOp.Test('*', 5, 5));
        }
        
        [Fact]
        public void FourthTestCase()
        {
            Assert.Equal(7, BasicOp.Test('/', 49, 7));
        }
    }
}