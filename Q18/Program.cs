namespace Q18;
class Program
{
    static void PrintAllShifts(Shift[,] shifts)
    {
        Console.WriteLine("Shift Schedule:");

        Console.WriteLine("   | Day 1 | Day 2 | Day 3 | Day 4 | Day 5 | Day 6 | Day 7 |");
        Console.WriteLine("---+-------+-------+-------+-------+-------+-------+-------+");

        for (int i = 0; i < shifts.GetLength(0); i++)
        {
            Console.Write($" {i + 1} |");
            for (int j = 0; j < shifts.GetLength(1); j++)
            {
                Console.Write($" {shifts[i, j].ToString().PadRight(6)} |");
            }
            Console.WriteLine("\n---+-------+-------+-------+-------+-------+-------+-------+");
        }
    }
    static void Main(string[] args)
    {
        Shift[,] shifts = new Shift[3, 7];

        int day, shift, role;
        string name;
        for (int i = 0; i < shifts.GetLength(0); i++)
        {
            for (int j = 0; j < shifts.GetLength(1); j++)
            {
                shifts[i, j] = new Shift();
            }
        }

        Console.WriteLine($"enter the day number of your shift: ");
        day = int.Parse(Console.ReadLine());
        while (day > 0)
        {
            day--;
            Console.WriteLine($"enter the number of the shift [1-3]: ");
            shift = int.Parse(Console.ReadLine());

            Console.WriteLine($"enter your role [1-manager, 2-worker]");
            role = int.Parse(Console.ReadLine());
            Console.WriteLine($"enter your name: ");
            name = Console.ReadLine();

            if (shifts[shift, day].DoubleWorkers(name))
            {
                Console.WriteLine($"you've alredy enroled to this shift");
            }
            else
            {
                if (role == 1)
                {
                    if (shifts[shift, day].Worker1 != "")
                    {
                        shifts[shift, day].Worker2 = name;
                    }
                    else
                    {
                        shifts[shift, day].Worker1 = name;
                    }
                }
                else
                {
                    shifts[shift, day].Manager = name;
                }
            }
            Console.WriteLine($"enter the day number of your shift: ");
            day = int.Parse(Console.ReadLine());
        }
        PrintAllShifts(shifts);
    }
}
