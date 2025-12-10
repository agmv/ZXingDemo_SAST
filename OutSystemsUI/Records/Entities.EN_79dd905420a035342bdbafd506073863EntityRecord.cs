using System.Diagnostics;
namespace ssOutSystemsUI {

public sealed partial class ENLogTypeEntity {
private static readonly ActivitySource activitySource = new(typeof(ENLogTypeEntity).Namespace);
private static readonly System.Collections.Generic.Dictionary<string,string> entityAttributes = new() {{"label", "label"}, {"order", "order"}};
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
} // ENLogTypeEntity
partial class ENLogTypeEntity : InMemoryStaticEntityRuntime<EN_79dd905420a035342bdbafd506073863EntityRecord, string> {
    

    private static ENLogTypeEntity instance = new();
    public static ENLogTypeEntity GetInstance() => instance;

    public static EN_79dd905420a035342bdbafd506073863EntityRecord GetRecordById(string id) {
return instance.GetRecord(id);
}

    public static EN_79dd905420a035342bdbafd506073863EntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, string> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("RTHqC0FO8k+NGiy92WiR2A"), "Performance" },
{ ObjectKey.Parse("6aujULXXk0iqn2oVcfXzEQ"), "Debug" },
{ ObjectKey.Parse("1_AzlVvjL0asfnmugHIIiA"), "Error" },
{ ObjectKey.Parse("BL1ilcpP2k2DOs7eCt4UwQ"), "General" },
{ ObjectKey.Parse("L4RNuHWuO0mZA5MH1ifE2A"), "Warning" },

    };

    protected override Dictionary<string, EN_79dd905420a035342bdbafd506073863EntityRecord> RecordIdToRecordMap { get; } = new() {
        {"Performance", new() {
ssLabel = "Performance",
ssOrder = 3,
}},
{"Debug", new() {
ssLabel = "Debug",
ssOrder = 4,
}},
{"Error", new() {
ssLabel = "Error",
ssOrder = 0,
}},
{"General", new() {
ssLabel = "General",
ssOrder = 2,
}},
{"Warning", new() {
ssLabel = "Warning",
ssOrder = 1,
}},

    };

    protected override Dictionary<string, Dictionary<string, EN_79dd905420a035342bdbafd506073863EntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

