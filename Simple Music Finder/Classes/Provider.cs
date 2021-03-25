using System.Collections.Generic;

namespace Simple_Music_Finder.Classes
{
    abstract class Provider
    {
        /// <summary>
        /// Имя провайдера
        /// </summary>
        public abstract string Name { get; internal set; }
        /// <summary>
        /// Инициализация плагина
        /// </summary>
        public abstract void Init();
        /// <summary>
        /// Поиск по тексту
        /// </summary>
        /// <param name="Text">Текст для поиска</param>
        /// <returns></returns>
        public abstract string FindByText(string Text);
        /// <summary>
        /// Данные о плагине
        /// Обязательные ключи: author, version, url
        /// </summary>
        public abstract Dictionary<string, string> ProviderData { get; internal set; }
        private static List<Provider> ProvidersList = new List<Provider>();
        public static void Add(Provider provider)
        {
            ProvidersList.Add(provider);
        }
        public static void Load(Provider provider)
        {
            provider.Init();
        }
        public static List<Provider> GetList()
        {
            return ProvidersList;
        }
    }


}
