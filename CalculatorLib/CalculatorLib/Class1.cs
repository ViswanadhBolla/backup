namespace CalculatorLib
{
    public class Calculator
    {
        public int add(int a, int b)
        {
            return a + b;
        }
        public int sub(int a , int b)
        {
            return a - b;
        }
        public int mul(int a , int b)
        {
            return a * b;
        }
        public float div(int a, int b)
        {
            float result = (float)a / (float)b;
            return result;
        }
    }
}