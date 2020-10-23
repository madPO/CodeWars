namespace KataTest._6_Kyu
{
    using Kata._6_Kyu;
    using Xunit;

    public class FindOddTest
    {
        [Fact]
        public void FirstTestCase()
        {
            Assert.Equal(5, FindOdd.Test(new[] { 20,1,-1,2,-2,3,3,5,5,1,2,4,20,4,-1,-2,5 }));
        }
    }
}