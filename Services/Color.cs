using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public abstract class Color
    {
        protected string colorName;

        public Color()
        {
            SetColorName();
        }

        protected virtual void SetColorName()
        {
            this.colorName = this.GetType().Name;
        }

        public abstract void Fill();
    }
}
