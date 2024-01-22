namespace GA_MethodOverloading_Hongfei
{
    internal class Program
    {
        //Week2_GA_MethodOverloading
        //Hongfei
        //01/21/2024
        static void Main(string[] args)
        {
            MathOperations math = new MathOperations();
            int result1 = math.Subtract(15, 8);
            int product1 = math.Multiply(15, 8);
            int quotient1 = math.Divide(16, 8);
            Console.WriteLine($"a-b = {result1}");
            Console.WriteLine($"a*b = {product1}");
            Console.WriteLine($"a/b = {quotient1}");

            double result2 = math.Subtract(8.7, 6.5);
            double product2 = math.Multiply(8.7, 6.5);
            Console.WriteLine($"a-b = {result2:F2}");
            Console.WriteLine($"a*b = {product2}");

            try
            {
                double quotient2 = math.Divide(8.7, 6.5);
                Console.WriteLine($"a/b = {quotient2:F2}");
            }
            catch (DataMisalignedException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            double result3 = math.Subtract(8.7, 6.5, 1.5);
            double product3 = math.Multiply(8.7, 6.5, 1.5);
            Console.WriteLine($"a-b-c = {result3:F2}");
            Console.WriteLine($"a*b*c = {product3:F2}");

            Employee employee = new Employee();
            employee.AddEmployee("Sam Jones");
            employee.AddEmployee("Sam Jones", 32);
            employee.AddEmployee("Sam Jones", 32, "Marketing");

            Console.ReadKey();

        }
    }
}
