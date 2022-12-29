namespace Application_9._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// Задание #1   
            var exceptions = new Exception[] { new ArgumentOutOfRangeException(), new IndexOutOfRangeException(), new MyException(), new NotImplementedException(), new RankException() };
            foreach (var item in exceptions)
            {
                try
                {
                    throw item;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            /// Задание #2


        }
    }
    public class MyException : Exception
    {
        public MyException()
        { }

        public MyException(string message)
            : base(message)
        { }
    }
}