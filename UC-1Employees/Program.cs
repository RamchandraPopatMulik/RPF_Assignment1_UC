namespace UC_1Employees
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int IS_FULLTIME = 1;
            Random ran = new Random();
            int val = ran.Next(0,2);
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