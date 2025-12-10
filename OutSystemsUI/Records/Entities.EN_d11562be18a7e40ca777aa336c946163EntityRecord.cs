using System.Diagnostics;
namespace ssOutSystemsUI {

public sealed partial class ENShapeEntity {
private static readonly ActivitySource activitySource = new(typeof(ENShapeEntity).Namespace);
private static readonly System.Collections.Generic.Dictionary<string,string> entityAttributes = new() {{"shape", "shape"}, {"order", "order"}};
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
} // ENShapeEntity
partial class ENShapeEntity : InMemoryStaticEntityRuntime<EN_d11562be18a7e40ca777aa336c946163EntityRecord, string> {
    

    private static ENShapeEntity instance = new();
    public static ENShapeEntity GetInstance() => instance;

    public static EN_d11562be18a7e40ca777aa336c946163EntityRecord GetRecordById(string id) {
return instance.GetRecord(id);
}

    public static EN_d11562be18a7e40ca777aa336c946163EntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, string> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("9bHelFNhOESSrc7eo8H28A"), "none" },
{ ObjectKey.Parse("OTUJ0X3XnUONUwPS4AU6Ug"), "soft" },
{ ObjectKey.Parse("aSIM8gonskO6Kb2Pv_JRnw"), "rounded" },

    };

    protected override Dictionary<string, EN_d11562be18a7e40ca777aa336c946163EntityRecord> RecordIdToRecordMap { get; } = new() {
        {"none", new() {
ssShape = "none",
ssOrder = 4,
}},
{"soft", new() {
ssShape = "soft",
ssOrder = 3,
}},
{"rounded", new() {
ssShape = "rounded",
ssOrder = 2,
}},

    };

    protected override Dictionary<string, Dictionary<string, EN_d11562be18a7e40ca777aa336c946163EntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

