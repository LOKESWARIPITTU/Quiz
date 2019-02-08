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
       
 [Theory]
        [InlineData(2,2)]
        [InlineData(120, 5)]
        [InlineData(1, 0)]
        public void Factorial_WorksWithManyInputs(int exp, int n1)
        {
            Assert.Equal(exp, Factorial(n1));
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
    }
}
