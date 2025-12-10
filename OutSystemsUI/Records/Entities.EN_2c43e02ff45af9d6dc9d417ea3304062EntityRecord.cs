using System.Diagnostics;
namespace ssOutSystemsUI {

public sealed partial class ENSpeedEntity {
private static readonly ActivitySource activitySource = new(typeof(ENSpeedEntity).Namespace);
private static readonly System.Collections.Generic.Dictionary<string,string> entityAttributes = new() {{"speed", "speed"}};
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
} // ENSpeedEntity
partial class ENSpeedEntity : InMemoryStaticEntityRuntime<EN_2c43e02ff45af9d6dc9d417ea3304062EntityRecord, string> {
    

    private static ENSpeedEntity instance = new();
    public static ENSpeedEntity GetInstance() => instance;

    public static EN_2c43e02ff45af9d6dc9d417ea3304062EntityRecord GetRecordById(string id) {
return instance.GetRecord(id);
}

    public static EN_2c43e02ff45af9d6dc9d417ea3304062EntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, string> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("2bayT_9wXUGgnU7gWt2lxA"), "fast" },
{ ObjectKey.Parse("XyG5k7GPCE+FVZsBJbGPUQ"), "normal" },
{ ObjectKey.Parse("MX3Gsm1Q50KJDg5PKSNK5g"), "slow" },

    };

    protected override Dictionary<string, EN_2c43e02ff45af9d6dc9d417ea3304062EntityRecord> RecordIdToRecordMap { get; } = new() {
        {"fast", new() {
ssSpeed = "fast",
}},
{"normal", new() {
ssSpeed = "normal",
}},
{"slow", new() {
ssSpeed = "slow",
}},

    };

    protected override Dictionary<string, Dictionary<string, EN_2c43e02ff45af9d6dc9d417ea3304062EntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

