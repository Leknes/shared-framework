namespace Senkel.ObjectModel.Creational;

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
public interface IFactory<out T, in TArgument>
{
    /// <summary>
    /// Returns an object that this factory creates.
    /// </summary> 
    /// <param name="value">The argument of the factory.</param>
    public T Create(TArgument value);
}

/// <summary>
/// Represents an object that is responsible for creating objects of the specified type.
/// </summary>
/// <typeparam name="T">The type of the objects that can be created with this factory.</typeparam>
public interface IFactory<out T, in TArgument1, in TArgument2>
{
    /// <summary>
    /// Returns an object that this factory creates.
    /// </summary> 
    /// <param name="value1">The first argument.</param>
    /// <param name="value2">The second argument.</param>
    public T Create(TArgument1 value1, TArgument2 value2);
}
