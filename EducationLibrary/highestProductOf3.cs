using System;
using System.Collections.Generic;

namespace EducationLibrary
{
    public static class Functions
    {
        public static long highestProductOf3(IList<int> arrayOfInts)
        {
            if (arrayOfInts == null)
            {
                throw new ArgumentNullException("arrayOfInts");
            }

            if (arrayOfInts.Count < 3)
            {
                throw new ArgumentException("Less than 3 items!");
            }

            // We're set the minimum values for this type as the starting values.
            var highest = long.MinValue;
            var highestProductOf2 = long.MinValue;
            var highestProductOf3 = long.MinValue;

            // walk through items
            foreach (var current in arrayOfInts)
            {
                // do we have a new highest product of 3?
                // it's either the current highest,
                // or the current times the highest product of two
                highestProductOf3 = Math.Max(
                    highestProductOf3,
                    current * highestProductOf2);

                // do we have a new highest product of two?
                highestProductOf2 = Math.Max(
                    highestProductOf2,
                    current * highest);

                // do we have a new highest?
                highest = Math.Max(highest, current);
            }

            return highestProductOf3;
        }
    }
}
