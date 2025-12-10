using System.Diagnostics;
namespace ssOutSystemsMaps {

public sealed partial class ENMarkerTypeEntity {
private static readonly ActivitySource activitySource = new(typeof(ENMarkerTypeEntity).Namespace);
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
} // ENMarkerTypeEntity
partial class ENMarkerTypeEntity : InMemoryStaticEntityRuntime<EN_c3a74b883bf36717c1c549a2bbfbc0daEntityRecord, string> {
    

    private static ENMarkerTypeEntity instance = new();
    public static ENMarkerTypeEntity GetInstance() => instance;

    public static EN_c3a74b883bf36717c1c549a2bbfbc0daEntityRecord GetRecordById(string id) {
return instance.GetRecord(id);
}

    public static EN_c3a74b883bf36717c1c549a2bbfbc0daEntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, string> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("wgaYfO5o40KPBn4LqlvJqQ"), "MarkerPopup" },
{ ObjectKey.Parse("pBU_ySJgDEG1H6xcXgr44Q"), "Marker" },

    };

    protected override Dictionary<string, EN_c3a74b883bf36717c1c549a2bbfbc0daEntityRecord> RecordIdToRecordMap { get; } = new() {
        {"MarkerPopup", new() {
ssId = "MarkerPopup",
}},
{"Marker", new() {
ssId = "Marker",
}},

    };

    protected override Dictionary<string, Dictionary<string, EN_c3a74b883bf36717c1c549a2bbfbc0daEntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

