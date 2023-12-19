namespace Senkel.Model.Creating;

/// <summary>
/// Represents an object that is responsible for creating objects of the specified type.
/// </summary>
/// <typeparam name="T">The type of the objects that can be created with this factory.</typeparam>
public interface IFactory<out T>
{
    /// <summary>
    /// Returns an object that this factory creates.
    /// </summary> 
    public T Create();
}

/// <summary>
/// Represents an object that is responsible for creating objects of the specified type.
/// </summary>
/// <typeparam name="T">The type of the objects that can be created with this factory.</typeparam>
/// <typeparam name="TArg">The argument passed into the creation method.</typeparam>
public interface IFactory<out T, in TArg>
{
    /// <summary>
    /// Returns an object that this factory creates.
    /// </summary> 
    /// <param name="value">The argument of the factory.</param>
    public T Create(TArg value);
}

/// <summary>
/// Represents an object that is responsible for creating objects of the specified type.
/// </summary>
/// <typeparam name="T">The type of the objects that can be created with this factory.</typeparam>
/// <typeparam name="TArg1">The first argument passed into the creation method.</typeparam>
/// <typeparam name="TArg2">The second argument passed into the creation method.</typeparam>
public interface IFactory<out T, in TArg1, in TArg2>
{
    /// <summary>
    /// Returns an object that this factory creates.
    /// </summary> 
    /// <param name="value1">The first argument.</param>
    /// <param name="value2">The second argument.</param>
    public T Create(TArg1 value1, TArg2 value2);
}
