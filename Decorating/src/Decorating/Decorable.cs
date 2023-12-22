using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senkel;

/// <summary>
/// Represents an object that can be decorated by another <see cref="IDecorator"/> object.
/// </summary>
public abstract class Decorable
{
    /// <summary>
    /// The decorator that is used by the decorable instance.
    /// </summary>
    protected readonly IDecorator Decorator;

    /// <summary>
    /// Creates a new instance of the <see cref="Decorable"/> class that is decorated by the specified <see cref="IDecorator"/> object.
    /// </summary>
    /// <param name="decorator">The decorator that this <see cref="Decorable"/> instance is decorated by.</param>
    public Decorable(IDecorator decorator)
    {
        Decorator = decorator;
    }

    /// <summary>
    /// Creates a new instance of the <see cref="Decorable"/> class that is not decorated by any <see cref="IDecorator"/> object
    /// by using the <see cref="IdentityDecorator.Instance"/> value instead.
    /// </summary>
    public Decorable() : this(IdentityDecorator.Instance) { }

    /// <summary>
    /// Decorates the object using the initially set <see cref="IDecorator"/> object.
    /// </summary>
    protected void Decorate()
    {
        Decorator.Decorate();
    }
}

/// <summary>
/// Represents an object that can be decorated by another <see cref="IDecorator{T}"/> object.
/// </summary>
public class Decorable<T>
{
    /// <summary>
    /// The decorator that is used by the decorable instance.
    /// </summary>
    protected readonly IDecorator<T> Decorator;

    /// <summary>
    /// Creates a new instance of the <see cref="Decorable{T}"/> class that is decorated by the specified <see cref="IDecorator{T}"/> object.
    /// </summary>
    /// <param name="decorator">The decorator that this <see cref="Decorable{T}"/> instance is decorated by.</param>
    public Decorable(IDecorator<T> decorator)
    {
        Decorator = decorator;
    }

    /// <summary>
    /// Creates a new instance of the <see cref="Decorable{T}"/> class that is not decorated by any <see cref="IDecorator{T}"/> object
    /// by using the <see cref="IdentityDecorator{T}.Instance"/> value instead.
    /// </summary>
    public Decorable() : this(IdentityDecorator<T>.Instance) { }

    /// <summary>
    /// Decorated the object using the initially set <see cref="IDecorator{T}"/> object.
    /// </summary>
    protected void Decorate(T value)
    {
        Decorator.Decorate(value);
    }
}

