using System.Diagnostics;
namespace ssOutSystemsUI {

public sealed partial class ENCarouselNavigationEntity {
private static readonly ActivitySource activitySource = new(typeof(ENCarouselNavigationEntity).Namespace);
private static readonly System.Collections.Generic.Dictionary<string,string> entityAttributes = new() {{"type", "type"}};
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
} // ENCarouselNavigationEntity
partial class ENCarouselNavigationEntity : InMemoryStaticEntityRuntime<EN_59aacee1cb91627a0f497366b24e4500EntityRecord, string> {
    

    private static ENCarouselNavigationEntity instance = new();
    public static ENCarouselNavigationEntity GetInstance() => instance;

    public static EN_59aacee1cb91627a0f497366b24e4500EntityRecord GetRecordById(string id) {
return instance.GetRecord(id);
}

    public static EN_59aacee1cb91627a0f497366b24e4500EntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, string> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("b4OjK2E9aEi5SfsBpODUQQ"), "dots" },
{ ObjectKey.Parse("ae5_NpXcJEabpdpofYgYhg"), "none" },
{ ObjectKey.Parse("dYrnOoVMqkq6LRLCSQKnzw"), "arrows" },
{ ObjectKey.Parse("U_ajWR3_oEmtL92nJbE1Kw"), "both" },

    };

    protected override Dictionary<string, EN_59aacee1cb91627a0f497366b24e4500EntityRecord> RecordIdToRecordMap { get; } = new() {
        {"dots", new() {
ssType = "dots",
}},
{"none", new() {
ssType = "none",
}},
{"arrows", new() {
ssType = "arrows",
}},
{"both", new() {
ssType = "both",
}},

    };

    protected override Dictionary<string, Dictionary<string, EN_59aacee1cb91627a0f497366b24e4500EntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

