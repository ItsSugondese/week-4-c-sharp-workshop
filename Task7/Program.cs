class Calendar
{
    public enum DaysOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    //Question-2
    public static void PrintWeekdays()
    {
        Console.WriteLine("Weekdays:");

        foreach (DaysOfWeek day in Enum.GetValues(typeof(DaysOfWeek)))
        {
            if (day >= DaysOfWeek.Monday && day <= DaysOfWeek.Friday)
            {
                Console.WriteLine(day);
            }
        }
    }
}

//Question-3
class Program
{
    static void Main()
    {
        Calendar.PrintWeekdays();
    }
}