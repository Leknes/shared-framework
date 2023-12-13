using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senkel.ObjectModel.Rendering;

/// <summary>
/// Represents a renderer that always returns the initially set identity value without any modification.
/// </summary>
/// <typeparam name="T">The type of the identity value to render.</typeparam>
public class IdentityRenderer<T> : IRenderer<T>
{
    private readonly T _identity;

    /// <summary>
    /// Creates a new instance of the <see cref="IdentityRenderer{T}"/> class that returns the specified value in the <see cref="Render"/> method.
    /// </summary>
    /// <param name="identity">The value to return in the <see cref="Render"/> method.</param>
    public IdentityRenderer(T identity)
    {
        _identity = identity;
    }

    /// <summary>
    /// Returns the initially set identity object of the <see cref="IdentityRenderer{T}"/> instance.
    /// </summary> 
    public T Render()
    {
        return _identity;
    }
}