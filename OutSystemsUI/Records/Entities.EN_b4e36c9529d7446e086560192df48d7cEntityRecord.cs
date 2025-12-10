using System.Diagnostics;
namespace ssOutSystemsUI {

public sealed partial class ENDatePickerTimeFormatEntity {
private static readonly ActivitySource activitySource = new(typeof(ENDatePickerTimeFormatEntity).Namespace);
private static readonly System.Collections.Generic.Dictionary<string,string> entityAttributes = new() {{"timeformat", "timeformat"}};
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
} // ENDatePickerTimeFormatEntity
partial class ENDatePickerTimeFormatEntity : InMemoryStaticEntityRuntime<EN_b4e36c9529d7446e086560192df48d7cEntityRecord, string> {
    

    private static ENDatePickerTimeFormatEntity instance = new();
    public static ENDatePickerTimeFormatEntity GetInstance() => instance;

    public static EN_b4e36c9529d7446e086560192df48d7cEntityRecord GetRecordById(string id) {
return instance.GetRecord(id);
}

    public static EN_b4e36c9529d7446e086560192df48d7cEntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, string> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("FTwhSItTIkKj6tE25gilfQ"), "disabled" },
{ ObjectKey.Parse("JJkazu41JUqHroHyqXvfIA"), "24" },
{ ObjectKey.Parse("iaar4VLbuk2e77WYCz5PoA"), "12" },

    };

    protected override Dictionary<string, EN_b4e36c9529d7446e086560192df48d7cEntityRecord> RecordIdToRecordMap { get; } = new() {
        {"disabled", new() {
ssTimeformat = "disabled",
}},
{"24", new() {
ssTimeformat = "24",
}},
{"12", new() {
ssTimeformat = "12",
}},

    };

    protected override Dictionary<string, Dictionary<string, EN_b4e36c9529d7446e086560192df48d7cEntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

