using System;
using System.Text;

namespace BinaryRepresentation
{
    public static class BitsManipulation
    {
        /// <summary>
        /// Get binary memory representation of signed long integer.
        /// </summary>
        /// <param name="number">Source number.</param>
        /// <returns>Binary memory representation of signed long integer.</returns>
        public static string GetMemoryDumpOf(long number)
        {
            const int bitsPerByte = 8;
            const int longSizeInBytes = sizeof(long);
            const int longSizeInBits = longSizeInBytes * bitsPerByte;

            StringBuilder builder = new StringBuilder(longSizeInBits);
            for (int i = longSizeInBits - 1; i >= 0; i--)
            {
                long mask = 1L << i;
                long bit = (number & mask) >> i;

                builder.Append(bit);
            }

            if (number < 0)
            {
                builder.Remove(0, 1);
            }

            return builder.ToString();
        }
    }
}
