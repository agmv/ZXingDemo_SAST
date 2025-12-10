using System.Diagnostics;
namespace ssOutSystemsUI {

public sealed partial class ENVideoStateEntity {
private static readonly ActivitySource activitySource = new(typeof(ENVideoStateEntity).Namespace);
private static readonly System.Collections.Generic.Dictionary<string,string> entityAttributes = new() {{"state", "state"}};
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
} // ENVideoStateEntity
partial class ENVideoStateEntity : InMemoryStaticEntityRuntime<EN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord, string> {
    

    private static ENVideoStateEntity instance = new();
    public static ENVideoStateEntity GetInstance() => instance;

    public static EN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord GetRecordById(string id) {
return instance.GetRecord(id);
}

    public static EN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, string> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("j1BIOeMMqEuM7MHtYs3NLw"), "Unstarted" },
{ ObjectKey.Parse("Z4+Va_sdB0+HKW8sT_yqEQ"), "Paused" },
{ ObjectKey.Parse("hW8asDXnL0CVAoDKb3gq9Q"), "Ended" },
{ ObjectKey.Parse("sy+k4G0za0m1xN3pXMeICg"), "Playing" },

    };

    protected override Dictionary<string, EN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord> RecordIdToRecordMap { get; } = new() {
        {"Unstarted", new() {
ssState = "Unstarted",
}},
{"Paused", new() {
ssState = "Paused",
}},
{"Ended", new() {
ssState = "Ended",
}},
{"Playing", new() {
ssState = "Playing",
}},

    };

    protected override Dictionary<string, Dictionary<string, EN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

