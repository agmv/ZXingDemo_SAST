using System.Diagnostics;
namespace ssOutSystemsMaps {

public sealed partial class ENLogTypeEntity {
private static readonly ActivitySource activitySource = new(typeof(ENLogTypeEntity).Namespace);
private static readonly System.Collections.Generic.Dictionary<string,string> entityAttributes = new() {{"label", "label"}, {"order", "order"}};
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
} // ENLogTypeEntity
partial class ENLogTypeEntity : InMemoryStaticEntityRuntime<EN_120b6e3e471666b0ae15ac3a8f34340fEntityRecord, string> {
    

    private static ENLogTypeEntity instance = new();
    public static ENLogTypeEntity GetInstance() => instance;

    public static EN_120b6e3e471666b0ae15ac3a8f34340fEntityRecord GetRecordById(string id) {
return instance.GetRecord(id);
}

    public static EN_120b6e3e471666b0ae15ac3a8f34340fEntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, string> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("uwa6BSzp9kiA5Fn6YCfthw"), "General" },
{ ObjectKey.Parse("p3hCGNrBukOmSP9qD6mY+A"), "Error" },
{ ObjectKey.Parse("mHVBhYlBpUOYXn8WbizPcQ"), "Debug" },
{ ObjectKey.Parse("haQwiMpH_kiU9FGYH00Ssw"), "Performance" },
{ ObjectKey.Parse("TcjJpBIWlUec2e3dRs61hg"), "Warning" },

    };

    protected override Dictionary<string, EN_120b6e3e471666b0ae15ac3a8f34340fEntityRecord> RecordIdToRecordMap { get; } = new() {
        {"General", new() {
ssLabel = "General",
ssOrder = 2,
}},
{"Error", new() {
ssLabel = "Error",
ssOrder = 0,
}},
{"Debug", new() {
ssLabel = "Debug",
ssOrder = 4,
}},
{"Performance", new() {
ssLabel = "Performance",
ssOrder = 3,
}},
{"Warning", new() {
ssLabel = "Warning",
ssOrder = 1,
}},

    };

    protected override Dictionary<string, Dictionary<string, EN_120b6e3e471666b0ae15ac3a8f34340fEntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

