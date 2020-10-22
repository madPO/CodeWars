namespace KataTest._6_Kyu
{
    using Kata._6_Kyu;
    using Xunit;

    public class IQTest
    {
        [Fact]
        public void FirstTestCase()
        {
            Assert.Equal(3, IQ.Test("2 4 7 8 10"));
        }
        
        [Fact]
        public void SecondTestCase()
        {
            Assert.Equal(2, IQ.Test("1 2 1 1"));
        }
        
        [Fact]
        public void EmptyTest()
        {
            Assert.Equal(0, IQ.Test(""));
        }
        
        [Fact]
        public void AllEvenTest()
        {
            Assert.Equal(0, IQ.Test("2 4 6 8"));
        }
        
        [Fact]
        public void AllOddTest()
        {
            Assert.Equal(0, IQ.Test("1 3 5 7"));
        }
        
        [Fact]
        public void OnlyTwoElementTest()
        {
            Assert.Equal(0, IQ.Test("1 2"));
        }
        
        [Fact]
        public void WtfTest()
        {
            Assert.Equal(2, IQ.Test("1 wtf 2"));
        }
        
        [Fact]
        public void LastElementTest()
        {
            Assert.Equal(5, IQ.Test("1 3 5 7 8"));
        }
        
        [Fact]
        public void LastButOneTest()
        {
            Assert.Equal(5, IQ.Test("1 3 5 7 8 9"));
        }
    }
}