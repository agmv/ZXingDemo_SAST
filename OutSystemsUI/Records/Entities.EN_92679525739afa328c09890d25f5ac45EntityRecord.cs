using System.Diagnostics;
namespace ssOutSystemsUI {

public sealed partial class ENStackedCardsPositionEntity {
private static readonly ActivitySource activitySource = new(typeof(ENStackedCardsPositionEntity).Namespace);
private static readonly System.Collections.Generic.Dictionary<string,string> entityAttributes = new() {{"label", "label"}};
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
} // ENStackedCardsPositionEntity
partial class ENStackedCardsPositionEntity : InMemoryStaticEntityRuntime<EN_92679525739afa328c09890d25f5ac45EntityRecord, string> {
    

    private static ENStackedCardsPositionEntity instance = new();
    public static ENStackedCardsPositionEntity GetInstance() => instance;

    public static EN_92679525739afa328c09890d25f5ac45EntityRecord GetRecordById(string id) {
return instance.GetRecord(id);
}

    public static EN_92679525739afa328c09890d25f5ac45EntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, string> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("xtedLqe5T0CyB5o9p_sF7Q"), "Bottom" },
{ ObjectKey.Parse("j7FmV++C8UmUds+PSSSfJQ"), "Top" },
{ ObjectKey.Parse("2R7Pif22Ck6vQc_Xnbk11w"), "None" },

    };

    protected override Dictionary<string, EN_92679525739afa328c09890d25f5ac45EntityRecord> RecordIdToRecordMap { get; } = new() {
        {"Bottom", new() {
ssLabel = "Bottom",
}},
{"Top", new() {
ssLabel = "Top",
}},
{"None", new() {
ssLabel = "None",
}},

    };

    protected override Dictionary<string, Dictionary<string, EN_92679525739afa328c09890d25f5ac45EntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

