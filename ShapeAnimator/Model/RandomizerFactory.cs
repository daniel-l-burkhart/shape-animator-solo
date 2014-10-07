using System;

namespace ShapeAnimator.Model
{
    /// <summary>
    ///     Randomizer factory used for all randomVariable instances throughout project.
    /// </summary>
    public static class RandomizerFactory
    {
        /// <summary>
        ///     Makes the randomizer.
        /// </summary>
        /// <returns></returns>
        public static Random MakeRandomizer()
        {
            var newRandomizer = new Random();
            return newRandomizer;
        }
    }
}