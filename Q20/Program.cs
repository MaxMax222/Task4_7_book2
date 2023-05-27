namespace Q20;
class Program
{
    static void Main(string[] args)
    {
        MoneyBox[,] store = new MoneyBox[6, 5];
        for (int i = 0; i < store.GetLength(0); i++)
        {
            for (int j = 0; j < store.GetLength(1); j++)
            {
                store[i, j] = new MoneyBox();
            }
        }

        for (int i = 0; i < store.GetLength(0); i++)
        {
            for (int j = 0; j < store.GetLength(1); j++)
            {
                Console.Write($"enter the name of the cashier on the {j + 1} cash register in the {i + 1} division: ");
                store[i, j].Cahier = Console.ReadLine();
            }
        }

        int pay = -1, division, reg, total_store_income = 0;

        while (pay != 0)
        {
            Console.WriteLine($"enter the division that you're at: ");
            division = int.Parse(Console.ReadLine());
            Console.WriteLine($"enter the cash register number: ");
            reg = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the payment (enter 0 to exit): ");
            pay = int.Parse(Console.ReadLine());

            division--;
            reg--;
            store[division, reg].Money += pay;
            total_store_income += pay;
        }

        double max = 0;
        string best_cahier = "";
        for (int i = 0; i < store.GetLength(0); i++)
        {
            for (int j = 0; j < store.GetLength(1); j++)
            {
                if (store[i, j].Money > max)
                {
                    max = store[i, j].Money;
                    best_cahier = store[i, j].Cahier;
                }
            }
        }

        double minIncome = 999999;
        double minDivision = -1;

        for (int i = 0; i < store.GetLength(0); i++)
        {
            double divisionIncome = 0;

            for (int j = 0; j < store.GetLength(1); j++)
            {
                divisionIncome += store[i, j].Money;
            }

            if (divisionIncome < minIncome)
            {
                minIncome = divisionIncome;
                minDivision = i + 1;
            }
        }

        if (minDivision != -1)
        {
            Console.WriteLine($"The division with the lowest income is {minDivision} with a total income of {minIncome}");
        }
        Console.WriteLine($"The best selling cashier is: {best_cahier}");
        Console.WriteLine($"The total income of the store: {total_store_income}");

    }
}
