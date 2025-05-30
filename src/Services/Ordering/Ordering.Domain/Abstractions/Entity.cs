namespace Ordering.Domain.Abstractions;

public abstract class Entity<T>:IEntity<T> 
{
    public T Id { get; set; }
    public DateTime? CreatedDate { get; set; }
    public string? CreatedUser { get; set; }
    public DateTime? UpdatedDate { get; set; }
    public string? UpdatedUser { get; set; }
}
