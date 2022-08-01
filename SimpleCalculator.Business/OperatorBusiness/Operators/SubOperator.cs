using SimpleCalculator.Business.Abstraction;

namespace SimpleCalculator.Business.OperatorBusiness.Operators
{
    public class SubOperator : IOperator
    {
        public int Calculate(int first, int second)
        {
            return first - second;
        }
    }
}
