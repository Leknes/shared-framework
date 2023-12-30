namespace Senkel;

/// <summary>
/// Represents a converter that is capable of converting objects of the <typeparamref name="TInput"/> type 
/// to an object of the <typeparamref name="TOutput"/> type.
/// </summary>
/// <typeparam name="TInput">The type of the objects that this converter can convert from.</typeparam>
/// <typeparam name="TOutput">The type that this converter can convert objects to.</typeparam>
public interface IConverter<in TInput, out TOutput>
{
    /// <summary>
    /// Converts the specified object to an object of the <typeparamref name="TOutput"/> type.
    /// </summary>
    /// <param name="input">The object to convert.</param>
    /// <returns>The converted result.</returns>
    public TOutput Convert(TInput input);
}
