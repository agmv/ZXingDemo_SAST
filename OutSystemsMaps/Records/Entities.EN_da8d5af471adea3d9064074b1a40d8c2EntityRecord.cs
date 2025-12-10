using System.Diagnostics;
namespace ssOutSystemsMaps {

public sealed partial class ENTypeEntity {
private static readonly ActivitySource activitySource = new(typeof(ENTypeEntity).Namespace);
private static readonly System.Collections.Generic.Dictionary<string,string> entityAttributes = new() {{"maptype", "maptype"}, {"label", "label"}, {"order", "order"}, {"is_active", "is_active"}};
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
} // ENTypeEntity
partial class ENTypeEntity : InMemoryStaticEntityRuntime<EN_da8d5af471adea3d9064074b1a40d8c2EntityRecord, string> {
    

    private static ENTypeEntity instance = new();
    public static ENTypeEntity GetInstance() => instance;

    public static EN_da8d5af471adea3d9064074b1a40d8c2EntityRecord GetRecordById(string id) {
return instance.GetRecord(id);
}

    public static EN_da8d5af471adea3d9064074b1a40d8c2EntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, string> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("woeRAuJfr0a41KWDxwYb2w"), "hybrid" },
{ ObjectKey.Parse("tjRLDOMFCkCgexgYvuyLUg"), "terrain" },
{ ObjectKey.Parse("ovetaFeGuE6McBWDcnLLEg"), "roadmap" },
{ ObjectKey.Parse("HrB8sCkOaEmxFIaOner5wQ"), "satellite" },

    };

    protected override Dictionary<string, EN_da8d5af471adea3d9064074b1a40d8c2EntityRecord> RecordIdToRecordMap { get; } = new() {
        {"hybrid", new() {
ssMapType = "hybrid",
ssLabel = "hybrid",
ssOrder = 3,
ssIs_Active = true,
}},
{"terrain", new() {
ssMapType = "terrain",
ssLabel = "terrain",
ssOrder = 4,
ssIs_Active = true,
}},
{"roadmap", new() {
ssMapType = "roadmap",
ssLabel = "roadmap",
ssOrder = 1,
ssIs_Active = true,
}},
{"satellite", new() {
ssMapType = "satellite",
ssLabel = "satellite",
ssOrder = 2,
ssIs_Active = true,
}},

    };

    protected override Dictionary<string, Dictionary<string, EN_da8d5af471adea3d9064074b1a40d8c2EntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

