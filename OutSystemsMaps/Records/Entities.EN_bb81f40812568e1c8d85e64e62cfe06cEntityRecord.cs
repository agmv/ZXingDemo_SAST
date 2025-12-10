using System.Diagnostics;
namespace ssOutSystemsMaps {

public sealed partial class ENShapeEventEntity {
private static readonly ActivitySource activitySource = new(typeof(ENShapeEventEntity).Namespace);
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
} // ENShapeEventEntity
partial class ENShapeEventEntity : InMemoryStaticEntityRuntime<EN_bb81f40812568e1c8d85e64e62cfe06cEntityRecord, string> {
    

    private static ENShapeEventEntity instance = new();
    public static ENShapeEventEntity GetInstance() => instance;

    public static EN_bb81f40812568e1c8d85e64e62cfe06cEntityRecord GetRecordById(string id) {
return instance.GetRecord(id);
}

    public static EN_bb81f40812568e1c8d85e64e62cfe06cEntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, string> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("gyvuPHbkvEyG6M73qa4b5A"), "OnClick" },

    };

    protected override Dictionary<string, EN_bb81f40812568e1c8d85e64e62cfe06cEntityRecord> RecordIdToRecordMap { get; } = new() {
        {"OnClick", new() {
ssId = "OnClick",
}},

    };

    protected override Dictionary<string, Dictionary<string, EN_bb81f40812568e1c8d85e64e62cfe06cEntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

