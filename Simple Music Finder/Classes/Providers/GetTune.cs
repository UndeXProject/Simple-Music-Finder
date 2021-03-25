using System;
using System.Collections.Generic;
using System.Text;

namespace Simple_Music_Finder.Classes.Providers
{
    class GetTune : Provider
    {
        public override string Name { get; internal set; }
        public override Dictionary<string, string> ProviderData { get; internal set; }

        /// <summary>
        /// Поиск по текстовому запросу
        /// </summary>
        /// <param name="Text">Текст для поиска</param>
        /// <returns></returns>
        public override string FindByText(string Text)
        {
            throw new NotImplementedException();
        }

        public override void Init()
        {
            Name = "GetTune";
            ProviderData = new Dictionary<string, string>();
            ProviderData.Add("author", "Und3X");
            ProviderData.Add("version", "1.0.0");
            ProviderData.Add("url", "https://und3x.ru/");
            Add(this);
        }
    }
}
