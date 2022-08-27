namespace WebApi.Models;

public class Operation
{
    public Operation()
    {

    }

    public Operation(string name, string alias)
    {
        OperationName = name;
        OperationAlias = alias;
    }

    public Guid Id { get; set; }
    public string? OperationName { get; set; }
    public string? OperationAlias { get; set; }
    public ICollection<Location?>? OperationLocations { get; set; }
    // public Location? Location { get; set; }
    // public Collection<Location?> Locations { get; set; }

    // debug override ToString() method
    public string ToString()
    {
        return $"OperationName: {OperationName}\nOperationAlias: {OperationAlias}";
    }
}
