﻿using System;
using System.Collections.Generic;

namespace NavTest.Services.Resources
{
    public class BaseResourcesService
    {
        private readonly Dictionary<ColorKey, Int32> colors = new Dictionary<ColorKey, Int32>();
        private readonly Dictionary<LocalizedKey, string> strings = new Dictionary<LocalizedKey, string>();
        private readonly Dictionary<ImageKey, IImage> images = new Dictionary<ImageKey, IImage>();

        protected BaseResourcesService()
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
            foreach (var item in this.defaultImages())
            {
                this.SetImage(item.Key, item.Value);
            }
        }

        public Int32 GetColor(ColorKey key)
        {
            return this.colors[key];
        }

        public string GetString(LocalizedKey key)
        {
            return this.strings[key];
        }

        public IImage GetImage(ImageKey key)
        {
            return this.images[key];
        }

        protected void SetColor(ColorKey key, Int32 value)
        {
            this.colors[key] = value;
        }

        protected void SetString(LocalizedKey key, string value)
        {
            this.strings[key] = value;
        }

        protected void SetImage(ImageKey imageKey, IImage image)
        {
            this.images[imageKey] = image;
        }

        protected virtual Dictionary<LocalizedKey, string> defaultStrings()
        {
            return new Dictionary<LocalizedKey, string> {
            {LocalizedKey.AI_Title, "New item"},
            {LocalizedKey.AI_ItemTitle, "Title"},
            {LocalizedKey.AI_ItemDescription, "Description"},

                {LocalizedKey.TB_ListsTitle, "Items"},
                {LocalizedKey.TB_AboutTitle, "About"}
            };
        }

        protected virtual Dictionary<ColorKey, Int32> defaultColors()
        {
            return new Dictionary<ColorKey, Int32> {
            {ColorKey.Main, 0x0000ff},
            {ColorKey.Tint, 0xff0000},
            {ColorKey.Shadow, 0xfefefe},
            {ColorKey.Background, 0xffffff}};
        }

        protected virtual Dictionary<ImageKey, IImage> defaultImages()
        {
            return new Dictionary<ImageKey, IImage>();
        }
    }
}