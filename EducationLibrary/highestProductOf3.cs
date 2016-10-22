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
            // so pre-populate highests and lowests based on the first 2 items.
            // we could also start these as null and check below if they're set
            // but this is arguably cleaner
            long highest = Math.Max(arrayOfInts[0], arrayOfInts[1]);
            long lowest = Math.Min(arrayOfInts[0], arrayOfInts[1]);
            long highestProductOf2 = arrayOfInts[0] * arrayOfInts[1];
            long lowestProductOf2 = arrayOfInts[0] * arrayOfInts[1];

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
                // or the current times the lowest product of two
                highestProductOf3 = Math.Max(Math.Max(
                    highestProductOf3,
                    current * highestProductOf2),
                    current * lowestProductOf2);

                // do we have a new highest product of two?
                highestProductOf2 = Math.Max(Math.Max(
                    highestProductOf2,
                    current * highest),
                    current * lowest);

                // do we have a new lowest product of two?
                lowestProductOf2 = Math.Min(Math.Min(
                    lowestProductOf2,
                    current * highest),
                    current * lowest);

                // do we have a new highest?
                highest = Math.Max(highest, current);

                // do we have a new lowest?
                lowest = Math.Min(lowest, current);
            }

            return highestProductOf3;
        }
    }
}
