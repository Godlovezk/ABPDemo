using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace MPACorePhoneBook.Localization
{
    public static class MPACorePhoneBookLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(MPACorePhoneBookConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(MPACorePhoneBookLocalizationConfigurer).GetAssembly(),
                        "MPACorePhoneBook.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
