using System.Diagnostics;
namespace ssOutSystemsUI {

public sealed partial class ENAlertEntity {
private static readonly ActivitySource activitySource = new(typeof(ENAlertEntity).Namespace);
private static readonly System.Collections.Generic.Dictionary<string,string> entityAttributes = new() {{"alert", "alert"}};
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
} // ENAlertEntity
partial class ENAlertEntity : InMemoryStaticEntityRuntime<EN_adf11bcbc411b5a0f498d25dd0ea882fEntityRecord, string> {
    

    private static ENAlertEntity instance = new();
    public static ENAlertEntity GetInstance() => instance;

    public static EN_adf11bcbc411b5a0f498d25dd0ea882fEntityRecord GetRecordById(string id) {
return instance.GetRecord(id);
}

    public static EN_adf11bcbc411b5a0f498d25dd0ea882fEntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, string> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("gWOsSpwXf0eg0oqnwOLs5Q"), "alert-success" },
{ ObjectKey.Parse("AWDAhTpNCEqxj0+evcYNMw"), "alert-error" },
{ ObjectKey.Parse("B7nG51YPHkiyZ+tpvZLtJg"), "alert-info" },
{ ObjectKey.Parse("IwVx7eWdtkezrHNvtISMBA"), "alert-warning" },

    };

    protected override Dictionary<string, EN_adf11bcbc411b5a0f498d25dd0ea882fEntityRecord> RecordIdToRecordMap { get; } = new() {
        {"alert-success", new() {
ssAlert = "alert-success",
}},
{"alert-error", new() {
ssAlert = "alert-error",
}},
{"alert-info", new() {
ssAlert = "alert-info",
}},
{"alert-warning", new() {
ssAlert = "alert-warning",
}},

    };

    protected override Dictionary<string, Dictionary<string, EN_adf11bcbc411b5a0f498d25dd0ea882fEntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

