namespace cs8;

public static class Input
{
    public static string? InputId()
    {
        while (true)
        {
            try
            {
                Console.WriteLine("Enter the document ID");
                string? id = Console.ReadLine();
                if (id == null) return null;
                if (string.IsNullOrWhiteSpace(id)) throw new ArgumentException();
                return id;
            }
            catch (ArgumentException)
            {
                Console.WriteLine("You entered a null string");
            }
        }
    }
}