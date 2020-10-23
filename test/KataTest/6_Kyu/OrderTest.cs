namespace KataTest._6_Kyu
{
    using Kata._6_Kyu;
    using Xunit;

    public class OrderTest
    {
        [Fact]
        public void FirstTestCase()
        {
            Assert.Equal("Thi1s is2 3a T4est", Order.Test("is2 Thi1s T4est 3a"));
        }
        
        [Fact]
        public void SecondTestCase()
        {
            Assert.Equal("Fo1r the2 g3ood 4of th5e pe6ople", Order.Test("4of Fo1r pe6ople g3ood th5e the2"));
        }
        
        [Fact]
        public void ThirdTestCase()
        {
            Assert.Equal("", Order.Test(""));
        }
    }
}