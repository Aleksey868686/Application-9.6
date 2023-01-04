namespace Application_9._6;

internal class Program

{
    static void Main(string[] args)
    {
        /// Задание #1 (создал свое исключение SortException)   
        var exceptions = new Exception[] { new ArgumentOutOfRangeException(), new IndexOutOfRangeException(), new SortException(), new NotImplementedException(), new RankException() };
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

        SortEvent se = new SortEvent();
        se.SortArrEvent += se_SortingCompleted;
        se.StartSorting();
    }

    public static void se_SortingCompleted()
    {
        Console.WriteLine("Операция сортировки завершена.");

    }
}
