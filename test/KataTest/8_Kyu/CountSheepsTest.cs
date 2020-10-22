namespace KataTest._8_Kyu
{
    using Kata._8_Kay;
    using Xunit;

    public class CountSheepsTest
    {
        [Fact]
        public void FirstTestCase()
        {
            var sheeps = new [] { true, false, true };
            
            Assert.Equal(2, CountSheeps.Test(sheeps));
        }

    }
}