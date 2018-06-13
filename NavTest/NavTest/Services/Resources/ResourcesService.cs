using System;
using System.Collections.Generic;

namespace NavTest.Services.Resources
{
    public class ResourcesService
    {
        private readonly Dictionary<Color, Int32> colors;
        
        internal ResourcesService(Dictionary<Color, Int32> colors)
        {
            this.colors = colors;
        }

        public Int32 GetColor(Color color)
        {
            return this.colors[color];
        }
    }
}
