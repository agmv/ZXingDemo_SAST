using System.Diagnostics;
namespace ssOutSystemsUI {

public sealed partial class ENAutoplayEntity {
private static readonly ActivitySource activitySource = new(typeof(ENAutoplayEntity).Namespace);
private static readonly System.Collections.Generic.Dictionary<string,string> entityAttributes = new() {{"autoplay", "autoplay"}};
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
} // ENAutoplayEntity
partial class ENAutoplayEntity : InMemoryStaticEntityRuntime<EN_c3a2475ae6370a2f746040280495b4a2EntityRecord, string> {
    

    private static ENAutoplayEntity instance = new();
    public static ENAutoplayEntity GetInstance() => instance;

    public static EN_c3a2475ae6370a2f746040280495b4a2EntityRecord GetRecordById(string id) {
return instance.GetRecord(id);
}

    public static EN_c3a2475ae6370a2f746040280495b4a2EntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, string> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("Xcr8H9AXLkmenrit3ef9gA"), "disabled" },
{ ObjectKey.Parse("AfZnQTFXLUWWUxvn8lGZ8Q"), "slow" },
{ ObjectKey.Parse("BOy5QSMgh0+5UwwBcT0Zkg"), "fast" },
{ ObjectKey.Parse("RjAD47p3zUmSil2DEQXzSQ"), "normal" },

    };

    protected override Dictionary<string, EN_c3a2475ae6370a2f746040280495b4a2EntityRecord> RecordIdToRecordMap { get; } = new() {
        {"disabled", new() {
ssAutoplay = "disabled",
}},
{"slow", new() {
ssAutoplay = "slow",
}},
{"fast", new() {
ssAutoplay = "fast",
}},
{"normal", new() {
ssAutoplay = "normal",
}},

    };

    protected override Dictionary<string, Dictionary<string, EN_c3a2475ae6370a2f746040280495b4a2EntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

