using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senkel;

/// <summary>
/// Represents a decorator that is capable of decorating by returning an object that is based on another argument value.
/// </summary>
/// <typeparam name="T">The type of the object that can be modified by the decorator.</typeparam>
public interface IDuplexDecorator<T>
{
    /// <summary>
    /// Decorates by returning a modified result based on the specified argument value.
    /// </summary>
    /// <param name="value">The value to base the modified result object on.</param>
    /// <returns>The modified result based on the specified argument value.</returns>
    public T Decorate(T value);
}
