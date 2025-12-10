using System.Diagnostics;
namespace ssOutSystemsUI {

public sealed partial class ENBreakColumnsEntity {
private static readonly ActivitySource activitySource = new(typeof(ENBreakColumnsEntity).Namespace);
private static readonly System.Collections.Generic.Dictionary<string,string> entityAttributes = new() {{"breakcolumns", "breakcolumns"}};
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
} // ENBreakColumnsEntity
partial class ENBreakColumnsEntity : InMemoryStaticEntityRuntime<EN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord, string> {
    

    private static ENBreakColumnsEntity instance = new();
    public static ENBreakColumnsEntity GetInstance() => instance;

    public static EN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord GetRecordById(string id) {
return instance.GetRecord(id);
}

    public static EN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, string> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("TpASB74DX0ubnuzGQPhJEw"), "break-none" },
{ ObjectKey.Parse("RMpVPXCc1Eu_ln0KfsHDtg"), "break-first" },
{ ObjectKey.Parse("OK_gY2yLcEm5aqzYxthj5A"), "break-all" },
{ ObjectKey.Parse("PEJNaRfOoUWZk8tXww7GdA"), "break-middle" },
{ ObjectKey.Parse("CjKYbHjBJUm0K3Fl7YBeoA"), "break-last" },

    };

    protected override Dictionary<string, EN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord> RecordIdToRecordMap { get; } = new() {
        {"break-none", new() {
ssBreakColumns = "break-none",
}},
{"break-first", new() {
ssBreakColumns = "break-first",
}},
{"break-all", new() {
ssBreakColumns = "break-all",
}},
{"break-middle", new() {
ssBreakColumns = "break-middle",
}},
{"break-last", new() {
ssBreakColumns = "break-last",
}},

    };

    protected override Dictionary<string, Dictionary<string, EN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

