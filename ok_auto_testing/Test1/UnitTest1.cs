using Caculator;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;

namespace Test1
{
    public class UnitTest1
    {
        private readonly BasicCalculator calculator;
        public UnitTest1()
        {
            calculator = new BasicCalculator();
        }

        [Fact]
        public void TestAdd()
        {
            var result = calculator.Add(2, 3);
            Assert.Equal(5, result);

        }
        [Fact]
        public void TestSubstract()
        {
            var result = calculator.Substract(10, 5);
            Assert.Equal(5, result);
        }
        [Theory]
        [InlineData(2, 3, 6)]
        [InlineData(4, 5, 20)]
        [InlineData(-1, 5, -5)]
        public void TestMultiply(int a, int b, int expected)
        {
            var result = calculator.Multiply(a, b);
            Assert.Equal(expected, result);
        }
        [Theory]
        [InlineData(3)]
        [InlineData(20)]
        public void TestIsOddEven(int number)
        {
            var result = calculator.IsOddEven(number);
            Assert.False(result);
        }
        [Theory]
        [InlineData(0, 1, "ptvsn")]
        [InlineData(15, 0, "ptvn")]
        [InlineData(2, 4, "ptcn x = -2")]
        public void PhuongTrinhBacNhat_Test(int a, int b, string expected)
        {
            var result = calculator.PhuongTrinhBacNhat(a, b);
            Assert.Equal(expected, result);
        }
        [Theory]
        [InlineData(0, 0, 0, "ptvn")]
        [InlineData(0, 2, 4, "ptcn x = -2")]
        [InlineData(1, 2, 1, "ptcn x1 = -0.5, x2 = -0.5")]
        public void PhuongTrinhBacHai_Test(int a, int b, int c, string expected)
        {
            var result = calculator.PhuongTrinhBacHai(a, b, c);
            Assert.Equal(expected, result);
        }
        [Theory]
        [InlineData(4, 2, 2)]
        [InlineData(9, 3, 2)]
        public void TestUSCLN(int a, int b, int expected)
        {
            var result = calculator.TimUSCLN(a, b);
            Assert.Equal(expected, result);
        }
        [Theory]
        [InlineData(4, 2, 4)]
        [InlineData(9, 3, 10)]
        public void TestBSCNN(long a, long b, long expected)
        {
            var result = calculator.TimBSCNN(a, b);
            Assert.Equal(expected, result);
        }
        [Theory]
        [InlineData(5, 120)]
        [InlineData(0, 1)]
        public void TestGiaiThua(long n, long expected)
        {
            var result = calculator.timGiaiThua(n);
            Assert.Equal(expected, result);
        }

    }
}
