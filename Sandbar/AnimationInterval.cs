using System;

namespace Sandbar
{
    public struct AnimationInterval
    {
        /// <summary>
        /// Update every 10th of a second.
        /// </summary>
        public static readonly TimeSpan Short = TimeSpan.FromSeconds(1.0 / 10);

        /// <summary>
        /// Update every 5th of a second.
        /// </summary>
        public static readonly TimeSpan Medium = TimeSpan.FromSeconds(1.0 / 5);

        /// <summary>
        /// Update every half second.
        /// </summary>
        public static readonly TimeSpan Long = TimeSpan.FromSeconds(1.0 / 2);

        /// <summary>
        /// Update every second.
        /// </summary>
        public static readonly TimeSpan Second = TimeSpan.FromSeconds(1.0);
    }
}