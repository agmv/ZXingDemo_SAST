using System.Diagnostics;
namespace ssOutSystemsUI {

public sealed partial class ENGradientEntity {
private static readonly ActivitySource activitySource = new(typeof(ENGradientEntity).Namespace);
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
} // ENGradientEntity
partial class ENGradientEntity : InMemoryStaticEntityRuntime<EN_f318de02ad2d00bca70ecb5d73f27ec9EntityRecord, string> {
    

    private static ENGradientEntity instance = new();
    public static ENGradientEntity GetInstance() => instance;

    public static EN_f318de02ad2d00bca70ecb5d73f27ec9EntityRecord GetRecordById(string id) {
return instance.GetRecord(id);
}

    public static EN_f318de02ad2d00bca70ecb5d73f27ec9EntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, string> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("cwYljShVO0Cee9FxepghnA"), "LinearHorizontal" },
{ ObjectKey.Parse("+E3OuZ7DOkqE2TXbx56C_A"), "Radial" },
{ ObjectKey.Parse("NW3xznpnAkCNU3s4W+ABHQ"), "LinearDiagonally" },
{ ObjectKey.Parse("R7Eo8XPB+E2mJNAeqwHEbA"), "LinearVertical" },

    };

    protected override Dictionary<string, EN_f318de02ad2d00bca70ecb5d73f27ec9EntityRecord> RecordIdToRecordMap { get; } = new() {
        {"LinearHorizontal", new() {
ssType = "LinearHorizontal",
}},
{"Radial", new() {
ssType = "Radial",
}},
{"LinearDiagonally", new() {
ssType = "LinearDiagonally",
}},
{"LinearVertical", new() {
ssType = "LinearVertical",
}},

    };

    protected override Dictionary<string, Dictionary<string, EN_f318de02ad2d00bca70ecb5d73f27ec9EntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

