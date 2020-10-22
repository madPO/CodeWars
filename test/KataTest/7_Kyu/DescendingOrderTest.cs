namespace KataTest._7_Kyu
{
    using Kata._7_Kyu;
    using Xunit;

    public class DescendingOrderTest
    {
        [Fact]
        public void FirstTestCase()
        {
            Assert.Equal(54421, DescendingOrder.Test(42145));
        }
        
        [Fact]
        public void SecondTestCase()
        {
            Assert.Equal(654321, DescendingOrder.Test(145263));
        }
        
        [Fact]
        public void ThirdTestCase()
        {
            Assert.Equal(987654321, DescendingOrder.Test(123456789));
        }
        
        [Fact]
        public void FourthTestCase()
        {
            Assert.Equal(2110, DescendingOrder.Test(1021));
        }
    }
}