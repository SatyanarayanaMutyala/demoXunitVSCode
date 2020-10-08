using System;
using Xunit;
using DemoMath;

namespace DemoMath.Test
{
    public class BasicMathTests
    {
        [Fact]
        public void AddTest_TwoNumbers_ValidNumbers()
        {
            var result = BasicMath.Add(1,2);
            Assert.Equal(3, result);
        }

        [Fact]
        public void AddTest_OneNumnber_ValidResult()
        {
            var result = BasicMath.Add(4,0);
            Assert.Equal(4, result);        
        }

    }
}