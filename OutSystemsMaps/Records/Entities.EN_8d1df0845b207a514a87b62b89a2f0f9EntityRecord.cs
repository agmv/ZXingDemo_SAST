using System.Diagnostics;
namespace ssOutSystemsMaps {

public sealed partial class ENDrawingToolTypeEntity {
private static readonly ActivitySource activitySource = new(typeof(ENDrawingToolTypeEntity).Namespace);
private static readonly System.Collections.Generic.Dictionary<string,string> entityAttributes = new() {{"id", "id"}};
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
} // ENDrawingToolTypeEntity
partial class ENDrawingToolTypeEntity : InMemoryStaticEntityRuntime<EN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord, string> {
    

    private static ENDrawingToolTypeEntity instance = new();
    public static ENDrawingToolTypeEntity GetInstance() => instance;

    public static EN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord GetRecordById(string id) {
return instance.GetRecord(id);
}

    public static EN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, string> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("dz2jAezdB0ezgogLgKVJHA"), "polyline" },
{ ObjectKey.Parse("F2w9Gy97G02FAkzaWeU1XQ"), "rectangle" },
{ ObjectKey.Parse("58w2J9I0zUy2EEVWv8GS_g"), "marker" },
{ ObjectKey.Parse("M1XLLOEYKE+EITL7e4IKsQ"), "circle" },
{ ObjectKey.Parse("NTJxlWg770Kfy2KtBHSyFQ"), "polygon" },

    };

    protected override Dictionary<string, EN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord> RecordIdToRecordMap { get; } = new() {
        {"polyline", new() {
ssId = "polyline",
}},
{"rectangle", new() {
ssId = "rectangle",
}},
{"marker", new() {
ssId = "marker",
}},
{"circle", new() {
ssId = "circle",
}},
{"polygon", new() {
ssId = "polygon",
}},

    };

    protected override Dictionary<string, Dictionary<string, EN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

