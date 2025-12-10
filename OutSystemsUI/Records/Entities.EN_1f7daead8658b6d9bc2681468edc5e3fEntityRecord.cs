using System.Diagnostics;
namespace ssOutSystemsUI {

public sealed partial class ENDropdownProviderEntity {
private static readonly ActivitySource activitySource = new(typeof(ENDropdownProviderEntity).Namespace);
private static readonly System.Collections.Generic.Dictionary<string,string> entityAttributes = new() {{"provider", "provider"}};
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
} // ENDropdownProviderEntity
partial class ENDropdownProviderEntity : InMemoryStaticEntityRuntime<EN_1f7daead8658b6d9bc2681468edc5e3fEntityRecord, string> {
    

    private static ENDropdownProviderEntity instance = new();
    public static ENDropdownProviderEntity GetInstance() => instance;

    public static EN_1f7daead8658b6d9bc2681468edc5e3fEntityRecord GetRecordById(string id) {
return instance.GetRecord(id);
}

    public static EN_1f7daead8658b6d9bc2681468edc5e3fEntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, string> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("B_wikZzD9kWDRwuE6mC+HA"), "osui-components" },
{ ObjectKey.Parse("+fzt85lXL0eBiJN3JGGaVw"), "virtual-select" },

    };

    protected override Dictionary<string, EN_1f7daead8658b6d9bc2681468edc5e3fEntityRecord> RecordIdToRecordMap { get; } = new() {
        {"osui-components", new() {
ssProvider = "osui-components",
}},
{"virtual-select", new() {
ssProvider = "virtual-select",
}},

    };

    protected override Dictionary<string, Dictionary<string, EN_1f7daead8658b6d9bc2681468edc5e3fEntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

