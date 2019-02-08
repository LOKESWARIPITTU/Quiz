using System;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void FactorialOfANumber()
        {
            var expected = 24;
            var a = 4;
            var actual = Factorial(a);
            Assert.Equal(expected,actual);

        }

        [Fact]

        public void SquareRootOfANumber()
        {
            var expected = 7;
            var a = 49;
            var actual = SquareRoot(a);
            Assert.Equal(expected, actual);

        }
       
        [Theory]
        [InlineData(2,2)]
        [InlineData(120, 5)]
        [InlineData(1, 0)]
        public void Factorial_WorksWithManyInputs(int exp, int n1)
        {
            Assert.Equal(exp, Factorial(n1));
        }

        [Theory]
        [InlineData(2, 4)]
        [InlineData(5, 25)]
        [InlineData(10, 100)]
        public void SquareRoot_WorksWithManyInputs(int exp, int n1)
        {
            Assert.Equal(exp,SquareRoot(n1));
        }

        int Factorial(int x)
        {
           if (x == 0) 
                {
                 return 1; 
                }
              else{
          return x*Factorial(x-1); 
                }

                }

        double SquareRoot(int x)
        {
            return  Math.Sqrt(x);
        }
    }
}
