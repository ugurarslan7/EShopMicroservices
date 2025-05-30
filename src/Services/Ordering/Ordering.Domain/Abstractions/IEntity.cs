namespace Ordering.Domain.Abstractions;

public interface IEntity<T> : IEntity
{
    public T Id { get; set; }
}
public interface IEntity
{
    public DateTime? CreatedDate { get; set; }
    public string? CreatedUser { get; set; }
    public DateTime? UpdatedDate { get; set; }
    public string? UpdatedUser { get; set; }
}
