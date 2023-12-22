using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senkel;

/// <summary>
/// Represents a decorator that preserves the entity of the <see cref="IDecorator"/> object that used this <see cref="Instance"/> value as a base and therefore does not apply any modifications.
/// </summary>
public class IdentityDecorator : IDecorator
{
    private IdentityDecorator() { }

    /// <summary>
    /// Returns a singleton instance of the <see cref="IdentityDecorator"/> class.
    /// </summary>
    public static IdentityDecorator Instance { get; } = new IdentityDecorator();

    void IDecorator.Decorate() { }
}

/// <summary>
/// Represents a decorator that preserves the entity of the <see cref="IDecorator{T}"/> or <see cref="IDuplexDecorator{T}"/> object that used this <see cref="Instance"/> value as a base and therefore does not apply any modifications.
/// </summary>
public class IdentityDecorator<T> : IDuplexDecorator<T>, IDecorator<T>
{
    private IdentityDecorator() { }

    /// <summary>
    /// Returns a singleton instance of the <see cref="IdentityDecorator{T}"/> class.
    /// </summary>
    public static IdentityDecorator<T> Instance { get; } = new IdentityDecorator<T>();

    void IDecorator<T>.Decorate(T value) { }

    T IDuplexDecorator<T>.Decorate(T value)
    {
        return value;
    }
}