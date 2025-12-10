using System.Diagnostics;
namespace ssOutSystemsUI {

public sealed partial class ENStepsEntity {
private static readonly ActivitySource activitySource = new(typeof(ENStepsEntity).Namespace);
private static readonly System.Collections.Generic.Dictionary<string,string> entityAttributes = new() {{"steps", "steps"}};
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
} // ENStepsEntity
partial class ENStepsEntity : InMemoryStaticEntityRuntime<EN_7441573ccf264d27ef548a39a846bd68EntityRecord, string> {
    

    private static ENStepsEntity instance = new();
    public static ENStepsEntity GetInstance() => instance;

    public static EN_7441573ccf264d27ef548a39a846bd68EntityRecord GetRecordById(string id) {
return instance.GetRecord(id);
}

    public static EN_7441573ccf264d27ef548a39a846bd68EntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, string> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("MezpAyabBEO1MimqB32Z6g"), "next" },
{ ObjectKey.Parse("oehSVMoC8k+NdL_xUS_Eow"), "past" },
{ ObjectKey.Parse("A5ne22eD50mDAvZ1jBkIRA"), "active" },

    };

    protected override Dictionary<string, EN_7441573ccf264d27ef548a39a846bd68EntityRecord> RecordIdToRecordMap { get; } = new() {
        {"next", new() {
ssSteps = "next",
}},
{"past", new() {
ssSteps = "past",
}},
{"active", new() {
ssSteps = "active",
}},

    };

    protected override Dictionary<string, Dictionary<string, EN_7441573ccf264d27ef548a39a846bd68EntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

