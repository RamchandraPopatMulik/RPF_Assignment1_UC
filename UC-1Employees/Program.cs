namespace UC_1Employees
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int IS_FULLTIME = 1;
            Random random = new Random();
            int val = random.Next(0,2);
            if (val == IS_FULLTIME)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
}