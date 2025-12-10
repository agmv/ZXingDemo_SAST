using System.Diagnostics;
namespace ssOutSystemsUI {

public sealed partial class ENBooleanTypesEntity {
private static readonly ActivitySource activitySource = new(typeof(ENBooleanTypesEntity).Namespace);
private static readonly System.Collections.Generic.Dictionary<string,string> entityAttributes = new() {{"label", "label"}, {"order", "order"}};
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
} // ENBooleanTypesEntity
partial class ENBooleanTypesEntity : InMemoryStaticEntityRuntime<EN_1e2af88601c0491260411e1369eb104cEntityRecord, string> {
    

    private static ENBooleanTypesEntity instance = new();
    public static ENBooleanTypesEntity GetInstance() => instance;

    public static EN_1e2af88601c0491260411e1369eb104cEntityRecord GetRecordById(string id) {
return instance.GetRecord(id);
}

    public static EN_1e2af88601c0491260411e1369eb104cEntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, string> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("iHfqWMfKUE+O8bqOFmG2Mg"), "true" },
{ ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"), "unset" },
{ ObjectKey.Parse("kvBa3wQmCUSufbhtK875+w"), "false" },

    };

    protected override Dictionary<string, EN_1e2af88601c0491260411e1369eb104cEntityRecord> RecordIdToRecordMap { get; } = new() {
        {"true", new() {
ssLabel = "true",
ssOrder = 2,
}},
{"unset", new() {
ssLabel = "unset",
ssOrder = 1,
}},
{"false", new() {
ssLabel = "false",
ssOrder = 3,
}},

    };

    protected override Dictionary<string, Dictionary<string, EN_1e2af88601c0491260411e1369eb104cEntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

