using SimpleCalculator.Business;
using SimpleCalculator.Business.Abstraction;
using SimpleCalculator.Business.Enums;
using SimpleCalculator.Business.OperatorBusiness;
using SimpleCalculator.Business.OperatorBusiness.Operators;

namespace Tests
{
    public class DivisionOperatorTest
    {
        readonly DivisionOperator Operator = new();

        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(-2, 2, -1)]
        public void DivisionTest(int first, int second, int expectedResult)
        {
            Assert.Equal(expectedResult, Operator.Calculate(first, second));
        }

        [Fact]
        public void DivideByZeroExceptionTest()
        {
            Assert.Throws<DivideByZeroException>(() => Operator.Calculate(4, 0));
        }
    }

    public class MultiplyOperatorTest
    {
        readonly MultiplyOperator Operator = new();

        [Theory]
        [InlineData(0, 3, 0)]
        [InlineData(-2, 2, -4)]
        public void MultiplyTest(int first, int second, int expectedResult)
        {
            Assert.Equal(expectedResult, Operator.Calculate(first, second));
        }
    }

    public class SubOperatorTest
    {
        readonly SubOperator Operator = new();

        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(-2, 2, -4)]
        public void SubTest(int first, int second, int expectedResult)
        {
            Assert.Equal(expectedResult, Operator.Calculate(first, second));
        }
    }

    public class SumOperatorTest
    {
        readonly SumOperator Operator = new();

        [Theory]
        [InlineData(2, 1, 3)]
        [InlineData(-2, 2, 0)]
        public void SumTest(int first, int second, int expectedResult)
        {
            Assert.Equal(expectedResult, Operator.Calculate(first, second));
        }
    }

    public class OperatorProviderTest
    {
        OperatorProvider Provider = new();

        [Theory]
        [InlineData(OperatorEnum.sum, "SumOperator")]
        [InlineData(OperatorEnum.sub, "SubOperator")]
        [InlineData(OperatorEnum.multiply, "MultiplyOperator")]
        [InlineData(OperatorEnum.division, "DivisionOperator")]
        public void GetOperatorTest(OperatorEnum operatorType, string expectedTypeName)
        {
            var actualTypeName = Provider.GetOperator(operatorType).GetType().Name;
            Assert.Equal(expectedTypeName, actualTypeName);
        }

        //[Fact]
        //public void NotSupportedExceptionTest()
        //{
        //    Assert.Throws<NotSupportedException>(() => Provider.GetOperator(null));
        //}

    }

    public class CalculatorTest
    {
        Calculator Calc = new();


        [Theory]
        [InlineData(4, 2, OperatorEnum.sum, 6)]
        [InlineData(4, 2, OperatorEnum.sub, 2)]
        [InlineData(4, 2, OperatorEnum.multiply, 8)]
        [InlineData(4, 2, OperatorEnum.division, 2)]
        public void CaculateTest(int first, int second, OperatorEnum operatorType, int expectedResult)
        {
            Assert.Equal(expectedResult, Calc.Calculate(first, second, operatorType));
        }
    }

}