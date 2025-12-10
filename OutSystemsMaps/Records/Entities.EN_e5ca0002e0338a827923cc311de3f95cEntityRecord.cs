using System.Diagnostics;
namespace ssOutSystemsMaps {

public sealed partial class ENMapEventEntity {
private static readonly ActivitySource activitySource = new(typeof(ENMapEventEntity).Namespace);
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
} // ENMapEventEntity
partial class ENMapEventEntity : InMemoryStaticEntityRuntime<EN_e5ca0002e0338a827923cc311de3f95cEntityRecord, string> {
    

    private static ENMapEventEntity instance = new();
    public static ENMapEventEntity GetInstance() => instance;

    public static EN_e5ca0002e0338a827923cc311de3f95cEntityRecord GetRecordById(string id) {
return instance.GetRecord(id);
}

    public static EN_e5ca0002e0338a827923cc311de3f95cEntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, string> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("QzXDLd1EVkKQ+YnW1_6Q8w"), "Initialized" },
{ ObjectKey.Parse("i_2AO7NIFkKaiJP8Pun+CQ"), "OnError" },

    };

    protected override Dictionary<string, EN_e5ca0002e0338a827923cc311de3f95cEntityRecord> RecordIdToRecordMap { get; } = new() {
        {"Initialized", new() {
ssId = "Initialized",
}},
{"OnError", new() {
ssId = "OnError",
}},

    };

    protected override Dictionary<string, Dictionary<string, EN_e5ca0002e0338a827923cc311de3f95cEntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

