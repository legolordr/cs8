namespace cs8;

public class DocumentInfoConsoleDisplay
{
    public static void PrintId(Root json)
    {
        if (!string.IsNullOrWhiteSpace(json.ParentId)) Console.WriteLine($"ParentId:{json.ParentId}");
        else Console.WriteLine("Parental documents do not exist");

        if (json.Children.Count == 0) Console.WriteLine("Children documents do not exist");
        else
        {
            Console.WriteLine($"If you want to see detailed information about a child document, enter it ID");
            Console.WriteLine("Children documents:");
            Console.WriteLine("Name : Id");
            foreach (var child in json.Children)
            {
                Console.WriteLine($"{child.Name} : {child.Id}");
            }
        }
    }
}