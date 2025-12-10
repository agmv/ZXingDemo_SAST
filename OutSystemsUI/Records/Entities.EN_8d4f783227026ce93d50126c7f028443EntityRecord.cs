using System.Diagnostics;
namespace ssOutSystemsUI {

public sealed partial class ENOrientationEntity {
private static readonly ActivitySource activitySource = new(typeof(ENOrientationEntity).Namespace);
private static readonly System.Collections.Generic.Dictionary<string,string> entityAttributes = new() {{"orientation", "orientation"}};
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
} // ENOrientationEntity
partial class ENOrientationEntity : InMemoryStaticEntityRuntime<EN_8d4f783227026ce93d50126c7f028443EntityRecord, string> {
    

    private static ENOrientationEntity instance = new();
    public static ENOrientationEntity GetInstance() => instance;

    public static EN_8d4f783227026ce93d50126c7f028443EntityRecord GetRecordById(string id) {
return instance.GetRecord(id);
}

    public static EN_8d4f783227026ce93d50126c7f028443EntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, string> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("FlS0fEo8eEGcW4fsz2_66A"), "horizontal" },
{ ObjectKey.Parse("wXe42qLkqUOyETu5Fn2s6Q"), "vertical" },

    };

    protected override Dictionary<string, EN_8d4f783227026ce93d50126c7f028443EntityRecord> RecordIdToRecordMap { get; } = new() {
        {"horizontal", new() {
ssOrientation = "horizontal",
}},
{"vertical", new() {
ssOrientation = "vertical",
}},

    };

    protected override Dictionary<string, Dictionary<string, EN_8d4f783227026ce93d50126c7f028443EntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

