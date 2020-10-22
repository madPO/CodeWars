namespace KataTest._8_Kyu
{
    using Kata._8_Kay;
    using Xunit;

    public class SpacesRemoverTest
    {
        [Fact]
        public void FirstTestCase()
        {
            Assert.Equal("8j8mBliB8gimjB8B8jlB", SpacesRemover.Test("8 j 8   mBliB8g  imjB8B8  jl  B"));
        }
        
        [Fact]
        public void SecondTestCase()
        {
            Assert.Equal("88Bifk8hB8BB8BBBB888chl8BhBfd", SpacesRemover.Test("8 8 Bi fk8h B 8 BB8B B B  B888 c hl8 BhB fd"));
        }
        
        [Fact]
        public void ThirdTestCase()
        {
            Assert.Equal("8aaaaaddddr", SpacesRemover.Test("8aaaaa dddd r     "));
        }
    }
}