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
    public partial class CodeBlock
    {
        public const string Codename = "code_block";
        public const string AvailableLanguagesLanguageCodename = "available_languages__language";
        public const string CodeCodename = "code";

        public IEnumerable<MultipleChoiceOption> AvailableLanguagesLanguage { get; set; }
        public string Code { get; set; }
        public ContentItemSystemAttributes System { get; set; }
    }
}