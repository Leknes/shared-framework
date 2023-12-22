using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senkel;

/// <summary>
/// Represents an object that is capable of rendering an image of the specified type.
/// </summary>
/// <typeparam name="T">The type of the image object to be created.</typeparam>
public interface IRenderer<out T>
{
    /// <summary>
    /// Returns an image object that represents the current state of the rendered object.
    /// </summary>
    public T Render();
}