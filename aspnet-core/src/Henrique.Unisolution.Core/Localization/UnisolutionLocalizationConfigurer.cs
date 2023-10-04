using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace Henrique.Unisolution.Localization
{
    public static class UnisolutionLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(UnisolutionConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(UnisolutionLocalizationConfigurer).GetAssembly(),
                        "Henrique.Unisolution.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
