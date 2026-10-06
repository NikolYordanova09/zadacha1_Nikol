using zadacha1_Nikol;

class Program
{
    static void Main()
    {
        Time time1 = new Time();

        Console.Write("Време от конструктора без параметри: ");
        time1.PrintTime();

        Time time2 = new Time(14, 35, 9);

        Console.Write("Време от конструктора с параметри: ");
        time2.PrintTime();

        try
        {
            Time time3 = new Time(10, -5, 20);
            time3.PrintTime();
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Грешка: " + ex.Message);
        }
    }
}