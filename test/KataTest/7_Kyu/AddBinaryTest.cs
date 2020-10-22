namespace KataTest._7_Kyu
{
    using Kata._7_Kyu;
    using Xunit;

    public class AddBinaryTest
    {
        [Fact]
        public void FirstTestCase()
        {
            Assert.Equal("11", AddBinary.Test(1, 2));
        }
    }
}