using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAnimator.Model
{
         /// <summary>
        ///     Randomizer factory used for all random instances throughout project.
        /// </summary>
    public static class RandomizerFactory
    {
            /// <summary>
            ///     Makes the randomizer.
            /// </summary>
            /// <returns></returns>
            public static Random MakeRandomizer()
            {
                var random = new Random();
                return random;
            }
        }
    }
