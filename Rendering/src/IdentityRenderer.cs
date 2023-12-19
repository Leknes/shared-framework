using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senkel.Model.Rendering;

/// <summary>
/// Represents a renderer that always returns the initially set identity value without any modification.
/// </summary>
/// <typeparam name="T">The type of the identity value to render.</typeparam>
public class IdentityRenderer<T> : IRenderer<T>
{
    private readonly T _identity;

    /// <summary>
    /// Creates a new instance of the <see cref="IdentityRenderer{T}"/> class that returns the specified value in the <see cref="IRenderer{T}.Render"/> method.
    /// </summary>
    /// <param name="identity">The value to return in the <see cref="IRenderer{T}.Render"/> method.</param>
    public IdentityRenderer(T identity)
    {
        _identity = identity;
    }

    T IRenderer<T>.Render()
    {
        return _identity;
    }
}