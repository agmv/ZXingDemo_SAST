using System.Diagnostics;
namespace ssOutSystemsUI {

public sealed partial class ENAccordionIconTypeEntity {
private static readonly ActivitySource activitySource = new(typeof(ENAccordionIconTypeEntity).Namespace);
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
} // ENAccordionIconTypeEntity
partial class ENAccordionIconTypeEntity : InMemoryStaticEntityRuntime<EN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord, string> {
    

    private static ENAccordionIconTypeEntity instance = new();
    public static ENAccordionIconTypeEntity GetInstance() => instance;

    public static EN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord GetRecordById(string id) {
return instance.GetRecord(id);
}

    public static EN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, string> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("I5JqWJ5e0kSUBUpRHEko7g"), "Custom" },
{ ObjectKey.Parse("UJVgpKuSO067K34fl1m17Q"), "PlusMinus" },
{ ObjectKey.Parse("CTFssVJB9U2kA+u5JjFEPA"), "Caret" },

    };

    protected override Dictionary<string, EN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord> RecordIdToRecordMap { get; } = new() {
        {"Custom", new() {
ssId = "Custom",
}},
{"PlusMinus", new() {
ssId = "PlusMinus",
}},
{"Caret", new() {
ssId = "Caret",
}},

    };

    protected override Dictionary<string, Dictionary<string, EN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

