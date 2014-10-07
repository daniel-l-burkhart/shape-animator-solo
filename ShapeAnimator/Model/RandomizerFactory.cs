using System;

namespace ShapeAnimator.Model
{
    /// <summary>
    ///     Randomizer factory used for all RandomVariable instances throughout project.
    /// </summary>
    public static class RandomizerFactory
    {
        /// <summary>
        ///     The random utility variable
        /// </summary>
        public static readonly Random RandomVariable = new Random();

        static RandomizerFactory()
        {
        }
    }
}