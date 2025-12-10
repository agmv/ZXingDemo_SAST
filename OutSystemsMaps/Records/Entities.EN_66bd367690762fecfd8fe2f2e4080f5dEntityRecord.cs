using System.Diagnostics;
namespace ssOutSystemsMaps {

public sealed partial class ENTravelModeEntity {
private static readonly ActivitySource activitySource = new(typeof(ENTravelModeEntity).Namespace);
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
} // ENTravelModeEntity
partial class ENTravelModeEntity : InMemoryStaticEntityRuntime<EN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord, string> {
    

    private static ENTravelModeEntity instance = new();
    public static ENTravelModeEntity GetInstance() => instance;

    public static EN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord GetRecordById(string id) {
return instance.GetRecord(id);
}

    public static EN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, string> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("lvbKASJr40+62g6Y9cbpgQ"), "DRIVING" },
{ ObjectKey.Parse("XCsblsKULE+uEkh1XmyNSg"), "BICYCLING" },
{ ObjectKey.Parse("gY5m2VHf5Eq2UwU_ZHf8Ew"), "TRANSIT" },
{ ObjectKey.Parse("gV3K+IKxyUS3kI2SgSRU8Q"), "WALKING" },

    };

    protected override Dictionary<string, EN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord> RecordIdToRecordMap { get; } = new() {
        {"DRIVING", new() {
ssId = "DRIVING",
}},
{"BICYCLING", new() {
ssId = "BICYCLING",
}},
{"TRANSIT", new() {
ssId = "TRANSIT",
}},
{"WALKING", new() {
ssId = "WALKING",
}},

    };

    protected override Dictionary<string, Dictionary<string, EN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

