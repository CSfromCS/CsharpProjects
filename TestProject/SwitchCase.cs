public class SwitchCase
{
    public static void Execute()
    {
        string[] orders = new string[] { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

        foreach (string order in orders)
        {
            switch (order[0])
            {
                case 'B':
                    Console.WriteLine(order);
                    goto meow;
                    goto case 'C';
                case 'C':
                    Console.WriteLine("C");
                    break;
                case 'A':
                meow:
                    Console.WriteLine("A");
                    break;
            }
        }
    }
}