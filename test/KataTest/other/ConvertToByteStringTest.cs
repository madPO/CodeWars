namespace KataTest.other
{
    using System;
    using System.Linq;
    using BenchmarkDotNet.Attributes;
    using BenchmarkDotNet.Running;
    using Xunit;

    [MinColumn, MaxColumn]  
    [MemoryDiagnoser]
    public class ConvertToByteStringTest
    {
        private readonly byte[] _byteArray = new byte[] { 104, 101, 108, 108, 111, 32, 119, 111, 114, 108, 100 };

        private readonly string _expected = "68656C6C6F20776F726C64";

        [Fact]
        [Benchmark]
        public void MostPopularTest()
        {
            var result = ToStringMethod(_byteArray);
            
            Assert.True(_expected.Equals(result, StringComparison.OrdinalIgnoreCase));
        }
        
        [Fact]
        public void Benchmark()
        {
            var summary = BenchmarkRunner.Run<ConvertToByteStringTest>();
        }
        
        private string ToStringMethod(byte[] values)
        {
            return string.Join("", values.Select(x => x.ToString("x2")));
        }

        [Fact]
        [Benchmark]
        public void BitConverterTest()
        {
            var result = BitConverterMethod(_byteArray);

            Assert.True(_expected.Equals(result, StringComparison.OrdinalIgnoreCase));
        }
        
        private string BitConverterMethod(byte[] values)
        {
            return BitConverter.ToString(values).Replace("-", "");
        }

        [Fact]
        [Benchmark]
        public void StringCreateTest()
        {
            var result = StringCreateMethod(_byteArray);
            
            Assert.True(_expected.Equals(result, StringComparison.OrdinalIgnoreCase));
        }
        
        private string StringCreateMethod(byte[] values)
        {
            return string.Create(values.Length * 2, values, (span, bytes) =>
            {
                int b;
                for(var i = 0; i < bytes.Length; i++)
                {
                    b = bytes[i] >> 4;
                    span[i * 2] = (char)(55 + b  + (((b-10)>>31)&-7));
                    b = bytes[i] & 0xF;
                    span[i * 2 + 1] = (char)(55 + b + (((b-10)>>31)&-7));
                }
            });
        }
    }
}