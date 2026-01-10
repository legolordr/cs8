namespace cs8;

public class ParentChildren
{
    public static void PrintId(SiteData json)
    {
        if (!string.IsNullOrWhiteSpace(json.ParentId)) Console.WriteLine($"ParentId:{json.ParentId}");
        else Console.WriteLine("Parental documents do not exist");
        
        if (json.Children.Count == 0) Console.WriteLine("Children documents do not exist");
        else
        {
            Console.WriteLine("Children Id:");
            foreach (var child in json.Children)
            {
                //Добавить десериализацию child, для получения id каждого child (child - по сути json)
            }
        }
    }
}