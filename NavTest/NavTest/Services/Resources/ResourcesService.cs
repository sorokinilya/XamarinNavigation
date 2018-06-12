using System;
using System.Collections.Generic;

namespace NavTest.Services.Resources
{
    public class ResourcesService<T>
    {
        private readonly Dictionary<Color, T> colors = new Dictionary<Color, T>();

        private readonly Func<Int32, T> colorMaker;
        
        internal ResourcesService(Func<Int32, T> colorMaker)
        {
            this.colorMaker = colorMaker;
        }

        internal void Initialize(Dictionary<Color, Int32> coors)
        {
            foreach (KeyValuePair<Color, Int32> pair in coors)
            {
                this.addColor(pair.Key, pair.Value);
            }
        }

        public T GetColor(Color color)
        {
            return this.colors[color];
        }

        internal void addColor(Color color, Int32 rgb)
        {
            this.colors[color] = this.colorMaker(rgb);
        }

    }
}
