using System.Diagnostics;
namespace ssOutSystemsUI {

public sealed partial class ENDropdownTypeEntity {
private static readonly ActivitySource activitySource = new(typeof(ENDropdownTypeEntity).Namespace);
private static readonly System.Collections.Generic.Dictionary<string,string> entityAttributes = new() {{"mode", "mode"}};
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
} // ENDropdownTypeEntity
partial class ENDropdownTypeEntity : InMemoryStaticEntityRuntime<EN_7a28bfa00272cf999603d060780d47ecEntityRecord, string> {
    

    private static ENDropdownTypeEntity instance = new();
    public static ENDropdownTypeEntity GetInstance() => instance;

    public static EN_7a28bfa00272cf999603d060780d47ecEntityRecord GetRecordById(string id) {
return instance.GetRecord(id);
}

    public static EN_7a28bfa00272cf999603d060780d47ecEntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, string> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("DoNWbPQUjEG9LU0uBUQ0jw"), "tags" },
{ ObjectKey.Parse("rAT_l06IPUK3Vgcv6Fp_Aw"), "server-side" },
{ ObjectKey.Parse("lw+ruc3ClkaXfnC3Ni8_FQ"), "search" },

    };

    protected override Dictionary<string, EN_7a28bfa00272cf999603d060780d47ecEntityRecord> RecordIdToRecordMap { get; } = new() {
        {"tags", new() {
ssMode = "tags",
}},
{"server-side", new() {
ssMode = "server-side",
}},
{"search", new() {
ssMode = "search",
}},

    };

    protected override Dictionary<string, Dictionary<string, EN_7a28bfa00272cf999603d060780d47ecEntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

