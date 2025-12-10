using System.Diagnostics;
namespace ssOutSystemsUI {

public sealed partial class ENRangeSliderTypeEntity {
private static readonly ActivitySource activitySource = new(typeof(ENRangeSliderTypeEntity).Namespace);
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
} // ENRangeSliderTypeEntity
partial class ENRangeSliderTypeEntity : InMemoryStaticEntityRuntime<EN_7e19f04989174b13ab8c3badf82f69b4EntityRecord, string> {
    

    private static ENRangeSliderTypeEntity instance = new();
    public static ENRangeSliderTypeEntity GetInstance() => instance;

    public static EN_7e19f04989174b13ab8c3badf82f69b4EntityRecord GetRecordById(string id) {
return instance.GetRecord(id);
}

    public static EN_7e19f04989174b13ab8c3badf82f69b4EntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, string> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("Js_nVT1flE2c_IJYrirxKw"), "single" },
{ ObjectKey.Parse("TdEa0DfPrkeKlW+_N5VY0A"), "interval" },

    };

    protected override Dictionary<string, EN_7e19f04989174b13ab8c3badf82f69b4EntityRecord> RecordIdToRecordMap { get; } = new() {
        {"single", new() {
ssMode = "single",
}},
{"interval", new() {
ssMode = "interval",
}},

    };

    protected override Dictionary<string, Dictionary<string, EN_7e19f04989174b13ab8c3badf82f69b4EntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

