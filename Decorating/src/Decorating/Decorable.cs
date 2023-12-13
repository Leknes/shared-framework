using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senkel.ObjectModel.Decorating;

/// <summary>
/// Represents an object that can be decorated by another <see cref="IDecorator"/> object.
/// </summary>
public abstract class Decorable
{
    private readonly IDecorator _decorator;

    /// <summary>
    /// Creates a new instance of the <see cref="Decorable"/> class that is decorated by the specified <see cref="IDecorator"/> object.
    /// </summary>
    /// <param name="decorator">The decorator that this <see cref="Decorable"/> instance is decorated by.</param>
    public Decorable(IDecorator decorator)
    {
        _decorator = decorator;
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
        _decorator.Decorate();
    }
}

/// <summary>
/// Represents an object that can be decorated by another <see cref="IDecorator{T}"/> object.
/// </summary>
public class Decorable<T>
{
    private readonly IDecorator<T> _decorator;

    /// <summary>
    /// Creates a new instance of the <see cref="Decorable{T}"/> class that is decorated by the specified <see cref="IDecorator{T}"/> object.
    /// </summary>
    /// <param name="decorator">The decorator that this <see cref="Decorable{T}"/> instance is decorated by.</param>
    public Decorable(IDecorator<T> decorator)
    {
        _decorator = decorator;
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
        _decorator.Decorate(value);
    }
}

