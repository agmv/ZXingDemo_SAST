using System.Diagnostics;
namespace ssOutSystemsUI {

public sealed partial class ENCarouselDirectionEntity {
private static readonly ActivitySource activitySource = new(typeof(ENCarouselDirectionEntity).Namespace);
private static readonly System.Collections.Generic.Dictionary<string,string> entityAttributes = new() {{"type", "type"}};
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
} // ENCarouselDirectionEntity
partial class ENCarouselDirectionEntity : InMemoryStaticEntityRuntime<EN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord, string> {
    

    private static ENCarouselDirectionEntity instance = new();
    public static ENCarouselDirectionEntity GetInstance() => instance;

    public static EN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord GetRecordById(string id) {
return instance.GetRecord(id);
}

    public static EN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, string> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("zXVVS5h1CkKX21CI1NhqTQ"), "RightToLeft" },
{ ObjectKey.Parse("IGRboMVDYEaVJpXiBSpFqA"), "LeftToRight" },

    };

    protected override Dictionary<string, EN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord> RecordIdToRecordMap { get; } = new() {
        {"RightToLeft", new() {
ssType = "RightToLeft",
}},
{"LeftToRight", new() {
ssType = "LeftToRight",
}},

    };

    protected override Dictionary<string, Dictionary<string, EN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

