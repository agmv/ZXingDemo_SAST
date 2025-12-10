using System.Diagnostics;
namespace ssOutSystemsUI {

public sealed partial class ENProgressTypeEntity {
private static readonly ActivitySource activitySource = new(typeof(ENProgressTypeEntity).Namespace);
private static readonly System.Collections.Generic.Dictionary<string,string> entityAttributes = new() {{"type", "type"}};
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
} // ENProgressTypeEntity
partial class ENProgressTypeEntity : InMemoryStaticEntityRuntime<EN_e168de2e23691f28c2b57a8300aa4d06EntityRecord, string> {
    

    private static ENProgressTypeEntity instance = new();
    public static ENProgressTypeEntity GetInstance() => instance;

    public static EN_e168de2e23691f28c2b57a8300aa4d06EntityRecord GetRecordById(string id) {
return instance.GetRecord(id);
}

    public static EN_e168de2e23691f28c2b57a8300aa4d06EntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, string> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("nmz4Ki1r50aJUhPGSc1HSg"), "Bar" },
{ ObjectKey.Parse("heY7OGIpe0Wqz4lQ5gSTfA"), "Circle" },
{ ObjectKey.Parse("qNLsTxC_bkWvYql_v02cpA"), "CircleFraction" },

    };

    protected override Dictionary<string, EN_e168de2e23691f28c2b57a8300aa4d06EntityRecord> RecordIdToRecordMap { get; } = new() {
        {"Bar", new() {
ssType = "Bar",
}},
{"Circle", new() {
ssType = "Circle",
}},
{"CircleFraction", new() {
ssType = "CircleFraction",
}},

    };

    protected override Dictionary<string, Dictionary<string, EN_e168de2e23691f28c2b57a8300aa4d06EntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

