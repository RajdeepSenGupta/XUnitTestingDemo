﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace XUnitTestingDemo
{
    public class XUnitDemo
    {
		
        [Fact]
        public void PassingTest()
        {
            Assert.Equal(4, Add(2,2));
        }

        [Fact]
        public void FailingTest()
        {
            Assert.Equal(5, Add(2, 2));
        }

        int Add(int a, int b)
        {
            return a + b;
        }
        
        [Theory]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(6)]
        public void TheoryTest(int value)
        {
            Assert.True(IsOdd(value));
        }

        bool IsOdd(int value)
        {
            return (value % 2 == 1);
        }
    }
}
