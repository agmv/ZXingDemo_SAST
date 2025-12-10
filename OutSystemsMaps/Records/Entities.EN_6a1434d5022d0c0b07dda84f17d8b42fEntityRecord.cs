using System.Diagnostics;
namespace ssOutSystemsMaps {

public sealed partial class ENProviderEntity {
private static readonly ActivitySource activitySource = new(typeof(ENProviderEntity).Namespace);
private static readonly System.Collections.Generic.Dictionary<string,string> entityAttributes = new() {{"id", "id"}};
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
} // ENProviderEntity
partial class ENProviderEntity : InMemoryStaticEntityRuntime<EN_6a1434d5022d0c0b07dda84f17d8b42fEntityRecord, string> {
    

    private static ENProviderEntity instance = new();
    public static ENProviderEntity GetInstance() => instance;

    public static EN_6a1434d5022d0c0b07dda84f17d8b42fEntityRecord GetRecordById(string id) {
return instance.GetRecord(id);
}

    public static EN_6a1434d5022d0c0b07dda84f17d8b42fEntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, string> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("TFL8EUjeA0iUr1DlF5OnpQ"), "Google" },
{ ObjectKey.Parse("T3BkLMW5NkKhcjlbN3fmZQ"), "Leaflet" },

    };

    protected override Dictionary<string, EN_6a1434d5022d0c0b07dda84f17d8b42fEntityRecord> RecordIdToRecordMap { get; } = new() {
        {"Google", new() {
ssId = "Google",
}},
{"Leaflet", new() {
ssId = "Leaflet",
}},

    };

    protected override Dictionary<string, Dictionary<string, EN_6a1434d5022d0c0b07dda84f17d8b42fEntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

