using System;
using System.Collections.Generic;

namespace NavTest.Services.Resources
{
    public class BaseResourcesService
    {
        private readonly Dictionary<Color, Int32> colors = new Dictionary<Color, Int32>();
        private readonly Dictionary<Localized, string> strings = new Dictionary<Localized, string>();

        public BaseResourcesService()
        {
        }

        public virtual void Initialize()
        {
            foreach (var item in this.defaultColors())
            {
                this.SetColor(item.Key, item.Value);
            }
            foreach (var item in this.defaultStrings())
            {
                this.SetString(item.Key, item.Value);
            }
        }

        public Int32 GetColor(Color key)
        {
            return this.colors[key];
        }

        public string GetString(Localized key)
        {
            return this.strings[key];
        }

        protected void SetColor(Color key, Int32 value)
        {
            this.colors[key] = value;
        }

        protected void SetString(Localized key, string value)
        {
            this.strings[key] = value;
        }

        protected virtual Dictionary<Localized, string> defaultStrings()
        {
            return new Dictionary<Localized, string> {
            {Localized.AI_Title, "New item"},
            {Localized.AI_ItemTitle, "Title"},
            {Localized.AI_ItemDescription, "Description"} };
        }

        protected virtual Dictionary<Color, Int32> defaultColors()
        {
            return new Dictionary<Color, Int32> {
            {Color.Main, 0x0000ff},
            {Color.Tint, 0xff0000},
            {Color.Shadow, 0xfefefe},
            {Color.Background, 0xffffff}};
        }
    }
}