using System;
using System.ComponentModel;
using Xunit;

namespace SquaredUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(4, Add(2, 2));
        }

        [Fact]
        public void Test2()
        {
            Assert.Equal(16, Square(4));
        }

        int Add(int x, int y)
        {
            return x + y;
        }

        int Square(int x)
        {
            return x * x;
        }
    }
}
