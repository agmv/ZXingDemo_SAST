using System.Diagnostics;
namespace ssOutSystemsUI {

public sealed partial class ENSpaceEntity {
private static readonly ActivitySource activitySource = new(typeof(ENSpaceEntity).Namespace);
private static readonly System.Collections.Generic.Dictionary<string,string> entityAttributes = new() {{"space", "space"}, {"order", "order"}};
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
} // ENSpaceEntity
partial class ENSpaceEntity : InMemoryStaticEntityRuntime<EN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord, string> {
    

    private static ENSpaceEntity instance = new();
    public static ENSpaceEntity GetInstance() => instance;

    public static EN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord GetRecordById(string id) {
return instance.GetRecord(id);
}

    public static EN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, string> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("Z1C1UQjm7UmfAB+vnkppSg"), "l" },
{ ObjectKey.Parse("f+lAc2TeN0OtDR3vyritsg"), "m" },
{ ObjectKey.Parse("+BMygvmd4E2KuitVZub4fQ"), "xxl" },
{ ObjectKey.Parse("uvmtg8_74Ey0pLxjMJVriQ"), "xs" },
{ ObjectKey.Parse("pRCSkTtryUCaKLTiwopG+A"), "s" },
{ ObjectKey.Parse("0ypX8KxUVUeMjqkAQXH8sQ"), "base" },
{ ObjectKey.Parse("ufra+LljskCXVfL4+j1uhA"), "xl" },
{ ObjectKey.Parse("l3uT+5S9pEuA_0Rss732rg"), "none" },

    };

    protected override Dictionary<string, EN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord> RecordIdToRecordMap { get; } = new() {
        {"l", new() {
ssSpace = "l",
ssOrder = 6,
}},
{"m", new() {
ssSpace = "m",
ssOrder = 5,
}},
{"xxl", new() {
ssSpace = "xxl",
ssOrder = 8,
}},
{"xs", new() {
ssSpace = "xs",
ssOrder = 2,
}},
{"s", new() {
ssSpace = "s",
ssOrder = 3,
}},
{"base", new() {
ssSpace = "base",
ssOrder = 4,
}},
{"xl", new() {
ssSpace = "xl",
ssOrder = 7,
}},
{"none", new() {
ssSpace = "none",
ssOrder = 1,
}},

    };

    protected override Dictionary<string, Dictionary<string, EN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

