using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senkel;

/// <summary>
/// Represents a stopwatch that measures time with an offset that is initially set.
/// </summary>
public class OffsetStopwatch : IStopwatch
{
    private readonly TimeSpan _elapsedOffset;
    private readonly IStopwatch _stopwatch;

    /// <summary>
    /// How much time has been measured by the stopwatch with the initially set offset added.
    /// </summary>
    public TimeSpan Elapsed => _stopwatch.Elapsed + _elapsedOffset;

    /// <inheritdoc/>
    public bool Running => _stopwatch.Running;

    /// <summary>
    /// Initializes a new <see cref="OffsetStopwatch"/>
    /// </summary>
    /// <param name="stopwatch"></param>
    /// <param name="elapsedOffset"></param>
    public OffsetStopwatch(IStopwatch stopwatch, TimeSpan elapsedOffset = default)
    {
        _stopwatch = stopwatch;
        _elapsedOffset = elapsedOffset;
    }

    /// <inheritdoc/>
    public void Reset() => _stopwatch.Reset();

    /// <inheritdoc/>
    public void Restart() => _stopwatch.Restart();

    /// <inheritdoc/>
    public void Start() => _stopwatch.Start();

    /// <inheritdoc/>
    public void Stop() => _stopwatch.Stop();
}
