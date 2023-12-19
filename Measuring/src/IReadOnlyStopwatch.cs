using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senkel.Model.Measuring
{
    /// <summary>
    /// Represents a stopwatch that exposes the measured time, but does not grant access to manipulating the stopwatch.
    /// </summary>
    public interface IReadOnlyStopwatch
    {
        /// <summary>
        /// How much time has been measured by the stopwatch.
        /// </summary>
        public TimeSpan Elapsed { get; }

        /// <summary>
        /// Indicates if the stopwatch is currently running.
        /// </summary>
        public bool Running { get; }

    }
}
