using System.Diagnostics;
namespace ssOutSystemsMaps {

public sealed partial class ENDrawingToolsEventTriggeredEntity {
private static readonly ActivitySource activitySource = new(typeof(ENDrawingToolsEventTriggeredEntity).Namespace);
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
} // ENDrawingToolsEventTriggeredEntity
partial class ENDrawingToolsEventTriggeredEntity : InMemoryStaticEntityRuntime<EN_8a068e43cce18c5870b845073fb713c1EntityRecord, string> {
    

    private static ENDrawingToolsEventTriggeredEntity instance = new();
    public static ENDrawingToolsEventTriggeredEntity GetInstance() => instance;

    public static EN_8a068e43cce18c5870b845073fb713c1EntityRecord GetRecordById(string id) {
return instance.GetRecord(id);
}

    public static EN_8a068e43cce18c5870b845073fb713c1EntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, string> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("3qa_CrLxbUmwhfd1yzyFxA"), "polygoncomplete" },
{ ObjectKey.Parse("WTPUf3Z27EyviyIBMg029A"), "polylinecomplete" },
{ ObjectKey.Parse("poxjz+SEdEmRmUmD+J+vxA"), "rectanglecomplete" },
{ ObjectKey.Parse("L8Pz51_wkUm+cVFxeGPP2w"), "circlecomplete" },
{ ObjectKey.Parse("hix9_jiuUkazvHG9UJAoCA"), "markercomplete" },

    };

    protected override Dictionary<string, EN_8a068e43cce18c5870b845073fb713c1EntityRecord> RecordIdToRecordMap { get; } = new() {
        {"polygoncomplete", new() {
ssId = "polygoncomplete",
}},
{"polylinecomplete", new() {
ssId = "polylinecomplete",
}},
{"rectanglecomplete", new() {
ssId = "rectanglecomplete",
}},
{"circlecomplete", new() {
ssId = "circlecomplete",
}},
{"markercomplete", new() {
ssId = "markercomplete",
}},

    };

    protected override Dictionary<string, Dictionary<string, EN_8a068e43cce18c5870b845073fb713c1EntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

