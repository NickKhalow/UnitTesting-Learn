namespace UnitTestingLearn.Calculators
{
    public class BrokenCalculator : ICalculator
    {
        public int Add(int left, int right)
        {
            return right + left;
        }


        public int Subtract(int left, int right)
        {
            return left - right;
        }
    }
}