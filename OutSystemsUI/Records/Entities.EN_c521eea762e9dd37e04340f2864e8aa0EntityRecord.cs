using System.Diagnostics;
namespace ssOutSystemsUI {

public sealed partial class ENDatePickerCalendarTypeEntity {
private static readonly ActivitySource activitySource = new(typeof(ENDatePickerCalendarTypeEntity).Namespace);
private static readonly System.Collections.Generic.Dictionary<string,string> entityAttributes = new() {{"mode", "mode"}};
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
} // ENDatePickerCalendarTypeEntity
partial class ENDatePickerCalendarTypeEntity : InMemoryStaticEntityRuntime<EN_c521eea762e9dd37e04340f2864e8aa0EntityRecord, string> {
    

    private static ENDatePickerCalendarTypeEntity instance = new();
    public static ENDatePickerCalendarTypeEntity GetInstance() => instance;

    public static EN_c521eea762e9dd37e04340f2864e8aa0EntityRecord GetRecordById(string id) {
return instance.GetRecord(id);
}

    public static EN_c521eea762e9dd37e04340f2864e8aa0EntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, string> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("oOj8FSni50O6R_Eg7WbAAQ"), "single" },
{ ObjectKey.Parse("TQK0xnck70yMNb5rHPKFiQ"), "range" },

    };

    protected override Dictionary<string, EN_c521eea762e9dd37e04340f2864e8aa0EntityRecord> RecordIdToRecordMap { get; } = new() {
        {"single", new() {
ssMode = "single",
}},
{"range", new() {
ssMode = "range",
}},

    };

    protected override Dictionary<string, Dictionary<string, EN_c521eea762e9dd37e04340f2864e8aa0EntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

