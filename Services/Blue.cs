using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class Blue : Color
    {
        public override void Fill()
        {
            Console.WriteLine($"填充{colorName}颜色");
        }
    }
}
