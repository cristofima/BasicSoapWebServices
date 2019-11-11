namespace BasicSoapWebServices.Models
{
    public class MathService : IMathService
    {
        public decimal Division(MathOperation data)
        {
            var result = data.Number1 / data.Number2;
            return decimal.Round(result, 2);
        }

        public decimal Multiplication(MathOperation data)
        {
            return data.Number1 * data.Number2;
        }

        public decimal Subtraction(MathOperation data)
        {
            return data.Number1 - data.Number2;
        }

        public decimal Sum(MathOperation data)
        {
            return data.Number1 + data.Number2;
        }
    }
}