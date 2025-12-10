using System.Diagnostics;
namespace ssOutSystemsMaps {

public sealed partial class ENMarkerEventTriggeredEntity {
private static readonly ActivitySource activitySource = new(typeof(ENMarkerEventTriggeredEntity).Namespace);
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
} // ENMarkerEventTriggeredEntity
partial class ENMarkerEventTriggeredEntity : InMemoryStaticEntityRuntime<EN_d9c97e718205f8627d74b06df54e3543EntityRecord, string> {
    

    private static ENMarkerEventTriggeredEntity instance = new();
    public static ENMarkerEventTriggeredEntity GetInstance() => instance;

    public static EN_d9c97e718205f8627d74b06df54e3543EntityRecord GetRecordById(string id) {
return instance.GetRecord(id);
}

    public static EN_d9c97e718205f8627d74b06df54e3543EntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, string> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("fDOgJSerVEay8d3gjry6dw"), "OnClick" },
{ ObjectKey.Parse("Ee3afS4a5kO8nKC2BDA05g"), "dblclick" },
{ ObjectKey.Parse("zFJwuA+wJEmcMOi4s28gYg"), "contextmenu" },
{ ObjectKey.Parse("ZBLp+boaAkKgWxZid51hjg"), "dragend" },

    };

    protected override Dictionary<string, EN_d9c97e718205f8627d74b06df54e3543EntityRecord> RecordIdToRecordMap { get; } = new() {
        {"OnClick", new() {
ssId = "OnClick",
}},
{"dblclick", new() {
ssId = "dblclick",
}},
{"contextmenu", new() {
ssId = "contextmenu",
}},
{"dragend", new() {
ssId = "dragend",
}},

    };

    protected override Dictionary<string, Dictionary<string, EN_d9c97e718205f8627d74b06df54e3543EntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

