﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace TelCo.ColorCoder
{
   public class ColorPairs
    {
        
         public  Color majorColor;
          public  Color minorColor;
            public override string ToString()
            {
                return string.Format("MajorColor:{0}, MinorColor:{1}", majorColor.Name, minorColor.Name);
            }
      
    }
}
