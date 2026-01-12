
namespace cs8;

public class SiteData
{
    public string AccessLevel { get; set; }
    public Share Share { get; set; }
    public List<LineageItem> Lineage { get; set; }
    public List<object> Children { get; set; }
    public string Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public bool IsIndexed { get; set; }
    public string CoverUrl { get; set; }
    public string OwnerId { get; set; }
    public string ParentId { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}

public class Share
{
    public string Access { get; set; }
    public string Type { get; set; }
}

public class LineageItem
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public bool IsIndexed { get; set; }
    public string CoverUrl { get; set; }
    public string OwnerId { get; set; }
    public string ParentId { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}