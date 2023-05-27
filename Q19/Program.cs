namespace Q19;
class Program
{
    static int KidsInClass(CoupleNames[,] Class)
    {
        int sum = 0;
        for (int r = 0; r < Class.GetLength(0); r++)
        {
            for (int c = 0; c < Class.GetLength(1); c++)
            {
                sum += Class[r, c].KidsInIndex(r * 10 + c, Class);
            }
        }
        return sum;
    }

    static int GetIndexOfKid(string name, CoupleNames[,] Class)
    {
        for (int r = 0; r < Class.GetLength(0); r++)
        {
            for (int c = 0; c < Class.GetLength(1); c++)
            {
                if (Class[r, c].Name1 == name || Class[r, c].Name2 == name)
                {
                    return r * 10 + c;
                }
            }
        }
        return -1;
    }
    static void Main(string[] args)
    {
        CoupleNames[,] Class = new CoupleNames[8, 4];
        for (int r = 0; r < Class.GetLength(0); r++)
        {
            for (int c = 0; c < Class.GetLength(1); c++)
            {
                Class[r, c] = new CoupleNames();
            }
        }

        // Set some names for testing
        Class[0, 0].Name1 = "John";
        Class[0, 0].Name2 = "Jane";
        Class[1, 2].Name1 = "Mike";
        Class[2, 1].Name2 = "Emily";
        Class[3, 3].Name1 = "David";
        Class[3, 3].Name2 = "Sarah";

        // Test the KidsInClass method
        int totalKids = KidsInClass(Class);
        Console.WriteLine("Total number of kids in the class: " + totalKids);

        // Test the GetIndexOfKid method
        int indexOfJohn = GetIndexOfKid("John", Class);
        Console.WriteLine("Index of John: " + indexOfJohn);

        int indexOfEmily = GetIndexOfKid("Emily", Class);
        Console.WriteLine("Index of Emily: " + indexOfEmily);

        int indexOfUnknown = GetIndexOfKid("Unknown", Class);
        Console.WriteLine("Index of Unknown: " + indexOfUnknown);
    }

}