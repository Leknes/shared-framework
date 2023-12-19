using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senkel.Model.Decorating;
 
/// <summary>
/// Represents a decorator that decorates by executing a method with no parameters and no return value.
/// </summary>
public interface IDecorator
{
    /// <summary>
    /// Decorates by executing some behaviour.
    /// </summary>
    public void Decorate();
}

/// <summary>
/// Represents a decorator that decorates by executing a method with one parameter of the specified type and no return value.
/// </summary>
/// <typeparam name="T">The type of the parameter used in the <see cref="Decorate"/> method.</typeparam>
public interface IDecorator<in T>
{
    /// <summary>
    /// Decorates by executing some behaviour based on the specified value.
    /// </summary>
    /// <param name="value">The value to use for decorating.</param>
    public void Decorate(T value);
}
 