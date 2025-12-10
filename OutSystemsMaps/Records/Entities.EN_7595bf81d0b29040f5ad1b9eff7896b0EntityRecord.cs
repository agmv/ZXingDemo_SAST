using System.Diagnostics;
namespace ssOutSystemsMaps {

public sealed partial class ENMarkerEventEntity {
private static readonly ActivitySource activitySource = new(typeof(ENMarkerEventEntity).Namespace);
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
} // ENMarkerEventEntity
partial class ENMarkerEventEntity : InMemoryStaticEntityRuntime<EN_7595bf81d0b29040f5ad1b9eff7896b0EntityRecord, string> {
    

    private static ENMarkerEventEntity instance = new();
    public static ENMarkerEventEntity GetInstance() => instance;

    public static EN_7595bf81d0b29040f5ad1b9eff7896b0EntityRecord GetRecordById(string id) {
return instance.GetRecord(id);
}

    public static EN_7595bf81d0b29040f5ad1b9eff7896b0EntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, string> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("MkgaDrTxYkCToeL8OcEX1A"), "OnClick" },
{ ObjectKey.Parse("GsY0Hnydw0qS0EiWmRfEgw"), "Initialized" },

    };

    protected override Dictionary<string, EN_7595bf81d0b29040f5ad1b9eff7896b0EntityRecord> RecordIdToRecordMap { get; } = new() {
        {"OnClick", new() {
ssId = "OnClick",
}},
{"Initialized", new() {
ssId = "Initialized",
}},

    };

    protected override Dictionary<string, Dictionary<string, EN_7595bf81d0b29040f5ad1b9eff7896b0EntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

