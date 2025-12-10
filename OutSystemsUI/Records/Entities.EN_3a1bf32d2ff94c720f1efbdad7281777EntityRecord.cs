using System.Diagnostics;
namespace ssOutSystemsUI {

public sealed partial class ENDatePickerProviderEntity {
private static readonly ActivitySource activitySource = new(typeof(ENDatePickerProviderEntity).Namespace);
private static readonly System.Collections.Generic.Dictionary<string,string> entityAttributes = new() {{"provider", "provider"}};
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
} // ENDatePickerProviderEntity
partial class ENDatePickerProviderEntity : InMemoryStaticEntityRuntime<EN_3a1bf32d2ff94c720f1efbdad7281777EntityRecord, string> {
    

    private static ENDatePickerProviderEntity instance = new();
    public static ENDatePickerProviderEntity GetInstance() => instance;

    public static EN_3a1bf32d2ff94c720f1efbdad7281777EntityRecord GetRecordById(string id) {
return instance.GetRecord(id);
}

    public static EN_3a1bf32d2ff94c720f1efbdad7281777EntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, string> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("xYeR7X5+XkCv_Hn0wEz1QA"), "flatpickr" },

    };

    protected override Dictionary<string, EN_3a1bf32d2ff94c720f1efbdad7281777EntityRecord> RecordIdToRecordMap { get; } = new() {
        {"flatpickr", new() {
ssProvider = "flatpickr",
}},

    };

    protected override Dictionary<string, Dictionary<string, EN_3a1bf32d2ff94c720f1efbdad7281777EntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

