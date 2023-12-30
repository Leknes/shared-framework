using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senkel;

/// <summary>
/// Represents an implementation of the <see cref="IDecorator"/> interface that decorates by executing a method with no parameters and no return value.
/// </summary>
public abstract class Decorator : Decorable, IDecorator
{
    /// <summary>
    /// Creates a new instance of the <see cref="Decorator"/> class that is based on the specified base decorator.
    /// </summary>
    /// <param name="decorator">The decorator that this <see cref="Decorator"/> instance is based on.</param>
    public Decorator(IDecorator decorator) : base(decorator) { }

    /// <summary>
    /// Creates a new instance of the <see cref="Decorator"/> class that is based on no other decorator and therefore functions as a root for other decorators.
    /// </summary>
    public Decorator() : base() { }

    /// <summary>
    /// Decorates by executing some behaviour.
    /// </summary>
    public new virtual void Decorate()
    {
        base.Decorate();
    }
}

/// <summary>
/// Represents an implementation of the <see cref="IDecorator"/> interface that decorates by executing a method with one parameter of the specified type and no return value.
/// </summary>
/// <typeparam name="T">The type of the parameter used in the <see cref="Decorate"/> method.</typeparam>
public abstract class Decorator<T> : Decorable<T>, IDecorator<T>
{
    /// <summary>
    /// Creates a new instance of the <see cref="Decorator{T}"/> class that is based on the specified base decorator.
    /// </summary>
    /// <param name="decorator">The decorator that this <see cref="Decorator{T}"/> instance is based on.</param>
    public Decorator(IDecorator<T> decorator) : base(decorator) { }

    /// <summary>
    /// Creates a new instance of the <see cref="Decorator{T}"/> class that is based on no other decorator and therefore functions as a root for other decorators.
    /// </summary>
    public Decorator() : base() { }

    /// <summary>
    /// Decorates by executing some behaviour based on the specified value.
    /// </summary>
    /// <param name="value">The value to use for decorating.</param>
    public virtual new void Decorate(T value)
    {
        base.Decorate(value);
    }
}