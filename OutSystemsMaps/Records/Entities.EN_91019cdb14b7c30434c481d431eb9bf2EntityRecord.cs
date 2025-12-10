using System.Diagnostics;
namespace ssOutSystemsMaps {

public sealed partial class ENDrawingToolsEventEntity {
private static readonly ActivitySource activitySource = new(typeof(ENDrawingToolsEventEntity).Namespace);
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
} // ENDrawingToolsEventEntity
partial class ENDrawingToolsEventEntity : InMemoryStaticEntityRuntime<EN_91019cdb14b7c30434c481d431eb9bf2EntityRecord, string> {
    

    private static ENDrawingToolsEventEntity instance = new();
    public static ENDrawingToolsEventEntity GetInstance() => instance;

    public static EN_91019cdb14b7c30434c481d431eb9bf2EntityRecord GetRecordById(string id) {
return instance.GetRecord(id);
}

    public static EN_91019cdb14b7c30434c481d431eb9bf2EntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, string> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("2q9h+q0ChkOtovZBxL+l4g"), "Initialized" },

    };

    protected override Dictionary<string, EN_91019cdb14b7c30434c481d431eb9bf2EntityRecord> RecordIdToRecordMap { get; } = new() {
        {"Initialized", new() {
ssId = "Initialized",
}},

    };

    protected override Dictionary<string, Dictionary<string, EN_91019cdb14b7c30434c481d431eb9bf2EntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

