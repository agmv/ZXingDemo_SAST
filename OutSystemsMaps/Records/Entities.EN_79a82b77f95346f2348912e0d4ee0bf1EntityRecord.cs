using System.Diagnostics;
namespace ssOutSystemsMaps {

public sealed partial class ENVerbosityEntity {
private static readonly ActivitySource activitySource = new(typeof(ENVerbosityEntity).Namespace);
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
} // ENVerbosityEntity
partial class ENVerbosityEntity : InMemoryStaticEntityRuntime<EN_79a82b77f95346f2348912e0d4ee0bf1EntityRecord, string> {
    

    private static ENVerbosityEntity instance = new();
    public static ENVerbosityEntity GetInstance() => instance;

    public static EN_79a82b77f95346f2348912e0d4ee0bf1EntityRecord GetRecordById(string id) {
return instance.GetRecord(id);
}

    public static EN_79a82b77f95346f2348912e0d4ee0bf1EntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, string> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("McaiYdcF60K1eDsHl1Q9tA"), "Verbose" },
{ ObjectKey.Parse("7FsJaXS2SUKhLTJfL82poA"), "No Logging" },
{ ObjectKey.Parse("UugjoCOQPEGBDep4EPVz2w"), "Error" },
{ ObjectKey.Parse("8ICS4IYeZU62b7PG5RV2jg"), "Warning" },
{ ObjectKey.Parse("Z8VY8X2ylEeWPukvjEsRpQ"), "Log" },

    };

    protected override Dictionary<string, EN_79a82b77f95346f2348912e0d4ee0bf1EntityRecord> RecordIdToRecordMap { get; } = new() {
        {"Verbose", new() {
ssLabel = "Verbose",
ssOrder = 4,
}},
{"No Logging", new() {
ssLabel = "No Logging",
ssOrder = 0,
}},
{"Error", new() {
ssLabel = "Error",
ssOrder = 1,
}},
{"Warning", new() {
ssLabel = "Warning",
ssOrder = 2,
}},
{"Log", new() {
ssLabel = "Log",
ssOrder = 3,
}},

    };

    protected override Dictionary<string, Dictionary<string, EN_79a82b77f95346f2348912e0d4ee0bf1EntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

