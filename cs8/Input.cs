namespace cs8;

public static class Input
{
    public static string InputId()
    {
        while (true)
        {
            try
            {
                Console.WriteLine("Enter the document ID");
                string id = Console.ReadLine()!;
                if (string.IsNullOrWhiteSpace(id)) throw new ArgumentNullException();
                return id;
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("You entered a null string");
            }
        }
    }
}