using System.Diagnostics;
namespace ssOutSystemsUI {

public sealed partial class ENDirectionEntity {
private static readonly ActivitySource activitySource = new(typeof(ENDirectionEntity).Namespace);
private static readonly System.Collections.Generic.Dictionary<string,string> entityAttributes = new() {{"direction", "direction"}, {"order", "order"}};
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
} // ENDirectionEntity
partial class ENDirectionEntity : InMemoryStaticEntityRuntime<EN_50814454e481dd1773c2250bc248da5eEntityRecord, string> {
    

    private static ENDirectionEntity instance = new();
    public static ENDirectionEntity GetInstance() => instance;

    public static EN_50814454e481dd1773c2250bc248da5eEntityRecord GetRecordById(string id) {
return instance.GetRecord(id);
}

    public static EN_50814454e481dd1773c2250bc248da5eEntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, string> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("dTjFZzFGd0u1v3BPY_5QaA"), "left" },
{ ObjectKey.Parse("gkZm1AsS3keWPPfg4sQy6Q"), "right" },

    };

    protected override Dictionary<string, EN_50814454e481dd1773c2250bc248da5eEntityRecord> RecordIdToRecordMap { get; } = new() {
        {"left", new() {
ssDirection = "left",
ssOrder = 2,
}},
{"right", new() {
ssDirection = "right",
ssOrder = 1,
}},

    };

    protected override Dictionary<string, Dictionary<string, EN_50814454e481dd1773c2250bc248da5eEntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

