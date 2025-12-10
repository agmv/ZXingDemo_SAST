using System.Diagnostics;
namespace ssOutSystemsMaps {

public sealed partial class ENMapEventTriggeredEntity {
private static readonly ActivitySource activitySource = new(typeof(ENMapEventTriggeredEntity).Namespace);
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
} // ENMapEventTriggeredEntity
partial class ENMapEventTriggeredEntity : InMemoryStaticEntityRuntime<EN_2b877a58494bdf7ca89c3ea2061b88c8EntityRecord, string> {
    

    private static ENMapEventTriggeredEntity instance = new();
    public static ENMapEventTriggeredEntity GetInstance() => instance;

    public static EN_2b877a58494bdf7ca89c3ea2061b88c8EntityRecord GetRecordById(string id) {
return instance.GetRecord(id);
}

    public static EN_2b877a58494bdf7ca89c3ea2061b88c8EntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, string> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("08ZPHjb3qEiXlPxS4+BaKg"), "dragend" },
{ ObjectKey.Parse("66ijIk49uEevIiN62C652A"), "contextmenu" },
{ ObjectKey.Parse("msAaKa1BQUCX2VOefqQhbA"), "dblclick" },
{ ObjectKey.Parse("vh3ekSKtWkah4rxKKrGM7g"), "click" },
{ ObjectKey.Parse("1J+TrrhG00G3RjI2lALTGw"), "zoom_changed" },

    };

    protected override Dictionary<string, EN_2b877a58494bdf7ca89c3ea2061b88c8EntityRecord> RecordIdToRecordMap { get; } = new() {
        {"dragend", new() {
ssId = "dragend",
}},
{"contextmenu", new() {
ssId = "contextmenu",
}},
{"dblclick", new() {
ssId = "dblclick",
}},
{"click", new() {
ssId = "click",
}},
{"zoom_changed", new() {
ssId = "zoom_changed",
}},

    };

    protected override Dictionary<string, Dictionary<string, EN_2b877a58494bdf7ca89c3ea2061b88c8EntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

