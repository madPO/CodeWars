namespace KataTest._6_Kyu
{
    using Kata._6_Kyu;
    using Xunit;

    public class IsValidWalkTest
    {
        [Fact]
        public void FirstTestCase()
        {
            Assert.True(IsValidWalk.Test(new [] {"n","s","n","s","n","s","n","s","n","s"}));
        }
        
        [Fact]
        public void SecondTestCase()
        {
            Assert.False(IsValidWalk.Test(new [] {"w","e","w","e","w","e","w","e","w","e","w","e"}));
        }
        
        [Fact]
        public void ThirdTestCase()
        {
            Assert.False(IsValidWalk.Test(new [] {"w"}));
        }
        
        [Fact]
        public void FourthTestCase()
        {
            Assert.False(IsValidWalk.Test(new [] {"n","n","n","s","n","s","n","s","n","s"}));
        }
    }
}