namespace cs8;

public class CreationUrl
{
    private const string Url = "https://seadox.ru/api/seadocs/";
    private string Id {get;}
    public string FullUrl {get;}

    public CreationUrl(string id)
    {
        Id = id;
        FullUrl = Url + Id;
    }
}