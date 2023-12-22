using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senkel;

/// <summary>
/// Represents an object that can be decorated by another <see cref="IDuplexDecorator{T}"/> object.
/// </summary>
public class DuplexDecorable<T>
{
    /// <summary>
    /// The decorator that is used by the decorable instance.
    /// </summary>
    protected readonly IDuplexDecorator<T> Decorator;

    /// <summary>
    /// Creates a new instance of the <see cref="DuplexDecorable{T}"/> class that is decorated by the specified <see cref="IDuplexDecorator{T}"/> object.
    /// </summary>
    /// <param name="decorator">The decorator that this <see cref="DuplexDecorable{T}"/> instance is decorated by.</param>
    public DuplexDecorable(IDuplexDecorator<T> decorator)
    {
        Decorator = decorator;
    }

    /// <summary>
    /// Creates a new instance of the <see cref="DuplexDecorable{T}"/> class that is not decorated by any <see cref="IDuplexDecorator{T}"/> object
    /// by using the <see cref="IdentityDecorator{T}.Instance"/> value instead.
    /// </summary>
    public DuplexDecorable() : this(IdentityDecorator<T>.Instance) { }

    /// <summary>
    /// Decorates the object using the initially set <see cref="IDuplexDecorator{T}"/> object.
    /// </summary>
    protected T Decorate(T value)
    {
        return Decorator.Decorate(value);
    }
}

