using System.Diagnostics;
namespace ssOutSystemsUI {

public sealed partial class ENTriggerEntity {
private static readonly ActivitySource activitySource = new(typeof(ENTriggerEntity).Namespace);
private static readonly System.Collections.Generic.Dictionary<string,string> entityAttributes = new() {{"trigger", "trigger"}};
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
} // ENTriggerEntity
partial class ENTriggerEntity : InMemoryStaticEntityRuntime<EN_52e55d60c515b6016f81404afb220594EntityRecord, string> {
    

    private static ENTriggerEntity instance = new();
    public static ENTriggerEntity GetInstance() => instance;

    public static EN_52e55d60c515b6016f81404afb220594EntityRecord GetRecordById(string id) {
return instance.GetRecord(id);
}

    public static EN_52e55d60c515b6016f81404afb220594EntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, string> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("rbv6GR3Ao0G9u_Tx2HuAQg"), "onclick" },
{ ObjectKey.Parse("caQKtlYV30a8FVhVQ6KgXQ"), "onhover" },

    };

    protected override Dictionary<string, EN_52e55d60c515b6016f81404afb220594EntityRecord> RecordIdToRecordMap { get; } = new() {
        {"onclick", new() {
ssTrigger = "onclick",
}},
{"onhover", new() {
ssTrigger = "onhover",
}},

    };

    protected override Dictionary<string, Dictionary<string, EN_52e55d60c515b6016f81404afb220594EntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

