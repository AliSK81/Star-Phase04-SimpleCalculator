using SimpleCalculator.Business.Abstraction;

namespace SimpleCalculator.Business.OperatorBusiness.Operators
{
    public class DivisionOperator : IOperator
    {
        public int Calculate(int first, int second)
        {
            if (second == 0)
            {
                throw new DivideByZeroException();
            }
            return first / second;
        }
    }
}
