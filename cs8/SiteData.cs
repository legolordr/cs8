namespace cs8;


public class Lineage
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public bool IsIndexed { get; set; }
    public string CoverUrl { get; set; }
    public string OwnerId { get; set; }
    public object ParentId { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset UpdatedAt { get; set; }
}

public class Root : Lineage
{
    public string AccessLevel { get; set; }
    public Share Share { get; set; }
    public List<Lineage> Lineage { get; set; }
    public List<Lineage> Children { get; set; }
    public string ParentId { get; set; }
}
public class Share
{
    public string Access { get; set; }
    public string Type { get; set; }
}

