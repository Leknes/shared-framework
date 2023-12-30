namespace Senkel;

/// <summary>
/// Represents an object that can be converted to another instance of the type <typeparamref name="T"/>.
/// </summary>
/// <typeparam name="T">The that this object can be converted to.</typeparam>
public interface IConvertible<out T>
{
    /// <summary>
    /// Converts this object to an instance of the type <typeparamref name="T"/>.
    /// </summary>
    /// <returns>The converted object.</returns>
    public T Convert();
}
