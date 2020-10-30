using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using Xunit;

namespace SquaredUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void IsUserEntryAnInt()
        {
            Assert.Equal(4, Add(2, 2));
        }

        int Add(int x, int y)
        {
            return x + y;
        }
    }
}
