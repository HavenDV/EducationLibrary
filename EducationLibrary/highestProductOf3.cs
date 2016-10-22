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

            // We're going to start at the 3rd item (at index 2)
            // so pre-populate highests based on the first 2 items.
            // we could also start these as null and check below if they're set
            // but this is arguably cleaner
            long highest = Math.Max(arrayOfInts[0], arrayOfInts[1]);
            long highestProductOf2 = arrayOfInts[0] * arrayOfInts[1];

            // except this one--we pre-populate it for the first /3/ items.
            // this means in our first pass it'll check against itself, which is fine.
            long highestProductOf3 = arrayOfInts[0] * arrayOfInts[1] * arrayOfInts[2];

            // walk through items, starting at index 2
            for (int i = 2; i < arrayOfInts.Count; ++i)
            {
                int current = arrayOfInts[i];

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
