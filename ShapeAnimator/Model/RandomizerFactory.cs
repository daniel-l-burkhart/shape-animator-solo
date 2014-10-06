using System;

namespace ShapeAnimator.Model
{
    /// <summary>
    ///     Randomizer factory used for all RandomVariable instances throughout project.
    /// </summary>
    public static class RandomizerFactory
    {
        private static readonly Random RandomVariable = new Random();

        /// <summary>
        ///     Makes the randomizer.
        /// </summary>
        /// <returns></returns>
        public static Random MakeRandomizer()
        {
            return RandomVariable;
        }
    }
}