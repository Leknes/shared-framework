﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senkel.ObjectModel.Decorating;

/// <summary>
/// Represents an implementation of the <see cref="IValueDecorator{T}"/> interface that decorates by executing a method which returns a modified object of the specified type based on the specified argument.
/// </summary>
/// <typeparam name="T">The type of the argument and the result used in the <see cref="Decorate"/> method.</typeparam>
public abstract class ValueDecorator<T> : ValueDecorable<T>, IValueDecorator<T>
{ 
    /// <summary>
    /// Creates a new instance of the <see cref="ValueDecorator{T}"/> class that is based on the specified base decorator.
    /// </summary>
    /// <param name="decorator">The decorator that this <see cref="ValueDecorator{T}"/> instance is based on.</param>
    public ValueDecorator(IValueDecorator<T> decorator) : base(decorator) { }
     
    /// <summary>
    /// Creates a new instance of the <see cref="ValueDecorator{T}"/> class that is based on no other decorator and therefore functions as a root for other decorators.
    /// </summary>
    public ValueDecorator() : base() { }

    /// <summary>
    /// Decorates by returning a modified result based on the specified argument value.
    /// </summary>
    /// <param name="value">The value to base the modified result object on.</param>
    /// <returns>The modified result based on the specified argument value.</returns>
    public virtual new T Decorate(T value)
    {
        return base.Decorate(value);
    }
     
} 