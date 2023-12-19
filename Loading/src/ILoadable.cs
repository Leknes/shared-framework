namespace Senkel.Model.Loading;

/// <summary>
/// Represents an object that can be loaded and unloaded.
/// </summary>
public interface ILoadable
{
    /// <summary>
    /// Loads the object.
    /// </summary>
    public void Load();

    /// <summary>
    /// Unloads the object.
    /// </summary>
    public void Unload();
}