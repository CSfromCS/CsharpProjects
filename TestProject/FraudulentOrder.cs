public class FraudulentOrder
{
    public static void Execute()
    {
        string[] orders = new string[] { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

        foreach(string order in orders)
        {
            if(order.StartsWith("B"))
            {
                Console.WriteLine(order);
            }
        }
    }
}
