using System.Diagnostics;
namespace ssOutSystemsUI {

public sealed partial class ENScrollbarStyleEntity {
private static readonly ActivitySource activitySource = new(typeof(ENScrollbarStyleEntity).Namespace);
private static readonly System.Collections.Generic.Dictionary<string,string> entityAttributes = new() {{"style", "style"}};
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
} // ENScrollbarStyleEntity
partial class ENScrollbarStyleEntity : InMemoryStaticEntityRuntime<EN_1967a79b0bc6b1bdc38ff87eefe0b127EntityRecord, string> {
    

    private static ENScrollbarStyleEntity instance = new();
    public static ENScrollbarStyleEntity GetInstance() => instance;

    public static EN_1967a79b0bc6b1bdc38ff87eefe0b127EntityRecord GetRecordById(string id) {
return instance.GetRecord(id);
}

    public static EN_1967a79b0bc6b1bdc38ff87eefe0b127EntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, string> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("92ZtV2VbSE6mlOrezaT_Og"), "none" },
{ ObjectKey.Parse("bcT40C92pUeVcpRawdu+fw"), "default" },
{ ObjectKey.Parse("QxwZ6e9jaUS+rCsTNaq5Mg"), "compact" },

    };

    protected override Dictionary<string, EN_1967a79b0bc6b1bdc38ff87eefe0b127EntityRecord> RecordIdToRecordMap { get; } = new() {
        {"none", new() {
ssStyle = "none",
}},
{"default", new() {
ssStyle = "default",
}},
{"compact", new() {
ssStyle = "compact",
}},

    };

    protected override Dictionary<string, Dictionary<string, EN_1967a79b0bc6b1bdc38ff87eefe0b127EntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

