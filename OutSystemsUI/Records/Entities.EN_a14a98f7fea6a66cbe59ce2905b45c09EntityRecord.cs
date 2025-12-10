using System.Diagnostics;
namespace ssOutSystemsUI {

public sealed partial class ENSizeEntity {
private static readonly ActivitySource activitySource = new(typeof(ENSizeEntity).Namespace);
private static readonly System.Collections.Generic.Dictionary<string,string> entityAttributes = new() {{"size", "size"}};
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
} // ENSizeEntity
partial class ENSizeEntity : InMemoryStaticEntityRuntime<EN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord, string> {
    

    private static ENSizeEntity instance = new();
    public static ENSizeEntity GetInstance() => instance;

    public static EN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord GetRecordById(string id) {
return instance.GetRecord(id);
}

    public static EN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, string> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("LLpMD9Iy70uw6A7Nfq2_+g"), "medium" },
{ ObjectKey.Parse("isszkRfKOU6p_UoHzxI8gg"), "small" },

    };

    protected override Dictionary<string, EN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord> RecordIdToRecordMap { get; } = new() {
        {"medium", new() {
ssSize = "medium",
}},
{"small", new() {
ssSize = "small",
}},

    };

    protected override Dictionary<string, Dictionary<string, EN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

