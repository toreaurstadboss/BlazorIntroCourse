public class MyService : IMyService
{

    public List<string> Names { get; set; } = new List<string>();

    public void AddName(string name)
    {
        Names.Add(name);
    }

    public MyService()
    {
        AddName("Toreboss");
        AddName("Steve Sandersson");
        AddName("Erik Braut Haaland");
    }

}