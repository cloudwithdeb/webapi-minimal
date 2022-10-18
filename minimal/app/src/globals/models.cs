namespace GlobalModelsNamespace;

public class GlobalModels
{
    public Guid id {get; set;} = Guid.NewGuid();
    public DateTime datetime {get; set;} = DateTime.UtcNow;
    public DateOnly date {get; set;} = DateOnly.FromDateTime(DateTime.UtcNow);
    public TimeOnly time {get; set;} = TimeOnly.FromDateTime(DateTime.Today);
}