using System.Diagnostics;
namespace ssOutSystemsMaps {

public sealed partial class ENSearchPlacesEventEntity {
private static readonly ActivitySource activitySource = new(typeof(ENSearchPlacesEventEntity).Namespace);
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
} // ENSearchPlacesEventEntity
partial class ENSearchPlacesEventEntity : InMemoryStaticEntityRuntime<EN_8fe01ec881aca02efe3d0db98080a5e2EntityRecord, string> {
    

    private static ENSearchPlacesEventEntity instance = new();
    public static ENSearchPlacesEventEntity GetInstance() => instance;

    public static EN_8fe01ec881aca02efe3d0db98080a5e2EntityRecord GetRecordById(string id) {
return instance.GetRecord(id);
}

    public static EN_8fe01ec881aca02efe3d0db98080a5e2EntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, string> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("zzXmbTiBgkiQ9XPHqNc47g"), "OnError" },
{ ObjectKey.Parse("DlUNhWW3Hke5H4TIu2HWaA"), "OnPlaceSelect" },
{ ObjectKey.Parse("OIe5ni4CAE6rZPcVSvPLTA"), "Initialized" },

    };

    protected override Dictionary<string, EN_8fe01ec881aca02efe3d0db98080a5e2EntityRecord> RecordIdToRecordMap { get; } = new() {
        {"OnError", new() {
ssId = "OnError",
}},
{"OnPlaceSelect", new() {
ssId = "OnPlaceSelect",
}},
{"Initialized", new() {
ssId = "Initialized",
}},

    };

    protected override Dictionary<string, Dictionary<string, EN_8fe01ec881aca02efe3d0db98080a5e2EntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

