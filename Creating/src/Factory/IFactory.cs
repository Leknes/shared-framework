namespace Senkel;

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
/// <typeparam name="TParameter">The parameter of the creation method.</typeparam>
public interface IFactory<out T, in TParameter>
{
    /// <summary>
    /// Returns an object that this factory creates.
    /// </summary> 
    /// <param name="value">The argument of the factory.</param>
    public T Create(TParameter value);
}

/// <summary>
/// Represents an object that is responsible for creating objects of the specified type.
/// </summary>
/// <typeparam name="T">The type of the objects that can be created with this factory.</typeparam>
/// <typeparam name="TParameter1">The first parameter of the creation method.</typeparam>
/// <typeparam name="TParameter2">The second parameter of the creation method.</typeparam>
public interface IFactory<out T, in TParameter1, in TParameter2>
{
    /// <summary>
    /// Returns an object that this factory creates.
    /// </summary> 
    /// <param name="value1">The first argument.</param>
    /// <param name="value2">The second argument.</param>
    public T Create(TParameter1 value1, TParameter2 value2);
}
