using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senkel.Model.Measuring;

/// <summary>
/// Represents an adapter that implements the <see cref="IStopwatch"/> interface based on an <see cref="Stopwatch"/> object.
/// </summary>
public class StopwatchAdapter : IStopwatch
{
    private readonly Stopwatch _stopwatch;

    /// <summary>
    /// Initializes a new instance of the <see cref="StopwatchAdapter"/> class that is based on a new <see cref="Stopwatch"/> instance.
    /// </summary>
    public StopwatchAdapter() : this(new Stopwatch()) { }

    /// <summary>
    /// Initializes a new instance of the <see cref="StopwatchAdapter"/> class that is based the specified stopwatch.
    /// </summary>
    public StopwatchAdapter(Stopwatch stopwatch)
    {  
        _stopwatch = stopwatch;
    }

    /// <inheritdoc/>
    public TimeSpan Elapsed => _stopwatch.Elapsed;

    /// <inheritdoc/>
    public bool Running => _stopwatch.IsRunning;

    /// <inheritdoc/>
    public void Reset()
    {
        _stopwatch.Reset();
    }

    /// <inheritdoc/>
    public void Restart()
    {
        _stopwatch.Restart();
    }

    /// <inheritdoc/>
    public void Start()
    {
        _stopwatch.Start();
    }

    /// <inheritdoc/>
    public void Stop()
    {
        _stopwatch.Stop();
    }
}
