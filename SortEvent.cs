namespace Application_9._6;

public delegate void SortNotify();
internal class SortEvent
{
    public event SortNotify? SortArrEvent;
    public void StartSorting()
    {
        string[] surnames = new string[5];
        int counter = 1;
        Console.WriteLine("Введите пять фамилий.");
        try
        {
            do
            {
                Console.WriteLine($"Введите {counter} фамилию:");
                string surname = Console.ReadLine().Trim();
                bool result = surname.All(Char.IsLetter);
                if (result)
                {
                    surnames[counter - 1] = surname;
                    counter++;
                }
                else
                {
                    Console.WriteLine("Введите фамилию буквами!");
                    continue;
                }

            } while (counter < surnames.Length + 1);
            Console.WriteLine("Введите цифру \"1\" для сортировки фамилий по алфавиту (сортировка А-Я) или цифру \"2\" для обратной сортировки (сортировка Я-А)");
            string sortDirection = Console.ReadLine();
            if (sortDirection == "1")
            {
                Array.Sort(surnames);
            }
            else if (sortDirection == "2")
            {
                Array.Sort(surnames, (s1, s2) => -s1.CompareTo(s2));
            }
            else
            {
                throw new SortException("Введено некорректное значение порядка сортировки. Попробуйте еще раз.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Введено некорректное значение. Попробуйте еще раз.");
        }
        catch (SortException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            foreach (var item in surnames)
            {
                Console.WriteLine($"Фамилия: {item}");
            }
        }
        OnSortArrEvent();
    }

    public void OnSortArrEvent() { SortArrEvent?.Invoke(); }

}
