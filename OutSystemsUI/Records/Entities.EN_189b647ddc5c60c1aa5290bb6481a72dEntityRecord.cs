using System.Diagnostics;
namespace ssOutSystemsUI {

public sealed partial class ENMessageStatusEntity {
private static readonly ActivitySource activitySource = new(typeof(ENMessageStatusEntity).Namespace);
private static readonly System.Collections.Generic.Dictionary<string,string> entityAttributes = new() {{"type", "type"}, {"order", "order"}};
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
} // ENMessageStatusEntity
partial class ENMessageStatusEntity : InMemoryStaticEntityRuntime<EN_189b647ddc5c60c1aa5290bb6481a72dEntityRecord, string> {
    

    private static ENMessageStatusEntity instance = new();
    public static ENMessageStatusEntity GetInstance() => instance;

    public static EN_189b647ddc5c60c1aa5290bb6481a72dEntityRecord GetRecordById(string id) {
return instance.GetRecord(id);
}

    public static EN_189b647ddc5c60c1aa5290bb6481a72dEntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, string> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("7WYiL3oW20WsEsoePPoP0g"), "Hidden" },
{ ObjectKey.Parse("k__0NE6OM0m6roufEi6zzA"), "Read" },
{ ObjectKey.Parse("ibrxoYS9Q0mpTKhOpKFCvw"), "Sent" },
{ ObjectKey.Parse("0IgLyX2PSkiNF7DRuXlalA"), "Received" },

    };

    protected override Dictionary<string, EN_189b647ddc5c60c1aa5290bb6481a72dEntityRecord> RecordIdToRecordMap { get; } = new() {
        {"Hidden", new() {
ssType = "Hidden",
ssOrder = 4,
}},
{"Read", new() {
ssType = "Read",
ssOrder = 3,
}},
{"Sent", new() {
ssType = "Sent",
ssOrder = 1,
}},
{"Received", new() {
ssType = "Received",
ssOrder = 2,
}},

    };

    protected override Dictionary<string, Dictionary<string, EN_189b647ddc5c60c1aa5290bb6481a72dEntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

