using System.Diagnostics;
namespace ssOutSystemsMaps {

public sealed partial class ENShapeEventTriggeredEntity {
private static readonly ActivitySource activitySource = new(typeof(ENShapeEventTriggeredEntity).Namespace);
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
} // ENShapeEventTriggeredEntity
partial class ENShapeEventTriggeredEntity : InMemoryStaticEntityRuntime<EN_d5303c5dfa3a0e0e964776dce02c36f0EntityRecord, string> {
    

    private static ENShapeEventTriggeredEntity instance = new();
    public static ENShapeEventTriggeredEntity GetInstance() => instance;

    public static EN_d5303c5dfa3a0e0e964776dce02c36f0EntityRecord GetRecordById(string id) {
return instance.GetRecord(id);
}

    public static EN_d5303c5dfa3a0e0e964776dce02c36f0EntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, string> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("c5JAr6tGrECESLr+w2SI3w"), "dragend" },
{ ObjectKey.Parse("eLn_w0cWP02Px_+AGPlphQ"), "shape_changed" },

    };

    protected override Dictionary<string, EN_d5303c5dfa3a0e0e964776dce02c36f0EntityRecord> RecordIdToRecordMap { get; } = new() {
        {"dragend", new() {
ssId = "dragend",
}},
{"shape_changed", new() {
ssId = "shape_changed",
}},

    };

    protected override Dictionary<string, Dictionary<string, EN_d5303c5dfa3a0e0e964776dce02c36f0EntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

