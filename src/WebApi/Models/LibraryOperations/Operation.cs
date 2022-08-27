namespace WebApi.Models;

public class Operation
{
    public Guid Id { get; set; }
    public string? OperationName { get; set; }
    public string? OperationAlias { get; set; }
    public ICollection<Location?>? OperationLocations { get; set; }
    // public Location? Location { get; set; }
    // public Collection<Location?> Locations { get; set; }
}
