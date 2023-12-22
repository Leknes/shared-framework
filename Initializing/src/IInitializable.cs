namespace Senkel;

/// <summary>
/// Represents an object that can be initialized.
/// </summary>
public interface IInitializable
{
    /// <summary>
    /// Initializes the object.
    /// </summary>
    public void Initialize();
}

/// <summary>
/// Represents an object that can be initialized using a value.
/// </summary>
/// <typeparam name="T">The type of the value.</typeparam>
public interface IInitializable<in T>
{
    /// <summary>
    /// Initializes the object using the specified value.
    /// </summary>
    /// <param name="value">The value used for initializing.</param>
    public void Initialize(T value);
}

/// <summary>
/// Represents an object that can be initialized  using some values.
/// </summary>
/// <typeparam name="T1">The type of the first value.</typeparam>
/// <typeparam name="T2">The type of the second value.</typeparam>
public interface IInitializable<in T1, in T2>
{
    /// <summary>
    /// Initializes the object using the specified values.
    /// </summary>
    /// <param name="value1">The first value used for initializing.</param>
    /// <param name="value2">The second value used for initializing.</param>
    public void Initialize(T1 value1, T2 value2);
}

/// <summary>
/// Represents an object that can be initialized using some values.
/// </summary>
/// <typeparam name="T1">The type of the first value.</typeparam>
/// <typeparam name="T2">The type of the second value.</typeparam>
/// <typeparam name="T3">The type of the third value.</typeparam>
public interface IInitializable<in T1, in T2, in T3>
{
    /// <summary>
    /// Initializes the object using the specified values.
    /// </summary>
    /// <param name="value1">The first value used for initializing.</param>
    /// <param name="value2">The second value used for initializing.</param>
    /// <param name="value3">The third value used for initializing.</param>
    public void Initialize(T1 value1, T2 value2, T3 value3);
}