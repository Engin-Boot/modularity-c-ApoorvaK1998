using System;
using System.Collections.Generic;
using System.Text;
using static TelCo.ColorCoder.ColorPairs;

namespace TelCo.ColorCoder
{
    public class GetPairNumberFromColors
    {
        
        public static int GetPairNumberFromColor(ColorPairs pair)
        {

            // Find the major color in the array and get the index
            int majorIndex = -1;
            for (int i = 0; i < Program.colorMapMajor.Length; i++)
            {
                ColorPairs color = new ColorPairs();
                if (Program.colorMapMajor[i] == color.majorColor)
                {
                    majorIndex = i;
                    break;
                }
            }

            // Find the minor color in the array and get the index
            int minorIndex = -1;
            for (int i = 0; i < Program.colorMapMinor.Length; i++)
            {
                ColorPairs color = new ColorPairs();
                if (Program.colorMapMinor[i] == color.minorColor)
                {
                    minorIndex = i;
                    break;
                }
            }
            // If colors can not be found throw an exception
            if (majorIndex == -1 || minorIndex == -1)
            {
                throw new ArgumentException(
                    string.Format("Unknown Colors: {0}", pair.ToString()));
            }

            // Compute pair number and Return  
            // (Note: +1 in compute is because pair number is 1 based, not zero)
            return (majorIndex * Program.colorMapMinor.Length) + (minorIndex + 1);
        }
    }
}
