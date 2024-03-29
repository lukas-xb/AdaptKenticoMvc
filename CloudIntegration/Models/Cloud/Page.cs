// This code was generated by a cloud-generators-net tool 
// (see https://github.com/Kentico/cloud-generators-net).
// 
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated. 
// For further modifications of the class, create a separate file with the partial class.

using System;
using System.Collections.Generic;
using KenticoCloud.Delivery;

namespace CloudIntegration.Models.Cloud
{
    public partial class Page
    {
        public const string Codename = "page";
        public const string InstructionsCodename = "instructions";
        public const string DurationCodename = "duration";
        public const string LinkTextCodename = "link_text";
        public const string TitleCodename = "title";
        public const string DisplayTitleCodename = "display_title";
        public const string SectionsCodename = "sections";
        public const string ImageCodename = "image";
        public const string TextCodename = "text";

        public string Instructions { get; set; }
        public string Duration { get; set; }
        public string LinkText { get; set; }
        public string Title { get; set; }
        public string DisplayTitle { get; set; }
        public IEnumerable<Section> Sections { get; set; }
        public IEnumerable<Asset> Image { get; set; }
        public string Text { get; set; }
        public ContentItemSystemAttributes System { get; set; }
    }
}