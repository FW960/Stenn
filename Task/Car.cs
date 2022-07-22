namespace Stenn.Task;

public class Car
{
    public string Model { get; set; }

    public string Color { get; set; }

    public string Description { get; set; }

    public override int GetHashCode() => Model.GetHashCode() + Color.GetHashCode();

    public override bool Equals(object? obj)
    {
        if (obj != null)
            return obj.GetHashCode() == this.GetHashCode();
        else
            return false;
    }
}