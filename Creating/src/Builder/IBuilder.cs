namespace Senkel.Model.Creating;

/// <summary>
/// Represents a object that is responsible for building an object of the specified type.
/// </summary>
/// <typeparam name="T">The type of the object to build.</typeparam>
public interface IBuilder<out T>
{
    /// <summary>
    /// Returns the object that this builder is responsible for building.
    /// </summary> 
    public T Build();
}