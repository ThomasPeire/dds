namespace DDS.BuildingBlocks.Domain;

public interface IAuditable
{
    public DateTime CreatedOn { get; }
    public DateTime UpdatedOn { get; }
    public Guid CreatedBy { get; }
    public Guid UpdatedBy { get; }
}