using System.Diagnostics;
namespace ssOutSystemsMaps {

public sealed partial class ENShapeTypeEntity {
private static readonly ActivitySource activitySource = new(typeof(ENShapeTypeEntity).Namespace);
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
} // ENShapeTypeEntity
partial class ENShapeTypeEntity : InMemoryStaticEntityRuntime<EN_e8edeefe38d8112c39e64ad89dac6f44EntityRecord, string> {
    

    private static ENShapeTypeEntity instance = new();
    public static ENShapeTypeEntity GetInstance() => instance;

    public static EN_e8edeefe38d8112c39e64ad89dac6f44EntityRecord GetRecordById(string id) {
return instance.GetRecord(id);
}

    public static EN_e8edeefe38d8112c39e64ad89dac6f44EntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, string> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("xIFmpAX1w0mFClxGYK6CjQ"), "Rectangle" },
{ ObjectKey.Parse("1754vqZxIEGg2Mjrgw0xIQ"), "Circle" },
{ ObjectKey.Parse("_NuL00OlDEuNRqkYRYyFZw"), "Polyline" },
{ ObjectKey.Parse("Lbzo71kKj0esjk1OwM7SjA"), "Polygon" },

    };

    protected override Dictionary<string, EN_e8edeefe38d8112c39e64ad89dac6f44EntityRecord> RecordIdToRecordMap { get; } = new() {
        {"Rectangle", new() {
ssId = "Rectangle",
}},
{"Circle", new() {
ssId = "Circle",
}},
{"Polyline", new() {
ssId = "Polyline",
}},
{"Polygon", new() {
ssId = "Polygon",
}},

    };

    protected override Dictionary<string, Dictionary<string, EN_e8edeefe38d8112c39e64ad89dac6f44EntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

