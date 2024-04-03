

namespace KnowledgeCheck1_Calculator
{
    public class Calculator
    {
        private readonly Dictionary<string, Func<double, double, double>> operations;

        public Calculator()
        {
            operations = new Dictionary<string, Func<double, double, double>>
            {
                {"add", (a, b) => a + b},
                {"subtract", (a, b) => a - b},
                {"multiply", (a, b) => a * b},
                {"divide", (a, b) => a / b}
            };
        }

        public double Calculate(string operation, double first, double second)
        {
            if (!operations.ContainsKey(operation))
                throw new ArgumentException("Invalid operation");

            return operations[operation](first, second);
        }
    }
}