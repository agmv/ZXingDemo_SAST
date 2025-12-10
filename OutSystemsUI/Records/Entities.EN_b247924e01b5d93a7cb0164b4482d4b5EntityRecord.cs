using System.Diagnostics;
namespace ssOutSystemsUI {

public sealed partial class ENRangeSliderProviderEntity {
private static readonly ActivitySource activitySource = new(typeof(ENRangeSliderProviderEntity).Namespace);
private static readonly System.Collections.Generic.Dictionary<string,string> entityAttributes = new() {{"provider", "provider"}};
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
} // ENRangeSliderProviderEntity
partial class ENRangeSliderProviderEntity : InMemoryStaticEntityRuntime<EN_b247924e01b5d93a7cb0164b4482d4b5EntityRecord, string> {
    

    private static ENRangeSliderProviderEntity instance = new();
    public static ENRangeSliderProviderEntity GetInstance() => instance;

    public static EN_b247924e01b5d93a7cb0164b4482d4b5EntityRecord GetRecordById(string id) {
return instance.GetRecord(id);
}

    public static EN_b247924e01b5d93a7cb0164b4482d4b5EntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, string> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("+c2lWzuomkOTFRyFfrn8CA"), "noUiSlider" },

    };

    protected override Dictionary<string, EN_b247924e01b5d93a7cb0164b4482d4b5EntityRecord> RecordIdToRecordMap { get; } = new() {
        {"noUiSlider", new() {
ssProvider = "noUiSlider",
}},

    };

    protected override Dictionary<string, Dictionary<string, EN_b247924e01b5d93a7cb0164b4482d4b5EntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

