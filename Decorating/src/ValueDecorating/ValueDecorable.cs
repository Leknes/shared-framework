using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senkel.ObjectModel.Decorating;


/// <summary>
/// Represents an object that can be decorated by another <see cref="IValueDecorator{T}"/> object.
/// </summary>
public class ValueDecorable<T>
{
    private readonly IValueDecorator<T> _decorator;

    /// <summary>
    /// Creates a new instance of the <see cref="ValueDecorable{T}"/> class that is decorated by the specified <see cref="IValueDecorator{T}"/> object.
    /// </summary>
    /// <param name="decorator">The decorator that this <see cref="ValueDecorable{T}"/> instance is decorated by.</param>
    public ValueDecorable(IValueDecorator<T> decorator)
    {
        _decorator = decorator;
    }

    /// <summary>
    /// Creates a new instance of the <see cref="ValueDecorable{T}"/> class that is not decorated by any <see cref="IValueDecorator{T}"/> object
    /// by using the <see cref="IdentityDecorator{T}.Instance"/> value instead.
    /// </summary>
    public ValueDecorable() : this(IdentityDecorator<T>.Instance) { }

    /// <summary>
    /// Decorates the object using the initially set <see cref="IValueDecorator{T}"/> object.
    /// </summary>
    protected T Decorate(T value)
    {
       return _decorator.Decorate(value);
    }
}

