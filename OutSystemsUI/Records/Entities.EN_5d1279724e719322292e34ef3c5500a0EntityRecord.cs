using System.Diagnostics;
namespace ssOutSystemsUI {

public sealed partial class ENPositionEntity {
private static readonly ActivitySource activitySource = new(typeof(ENPositionEntity).Namespace);
private static readonly System.Collections.Generic.Dictionary<string,string> entityAttributes = new() {{"position", "position"}};
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
} // ENPositionEntity
partial class ENPositionEntity : InMemoryStaticEntityRuntime<EN_5d1279724e719322292e34ef3c5500a0EntityRecord, string> {
    

    private static ENPositionEntity instance = new();
    public static ENPositionEntity GetInstance() => instance;

    public static EN_5d1279724e719322292e34ef3c5500a0EntityRecord GetRecordById(string id) {
return instance.GetRecord(id);
}

    public static EN_5d1279724e719322292e34ef3c5500a0EntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, string> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("Nay8O54wqEm_G6PGbh7zzQ"), "top" },
{ ObjectKey.Parse("GshwTb1nH0qiGsaqE9DzZA"), "left" },
{ ObjectKey.Parse("RJxFc2ABVESK0Mm9RHeKYQ"), "bottom-right" },
{ ObjectKey.Parse("DFdSczokBU+20WCElZMRGA"), "bottom-left" },
{ ObjectKey.Parse("e2lDv4MkVUimwgp4a6tHLw"), "right" },
{ ObjectKey.Parse("YizSwTZaaU2xiALWK4_nxA"), "top-left" },
{ ObjectKey.Parse("ropN0cnxOEWkqZGiaQ5tkg"), "top-right" },
{ ObjectKey.Parse("ov_J3Kc0l0CG0N3iJJB0JQ"), "center" },
{ ObjectKey.Parse("+ZCN+zJUeEaTK_RowA0zYQ"), "bottom" },

    };

    protected override Dictionary<string, EN_5d1279724e719322292e34ef3c5500a0EntityRecord> RecordIdToRecordMap { get; } = new() {
        {"top", new() {
ssPosition = "top",
}},
{"left", new() {
ssPosition = "left",
}},
{"bottom-right", new() {
ssPosition = "bottom-right",
}},
{"bottom-left", new() {
ssPosition = "bottom-left",
}},
{"right", new() {
ssPosition = "right",
}},
{"top-left", new() {
ssPosition = "top-left",
}},
{"top-right", new() {
ssPosition = "top-right",
}},
{"center", new() {
ssPosition = "center",
}},
{"bottom", new() {
ssPosition = "bottom",
}},

    };

    protected override Dictionary<string, Dictionary<string, EN_5d1279724e719322292e34ef3c5500a0EntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

