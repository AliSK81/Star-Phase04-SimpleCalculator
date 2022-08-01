using SimpleCalculator.Business.Abstraction;

namespace SimpleCalculator.Business.OperatorBusiness.Operators
{
    public class MultiplyOperator : IOperator
    {
        public int Calculate(int first, int second)
        {
            return first * second;
        }
    }
}
