using System.Diagnostics;
namespace ssOutSystemsUI {

public sealed partial class ENColumnBreakEntity {
private static readonly ActivitySource activitySource = new(typeof(ENColumnBreakEntity).Namespace);
private static readonly System.Collections.Generic.Dictionary<string,string> entityAttributes = new() {{"columnbreak", "columnbreak"}};
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
} // ENColumnBreakEntity
partial class ENColumnBreakEntity : InMemoryStaticEntityRuntime<EN_ef2257119ab36e2c35ddd0bb3d7ac544EntityRecord, string> {
    

    private static ENColumnBreakEntity instance = new();
    public static ENColumnBreakEntity GetInstance() => instance;

    public static EN_ef2257119ab36e2c35ddd0bb3d7ac544EntityRecord GetRecordById(string id) {
return instance.GetRecord(id);
}

    public static EN_ef2257119ab36e2c35ddd0bb3d7ac544EntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, string> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("mfwBOyPvQ0CHcfiGYHIOAQ"), "break-middle" },
{ ObjectKey.Parse("c494Q5NolkO2egSm_2kOdA"), "break-all" },
{ ObjectKey.Parse("CcbmaYqep0WwBkW5InXsSQ"), "break-none" },
{ ObjectKey.Parse("yCU3a1GJ7Uipd8v68APIlg"), "break-last" },
{ ObjectKey.Parse("tkWLjK_BEUuQfjyKXOFh4g"), "break-first" },

    };

    protected override Dictionary<string, EN_ef2257119ab36e2c35ddd0bb3d7ac544EntityRecord> RecordIdToRecordMap { get; } = new() {
        {"break-middle", new() {
ssColumnBreak = "break-middle",
}},
{"break-all", new() {
ssColumnBreak = "break-all",
}},
{"break-none", new() {
ssColumnBreak = "break-none",
}},
{"break-last", new() {
ssColumnBreak = "break-last",
}},
{"break-first", new() {
ssColumnBreak = "break-first",
}},

    };

    protected override Dictionary<string, Dictionary<string, EN_ef2257119ab36e2c35ddd0bb3d7ac544EntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

