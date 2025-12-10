using System.Diagnostics;
namespace ssOutSystemsUI {

public sealed partial class ENFloatingPositionEntity {
private static readonly ActivitySource activitySource = new(typeof(ENFloatingPositionEntity).Namespace);
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
} // ENFloatingPositionEntity
partial class ENFloatingPositionEntity : InMemoryStaticEntityRuntime<EN_4f86046673de081f9834eb306850ab22EntityRecord, string> {
    

    private static ENFloatingPositionEntity instance = new();
    public static ENFloatingPositionEntity GetInstance() => instance;

    public static EN_4f86046673de081f9834eb306850ab22EntityRecord GetRecordById(string id) {
return instance.GetRecord(id);
}

    public static EN_4f86046673de081f9834eb306850ab22EntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, string> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("EcD8CSVRfUyUyiKg9IPvwg"), "left-start" },
{ ObjectKey.Parse("WwquJQek+EOpb5oluZryUw"), "top-end" },
{ ObjectKey.Parse("w_GZLXzEMEmm2e+9WvlHPg"), "right" },
{ ObjectKey.Parse("fBZZQ8QlMUai_U1ohEv3dg"), "top" },
{ ObjectKey.Parse("ivzGVTLmlkOg87MEd01ATQ"), "bottom-end" },
{ ObjectKey.Parse("iXgvXFSndk6SAnThrfZKqA"), "auto" },
{ ObjectKey.Parse("QyQLaSHNFUykgNtlQ4flvg"), "left-end" },
{ ObjectKey.Parse("lJikdRvtZUWriDzmfLHyAg"), "bottom-start" },
{ ObjectKey.Parse("kxmkdnLvA0mkNbRXsU+V6A"), "right-end" },
{ ObjectKey.Parse("tAvwk5yEUkajppX_NWr8QQ"), "top-start" },
{ ObjectKey.Parse("Z7knue3pJUuMm3XlllH0hg"), "left" },
{ ObjectKey.Parse("aUGO0VlSm0abxcclGwfDpQ"), "right-start" },
{ ObjectKey.Parse("qWok85cwmESEGNSNDqo+bg"), "center" },
{ ObjectKey.Parse("nt3Z9zyztkKzLSmwrltq3A"), "bottom" },

    };

    protected override Dictionary<string, EN_4f86046673de081f9834eb306850ab22EntityRecord> RecordIdToRecordMap { get; } = new() {
        {"left-start", new() {
ssPosition = "left-start",
}},
{"top-end", new() {
ssPosition = "top-end",
}},
{"right", new() {
ssPosition = "right",
}},
{"top", new() {
ssPosition = "top",
}},
{"bottom-end", new() {
ssPosition = "bottom-end",
}},
{"auto", new() {
ssPosition = "auto",
}},
{"left-end", new() {
ssPosition = "left-end",
}},
{"bottom-start", new() {
ssPosition = "bottom-start",
}},
{"right-end", new() {
ssPosition = "right-end",
}},
{"top-start", new() {
ssPosition = "top-start",
}},
{"left", new() {
ssPosition = "left",
}},
{"right-start", new() {
ssPosition = "right-start",
}},
{"center", new() {
ssPosition = "center",
}},
{"bottom", new() {
ssPosition = "bottom",
}},

    };

    protected override Dictionary<string, Dictionary<string, EN_4f86046673de081f9834eb306850ab22EntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

