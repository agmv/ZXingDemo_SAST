using System.Diagnostics;
namespace ssOutSystemsMaps {

public sealed partial class ENSearchPlacesErrorsEntity {
private static readonly ActivitySource activitySource = new(typeof(ENSearchPlacesErrorsEntity).Namespace);
private static readonly System.Collections.Generic.Dictionary<string,string> entityAttributes = new() {{"code", "code"}, {"message", "message"}};
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
} // ENSearchPlacesErrorsEntity
partial class ENSearchPlacesErrorsEntity : InMemoryStaticEntityRuntime<EN_ddceb9a0506316e12e8b49777be81ba4EntityRecord, string> {
    

    private static ENSearchPlacesErrorsEntity instance = new();
    public static ENSearchPlacesErrorsEntity GetInstance() => instance;

    public static EN_ddceb9a0506316e12e8b49777be81ba4EntityRecord GetRecordById(string id) {
return instance.GetRecord(id);
}

    public static EN_ddceb9a0506316e12e8b49777be81ba4EntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, string> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("mMQ3AgMKV0C2a9PLdVEjpQ"), "MAPS-GEN-10002" },
{ ObjectKey.Parse("egCGQQuRZUq6cm+p1Mio3w"), "MAPS-CFG-10001" },
{ ObjectKey.Parse("wDPlQrovVkC2xhOxYB6KlQ"), "MAPS-LIB-10001" },
{ ObjectKey.Parse("ZHoRV1HnqU21alpNuvFfMA"), "MAPS-CFG-01002" },
{ ObjectKey.Parse("KIiJe5M_40SgRKg7cvLEAg"), "MAPS-LIB-10002" },
{ ObjectKey.Parse("qrYPgSAoDEy80WsNfp4mqA"), "MAPS-CFG-10003" },
{ ObjectKey.Parse("WFhQqHq41UaArVDayrXgHw"), "MAPS-GEN-10001" },
{ ObjectKey.Parse("K8A2uY4jzEeCPzv_GYLi_g"), "MAPS-CFG-10002" },

    };

    protected override Dictionary<string, EN_ddceb9a0506316e12e8b49777be81ba4EntityRecord> RecordIdToRecordMap { get; } = new() {
        {"MAPS-GEN-10002", new() {
ssCode = "MAPS-GEN-10002",
ssMessage = "The specified SearchPlaces event is not supported: ",
}},
{"MAPS-CFG-10001", new() {
ssCode = "MAPS-CFG-10001",
ssMessage = "APIKey can only be set one time on the Search Places",
}},
{"MAPS-LIB-10001", new() {
ssCode = "MAPS-LIB-10001",
ssMessage = "The APIKey set on the SearchPlaces is invalid for GoogleMaps API",
}},
{"MAPS-CFG-01002", new() {
ssCode = "MAPS-CFG-01002",
ssMessage = "The APIKey from Google Places and Google Maps must be equal.",
}},
{"MAPS-LIB-10002", new() {
ssCode = "MAPS-LIB-10002",
ssMessage = "Failed Geocoding one or more locations of the SearchArea from SearchPlaces due to: ",
}},
{"MAPS-CFG-10003", new() {
ssCode = "MAPS-CFG-10003",
ssMessage = "The maximum number of countries you can use on a SearchPlace is 5.",
}},
{"MAPS-GEN-10001", new() {
ssCode = "MAPS-GEN-10001",
ssMessage = "The specified SearchPlaces property is not supported: ",
}},
{"MAPS-CFG-10002", new() {
ssCode = "MAPS-CFG-10002",
ssMessage = "The SearchArea from SearchPlaces needs to have 4 valid locations.",
}},

    };

    protected override Dictionary<string, Dictionary<string, EN_ddceb9a0506316e12e8b49777be81ba4EntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

