using System.Diagnostics;
namespace ssOutSystemsUI {

public sealed partial class ENAccordionIconPositionEntity {
private static readonly ActivitySource activitySource = new(typeof(ENAccordionIconPositionEntity).Namespace);
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
} // ENAccordionIconPositionEntity
partial class ENAccordionIconPositionEntity : InMemoryStaticEntityRuntime<EN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord, string> {
    

    private static ENAccordionIconPositionEntity instance = new();
    public static ENAccordionIconPositionEntity GetInstance() => instance;

    public static EN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord GetRecordById(string id) {
return instance.GetRecord(id);
}

    public static EN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, string> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("osuVAySRJUGtiNa6s5siUw"), "left" },
{ ObjectKey.Parse("j2QyhVZlO0ukLKO6CR1e_Q"), "right" },

    };

    protected override Dictionary<string, EN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord> RecordIdToRecordMap { get; } = new() {
        {"left", new() {
ssLabel = "left",
}},
{"right", new() {
ssLabel = "right",
}},

    };

    protected override Dictionary<string, Dictionary<string, EN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

