using System.Diagnostics;
namespace ssOutSystemsMaps {

public sealed partial class ENMapTypeEntity {
private static readonly ActivitySource activitySource = new(typeof(ENMapTypeEntity).Namespace);
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
} // ENMapTypeEntity
partial class ENMapTypeEntity : InMemoryStaticEntityRuntime<EN_0df198ce2d64e9aa6113403a9d3f7309EntityRecord, string> {
    

    private static ENMapTypeEntity instance = new();
    public static ENMapTypeEntity GetInstance() => instance;

    public static EN_0df198ce2d64e9aa6113403a9d3f7309EntityRecord GetRecordById(string id) {
return instance.GetRecord(id);
}

    public static EN_0df198ce2d64e9aa6113403a9d3f7309EntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, string> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("BtE6nQ8MK0G4IOCCiB46GQ"), "StaticMap" },
{ ObjectKey.Parse("d+q1tU4UGUSQiKhz8Sfd9Q"), "Map" },

    };

    protected override Dictionary<string, EN_0df198ce2d64e9aa6113403a9d3f7309EntityRecord> RecordIdToRecordMap { get; } = new() {
        {"StaticMap", new() {
ssId = "StaticMap",
}},
{"Map", new() {
ssId = "Map",
}},

    };

    protected override Dictionary<string, Dictionary<string, EN_0df198ce2d64e9aa6113403a9d3f7309EntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

