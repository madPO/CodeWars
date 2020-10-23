namespace KataTest._6_Kyu
{
    using Kata._6_Kyu;
    using Xunit;

    public class XbonacciTest
    {
        [Fact]
        public void FirstTestCase()
        {
            Assert.Equal(new double []{1,1,1,3,5,9,17,31,57,105}, Xbonacci.Test(new double []{1,1,1},10));
        }
        
        [Fact]
        public void SecondTestCase()
        {
            Assert.Equal(new double []{0,0,1,1,2,4,7,13,24,44}, Xbonacci.Test(new double []{0,0,1},10));
        }
        
        [Fact]
        public void ThirdTestCase()
        {
            Assert.Equal(new double []{0,1,1,2,4,7,13,24,44,81}, Xbonacci.Test(new double []{0,1,1},10));
        }
    }
}