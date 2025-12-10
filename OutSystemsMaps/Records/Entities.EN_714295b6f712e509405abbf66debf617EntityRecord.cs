using System.Diagnostics;
namespace ssOutSystemsMaps {

public sealed partial class ENDirectionsProviderEntity {
private static readonly ActivitySource activitySource = new(typeof(ENDirectionsProviderEntity).Namespace);
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
} // ENDirectionsProviderEntity
partial class ENDirectionsProviderEntity : InMemoryStaticEntityRuntime<EN_714295b6f712e509405abbf66debf617EntityRecord, string> {
    

    private static ENDirectionsProviderEntity instance = new();
    public static ENDirectionsProviderEntity GetInstance() => instance;

    public static EN_714295b6f712e509405abbf66debf617EntityRecord GetRecordById(string id) {
return instance.GetRecord(id);
}

    public static EN_714295b6f712e509405abbf66debf617EntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, string> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("kKTlpIJx90qfiiS2EjmtNg"), "OSRM" },
{ ObjectKey.Parse("nHgpvq86fkenJ5ERgP8LHg"), "MapBox" },

    };

    protected override Dictionary<string, EN_714295b6f712e509405abbf66debf617EntityRecord> RecordIdToRecordMap { get; } = new() {
        {"OSRM", new() {
ssId = "OSRM",
}},
{"MapBox", new() {
ssId = "MapBox",
}},

    };

    protected override Dictionary<string, Dictionary<string, EN_714295b6f712e509405abbf66debf617EntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

