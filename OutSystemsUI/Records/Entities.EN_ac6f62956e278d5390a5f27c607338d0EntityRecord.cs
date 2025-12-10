using System.Diagnostics;
namespace ssOutSystemsUI {

public sealed partial class ENDatePickerLanguageEntity {
private static readonly ActivitySource activitySource = new(typeof(ENDatePickerLanguageEntity).Namespace);
private static readonly System.Collections.Generic.Dictionary<string,string> entityAttributes = new() {{"alpha2code", "alpha2code"}, {"languagename", "languagename"}};
public static System.Collections.Generic.Dictionary<string,string> AttributesToDatabaseNamesMap() {
return entityAttributes;
}
public static string AttributeDatabaseName(string attributeName) {
string databaseName;
entityAttributes.TryGetValue(attributeName, out databaseName);
return databaseName;
}
public static string LocalViewName(long? tenant, string locale) {
return ViewName(null,locale);
}
public static string ViewName(long? tenant, string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, "");
}
} // ENDatePickerLanguageEntity
partial class ENDatePickerLanguageEntity : InMemoryStaticEntityRuntime<EN_ac6f62956e278d5390a5f27c607338d0EntityRecord, string> {
    

    private static ENDatePickerLanguageEntity instance = new();
    public static ENDatePickerLanguageEntity GetInstance() => instance;

    public static EN_ac6f62956e278d5390a5f27c607338d0EntityRecord GetRecordById(string id) {
return instance.GetRecord(id);
}

    public static EN_ac6f62956e278d5390a5f27c607338d0EntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, string> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("O69BAF5QuEiNebCgCu603g"), "ja" },
{ ObjectKey.Parse("VIeWBTikyUCGDQd1x2GMgA"), "nl" },
{ ObjectKey.Parse("x3ltDHNnnk2pFK1yRlBaqA"), "cs" },
{ ObjectKey.Parse("YpllDvuwhkSfM5l89aAPMw"), "id" },
{ ObjectKey.Parse("nqj7EOr52kahFISaSJHE3Q"), "pa" },
{ ObjectKey.Parse("mMSpEeNldEC9TBYmYoip5A"), "lv" },
{ ObjectKey.Parse("0yxtGJ17SkazHrRUi5qAwA"), "zh" },
{ ObjectKey.Parse("WVyMGRDWUk607Z+zjCGztw"), "pl" },
{ ObjectKey.Parse("odidHiSrSUirdLZbKil0pQ"), "et" },
{ ObjectKey.Parse("fBH6Hrnx50qUrYFKdS5IZA"), "ca" },
{ ObjectKey.Parse("8ygmJLYiE0eBGHkhq9AK0g"), "ms" },
{ ObjectKey.Parse("rUluKAZUQk+pxLzErcZNFw"), "sk" },
{ ObjectKey.Parse("HnzzLTFUSUifC0BbQ_7RiA"), "si" },
{ ObjectKey.Parse("YploNMwM3Ea8Q+a8dxZ4TA"), "da" },
{ ObjectKey.Parse("oA9DN4KIaU+v3kHCfeA6Xw"), "en" },
{ ObjectKey.Parse("f9VUOL34JECGZGNT1VLY8g"), "hu" },
{ ObjectKey.Parse("dUqaRYX74ECWsvCN8oTaQQ"), "nn" },
{ ObjectKey.Parse("vTEBU4IbW0mpxXENi8SmQg"), "nb" },
{ ObjectKey.Parse("j+sMU_Efp0Su1eCvRblByw"), "ar" },
{ ObjectKey.Parse("phjrWP4Ri0q7ln7RBXsW9Q"), "fo" },
{ ObjectKey.Parse("sxs0XscPWU+kJgDc1LL6vw"), "km" },
{ ObjectKey.Parse("pjjgYnKNhESyeKiDsASz8g"), "ro" },
{ ObjectKey.Parse("4rC3a9i6WE+AG0yg6eaZpw"), "zh_tw" },
{ ObjectKey.Parse("YtKfb_AyJkerPl17tpFokg"), "no" },
{ ObjectKey.Parse("n8Epe92CC06PW5AEyn0k_A"), "eo" },
{ ObjectKey.Parse("yEnvfaDxAEauVlPpRxY0og"), "hr" },
{ ObjectKey.Parse("vR9ggJDhvkmQ3WlkFx1Skg"), "sq" },
{ ObjectKey.Parse("wjulgtf4XUy7cFZRpHE4gA"), "ko" },
{ ObjectKey.Parse("nN6ohE1vd0CTkZjWZBS_Tg"), "th" },
{ ObjectKey.Parse("uQ0rh7TZ1EmyrgKBIsvUSA"), "mn" },
{ ObjectKey.Parse("ReYvjCXZ6kKYGUoaw6NA5A"), "es" },
{ ObjectKey.Parse("fUELk6pyOUujuTuYIb8dSw"), "sl" },
{ ObjectKey.Parse("mSwvmSKx9km8e3XSQty5uw"), "vi" },
{ ObjectKey.Parse("ey9wnQ02u0abbg4CCl9jhQ"), "bs" },
{ ObjectKey.Parse("3bz_ncQl4kSfatGbn3WK2A"), "fr" },
{ ObjectKey.Parse("hgYmn81R0kC_JqCRZbITug"), "tr" },
{ ObjectKey.Parse("scIArYDD90u19Bc7QFlL1Q"), "ru" },
{ ObjectKey.Parse("BHSVsgcAR0unmN0RSJTH4w"), "sr" },
{ ObjectKey.Parse("mJ1Rswxm7UOu6bt24y3K+w"), "lt" },
{ ObjectKey.Parse("+6XktO8QZk2EvZbd2507PA"), "pt" },
{ ObjectKey.Parse("kvMOthV3f0OkqbiaISjknA"), "he" },
{ ObjectKey.Parse("dS_6trkSc0mQJ7SGa+AWIQ"), "uz" },
{ ObjectKey.Parse("QMsZtx1iEEaxb_QsqtST1A"), "my" },
{ ObjectKey.Parse("znoHuiOUH0CI_B__jXhyoA"), "it" },
{ ObjectKey.Parse("CPCFu1Qh7kSRmZ4OGUl8Rw"), "ka" },
{ ObjectKey.Parse("rozivPnmiEmXqIsOF+pnAw"), "sv" },
{ ObjectKey.Parse("RaJovW4UyUWNwCZBnL5chQ"), "az" },
{ ObjectKey.Parse("k9nnwf4iKkWXVGpIrAPm1A"), "hi" },
{ ObjectKey.Parse("i6RWwxEEVEu3o91_pDaGRQ"), "bg" },
{ ObjectKey.Parse("WqyNwyh1R0aW5oh8DJ2oLg"), "fi" },
{ ObjectKey.Parse("EJq_0WA3x0GU6+JHB5k0Fg"), "fa" },
{ ObjectKey.Parse("zYf52IzQs0Cxm7YLUIzwPQ"), "hy" },
{ ObjectKey.Parse("pzgw2px3mUWwt5lVf2iDZQ"), "de" },
{ ObjectKey.Parse("JBYx30orCkG_VN5EeIbjow"), "be" },
{ ObjectKey.Parse("00m033DsjkWfN4no+cIH+w"), "cy" },
{ ObjectKey.Parse("SLbY9mffSUSTSr0D3_TFDA"), "uk" },
{ ObjectKey.Parse("w1fW+hNLY0GOIYTGC2gQ7g"), "bn" },
{ ObjectKey.Parse("1mC1_2fA5UK92A3oCKz_Cg"), "mk" },

    };

    protected override Dictionary<string, EN_ac6f62956e278d5390a5f27c607338d0EntityRecord> RecordIdToRecordMap { get; } = new() {
        {"ja", new() {
ssAlpha2Code = "ja",
ssLanguageName = "Japanese",
}},
{"nl", new() {
ssAlpha2Code = "nl",
ssLanguageName = "Dutch, Flemish",
}},
{"cs", new() {
ssAlpha2Code = "cs",
ssLanguageName = "Czech",
}},
{"id", new() {
ssAlpha2Code = "id",
ssLanguageName = "Indonesian",
}},
{"pa", new() {
ssAlpha2Code = "pa",
ssLanguageName = "Punjabi, Panjabi",
}},
{"lv", new() {
ssAlpha2Code = "lv",
ssLanguageName = "Latvian",
}},
{"zh", new() {
ssAlpha2Code = "zh",
ssLanguageName = "Chinese",
}},
{"pl", new() {
ssAlpha2Code = "pl",
ssLanguageName = "Polish",
}},
{"et", new() {
ssAlpha2Code = "et",
ssLanguageName = "Estonian",
}},
{"ca", new() {
ssAlpha2Code = "ca",
ssLanguageName = "Catalan, Valencian",
}},
{"ms", new() {
ssAlpha2Code = "ms",
ssLanguageName = "Malay",
}},
{"sk", new() {
ssAlpha2Code = "sk",
ssLanguageName = "Slovak",
}},
{"si", new() {
ssAlpha2Code = "si",
ssLanguageName = "Sinhala, Sinhalese",
}},
{"da", new() {
ssAlpha2Code = "da",
ssLanguageName = "Danish",
}},
{"en", new() {
ssAlpha2Code = "en",
ssLanguageName = "English",
}},
{"hu", new() {
ssAlpha2Code = "hu",
ssLanguageName = "Hungarian",
}},
{"nn", new() {
ssAlpha2Code = "nn",
ssLanguageName = "Norwegian Nynorsk",
}},
{"nb", new() {
ssAlpha2Code = "nb",
ssLanguageName = "Norwegian Bokmål",
}},
{"ar", new() {
ssAlpha2Code = "ar",
ssLanguageName = "Arabic",
}},
{"fo", new() {
ssAlpha2Code = "fo",
ssLanguageName = "Faroese",
}},
{"km", new() {
ssAlpha2Code = "km",
ssLanguageName = "Central Khmer",
}},
{"ro", new() {
ssAlpha2Code = "ro",
ssLanguageName = "Romanian, Moldavian, Moldovan",
}},
{"zh_tw", new() {
ssAlpha2Code = "zh_tw",
ssLanguageName = "ChineseTraditional",
}},
{"no", new() {
ssAlpha2Code = "no",
ssLanguageName = "Norwegian",
}},
{"eo", new() {
ssAlpha2Code = "eo",
ssLanguageName = "Esperanto",
}},
{"hr", new() {
ssAlpha2Code = "hr",
ssLanguageName = "Croatian",
}},
{"sq", new() {
ssAlpha2Code = "sq",
ssLanguageName = "Albanian",
}},
{"ko", new() {
ssAlpha2Code = "ko",
ssLanguageName = "Korean",
}},
{"th", new() {
ssAlpha2Code = "th",
ssLanguageName = "Thai",
}},
{"mn", new() {
ssAlpha2Code = "mn",
ssLanguageName = "Mongolian",
}},
{"es", new() {
ssAlpha2Code = "es",
ssLanguageName = "Spanish, Castilian",
}},
{"sl", new() {
ssAlpha2Code = "sl",
ssLanguageName = "Slovenian",
}},
{"vi", new() {
ssAlpha2Code = "vi",
ssLanguageName = "Vietnamese",
}},
{"bs", new() {
ssAlpha2Code = "bs",
ssLanguageName = "Bosnian",
}},
{"fr", new() {
ssAlpha2Code = "fr",
ssLanguageName = "French",
}},
{"tr", new() {
ssAlpha2Code = "tr",
ssLanguageName = "Turkish",
}},
{"ru", new() {
ssAlpha2Code = "ru",
ssLanguageName = "Russian",
}},
{"sr", new() {
ssAlpha2Code = "sr",
ssLanguageName = "Serbian",
}},
{"lt", new() {
ssAlpha2Code = "lt",
ssLanguageName = "Lithuanian",
}},
{"pt", new() {
ssAlpha2Code = "pt",
ssLanguageName = "Portuguese",
}},
{"he", new() {
ssAlpha2Code = "he",
ssLanguageName = "Hebrew",
}},
{"uz", new() {
ssAlpha2Code = "uz",
ssLanguageName = "Uzbek",
}},
{"my", new() {
ssAlpha2Code = "my",
ssLanguageName = "Burmese",
}},
{"it", new() {
ssAlpha2Code = "it",
ssLanguageName = "Italian",
}},
{"ka", new() {
ssAlpha2Code = "ka",
ssLanguageName = "Georgian",
}},
{"sv", new() {
ssAlpha2Code = "sv",
ssLanguageName = "Swedish",
}},
{"az", new() {
ssAlpha2Code = "az",
ssLanguageName = "Azerbaijani",
}},
{"hi", new() {
ssAlpha2Code = "hi",
ssLanguageName = "Hindi",
}},
{"bg", new() {
ssAlpha2Code = "bg",
ssLanguageName = "Bulgarian",
}},
{"fi", new() {
ssAlpha2Code = "fi",
ssLanguageName = "Finnish",
}},
{"fa", new() {
ssAlpha2Code = "fa",
ssLanguageName = "Persian",
}},
{"hy", new() {
ssAlpha2Code = "hy",
ssLanguageName = "Armenian",
}},
{"de", new() {
ssAlpha2Code = "de",
ssLanguageName = "German",
}},
{"be", new() {
ssAlpha2Code = "be",
ssLanguageName = "Belarusian",
}},
{"cy", new() {
ssAlpha2Code = "cy",
ssLanguageName = "Welsh",
}},
{"uk", new() {
ssAlpha2Code = "uk",
ssLanguageName = "Ukrainian",
}},
{"bn", new() {
ssAlpha2Code = "bn",
ssLanguageName = "Bengali",
}},
{"mk", new() {
ssAlpha2Code = "mk",
ssLanguageName = "Macedonian",
}},

    };

    protected override Dictionary<string, Dictionary<string, EN_ac6f62956e278d5390a5f27c607338d0EntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

