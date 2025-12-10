using System.Diagnostics;
namespace ssOutSystemsUI {

public sealed partial class ENAnimationTypeEntity {
private static readonly ActivitySource activitySource = new(typeof(ENAnimationTypeEntity).Namespace);
private static readonly System.Collections.Generic.Dictionary<string,string> entityAttributes = new() {{"animationtype", "animationtype"}};
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
} // ENAnimationTypeEntity
partial class ENAnimationTypeEntity : InMemoryStaticEntityRuntime<EN_8aa0a121c98b5f44394f59c96ffee853EntityRecord, string> {
    

    private static ENAnimationTypeEntity instance = new();
    public static ENAnimationTypeEntity GetInstance() => instance;

    public static EN_8aa0a121c98b5f44394f59c96ffee853EntityRecord GetRecordById(string id) {
return instance.GetRecord(id);
}

    public static EN_8aa0a121c98b5f44394f59c96ffee853EntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, string> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("+ZhaLRs4+E+SGQhbw138RA"), "top-to-bottom" },
{ ObjectKey.Parse("UtM6PPxSxUOuOvjWUb+glA"), "bounce" },
{ ObjectKey.Parse("CU+BaQvCVU2wanIxpVFdLA"), "fade-in" },
{ ObjectKey.Parse("ptOPfcTq6Eq4ZRj1cRgUyw"), "scale-down" },
{ ObjectKey.Parse("iw6OiloOfECXOUlC4ccI6A"), "scale" },
{ ObjectKey.Parse("L6LisVrNqEmD4qgkcXRa6g"), "spinner" },
{ ObjectKey.Parse("GO8ct+6wm06LmFcAtsa55A"), "bottom-to-top" },
{ ObjectKey.Parse("qoqlt_bhu0uVV1+0dC71Qg"), "right-to-left" },
{ ObjectKey.Parse("cxrC9Axfnk2p5nBTtows6g"), "left-to-right" },

    };

    protected override Dictionary<string, EN_8aa0a121c98b5f44394f59c96ffee853EntityRecord> RecordIdToRecordMap { get; } = new() {
        {"top-to-bottom", new() {
ssAnimationType = "top-to-bottom",
}},
{"bounce", new() {
ssAnimationType = "bounce",
}},
{"fade-in", new() {
ssAnimationType = "fade-in",
}},
{"scale-down", new() {
ssAnimationType = "scale-down",
}},
{"scale", new() {
ssAnimationType = "scale",
}},
{"spinner", new() {
ssAnimationType = "spinner",
}},
{"bottom-to-top", new() {
ssAnimationType = "bottom-to-top",
}},
{"right-to-left", new() {
ssAnimationType = "right-to-left",
}},
{"left-to-right", new() {
ssAnimationType = "left-to-right",
}},

    };

    protected override Dictionary<string, Dictionary<string, EN_8aa0a121c98b5f44394f59c96ffee853EntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

