using System;
using System.Linq;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Usage: dotnet run -- <ClassName>");
            return;
        }

        string className = args[0];

        // Find the type in the current assembly
        Type type = Assembly.GetExecutingAssembly().GetTypes()
            .FirstOrDefault(t => t.Name.Equals(className, StringComparison.OrdinalIgnoreCase));

        if (type == null)
        {
            Console.WriteLine($"Class '{className}' not found.");
            return;
        }

        // Find the Execute method
        MethodInfo method = type.GetMethod("Execute", BindingFlags.Public | BindingFlags.Static);

        if (method == null)
        {
            Console.WriteLine($"Class '{className}' does not have a static 'Execute' method.");
            return;
        }

        // Invoke the Execute method
        method.Invoke(null, null);
    }
}