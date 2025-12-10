using System.Diagnostics;
namespace ssOutSystemsUI {

public sealed partial class ENMenuActionEntity {
private static readonly ActivitySource activitySource = new(typeof(ENMenuActionEntity).Namespace);
private static readonly System.Collections.Generic.Dictionary<string,string> entityAttributes = new() {{"menuaction", "menuaction"}};
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
} // ENMenuActionEntity
partial class ENMenuActionEntity : InMemoryStaticEntityRuntime<EN_f43f179caddf7f7b68b18272d67285d6EntityRecord, string> {
    

    private static ENMenuActionEntity instance = new();
    public static ENMenuActionEntity GetInstance() => instance;

    public static EN_f43f179caddf7f7b68b18272d67285d6EntityRecord GetRecordById(string id) {
return instance.GetRecord(id);
}

    public static EN_f43f179caddf7f7b68b18272d67285d6EntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, string> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("qRi6VWvN3UWZzpCB7hOH6g"), "Menu" },
{ ObjectKey.Parse("OnUMbPSGdk6XgW6CHIUMcg"), "Auto" },
{ ObjectKey.Parse("VtPJhmS+oUawJ4Q6uTtK6g"), "Hidden" },
{ ObjectKey.Parse("UDzb8jhM506ncKqUdssNaA"), "Back" },

    };

    protected override Dictionary<string, EN_f43f179caddf7f7b68b18272d67285d6EntityRecord> RecordIdToRecordMap { get; } = new() {
        {"Menu", new() {
ssMenuAction = "Menu",
}},
{"Auto", new() {
ssMenuAction = "Auto",
}},
{"Hidden", new() {
ssMenuAction = "Hidden",
}},
{"Back", new() {
ssMenuAction = "Back",
}},

    };

    protected override Dictionary<string, Dictionary<string, EN_f43f179caddf7f7b68b18272d67285d6EntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

