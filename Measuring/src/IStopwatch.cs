namespace Senkel;
/// <summary>
/// Represents a stopwatch that can be started, stopped and reset.
/// </summary>
public interface IStopwatch : IReadOnlyStopwatch
{
    /// <summary>
    /// Starts or resumes the measurement of the stopwatch.
    /// </summary>
    public void Start();

    /// <summary>
    /// Stops the measurement of the stopwatch, but should not reset the elapsed time.
    /// </summary>
    public void Stop();

    /// <summary>
    /// Stops the measurement of the stopwatch and resets the elapsed time.
    /// </summary>
    public void Reset();

    /// <summary>
    /// Resets the elapsed time and restarts the stopwatch.
    /// </summary>
    public void Restart();
}