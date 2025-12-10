using System.Diagnostics;
namespace ssOutSystemsMaps {

public sealed partial class ENPopupEventEntity {
private static readonly ActivitySource activitySource = new(typeof(ENPopupEventEntity).Namespace);
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
} // ENPopupEventEntity
partial class ENPopupEventEntity : InMemoryStaticEntityRuntime<EN_6b2476596efdad1a294f5d1a6e21f7e1EntityRecord, string> {
    

    private static ENPopupEventEntity instance = new();
    public static ENPopupEventEntity GetInstance() => instance;

    public static EN_6b2476596efdad1a294f5d1a6e21f7e1EntityRecord GetRecordById(string id) {
return instance.GetRecord(id);
}

    public static EN_6b2476596efdad1a294f5d1a6e21f7e1EntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, string> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("5HmsZ1HzDkSNvU5GgrdKYg"), "OnMouseover" },
{ ObjectKey.Parse("u7OLdUq+L0a0NZ9hnn0E1Q"), "OnMouseout" },
{ ObjectKey.Parse("LD9Kq78JPUG4Agi5CLvwtw"), "OnClick" },
{ ObjectKey.Parse("lRR3tBMhQkGszzOrSTIWNQ"), "RightClick" },
{ ObjectKey.Parse("xjW579KPC0OEQ0il2DcrBg"), "DoubleClick" },

    };

    protected override Dictionary<string, EN_6b2476596efdad1a294f5d1a6e21f7e1EntityRecord> RecordIdToRecordMap { get; } = new() {
        {"OnMouseover", new() {
ssId = "OnMouseover",
}},
{"OnMouseout", new() {
ssId = "OnMouseout",
}},
{"OnClick", new() {
ssId = "OnClick",
}},
{"RightClick", new() {
ssId = "RightClick",
}},
{"DoubleClick", new() {
ssId = "DoubleClick",
}},

    };

    protected override Dictionary<string, Dictionary<string, EN_6b2476596efdad1a294f5d1a6e21f7e1EntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

