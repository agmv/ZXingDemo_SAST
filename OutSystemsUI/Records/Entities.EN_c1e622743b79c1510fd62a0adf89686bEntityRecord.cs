using System.Diagnostics;
namespace ssOutSystemsUI {

public sealed partial class ENSideMenuBehaviorEntity {
private static readonly ActivitySource activitySource = new(typeof(ENSideMenuBehaviorEntity).Namespace);
private static readonly System.Collections.Generic.Dictionary<string,string> entityAttributes = new() {{"sidemenubehavior", "sidemenubehavior"}};
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
} // ENSideMenuBehaviorEntity
partial class ENSideMenuBehaviorEntity : InMemoryStaticEntityRuntime<EN_c1e622743b79c1510fd62a0adf89686bEntityRecord, string> {
    

    private static ENSideMenuBehaviorEntity instance = new();
    public static ENSideMenuBehaviorEntity GetInstance() => instance;

    public static EN_c1e622743b79c1510fd62a0adf89686bEntityRecord GetRecordById(string id) {
return instance.GetRecord(id);
}

    public static EN_c1e622743b79c1510fd62a0adf89686bEntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, string> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("N1O5JeVhx0yVoPsr7iLHXw"), "aside-visible" },
{ ObjectKey.Parse("aVKT2zd6qkCJi+F+VGqTKg"), "aside-expandable" },
{ ObjectKey.Parse("Br6U8TUB_Eqb4j+afs0QfA"), "aside-overlay" },

    };

    protected override Dictionary<string, EN_c1e622743b79c1510fd62a0adf89686bEntityRecord> RecordIdToRecordMap { get; } = new() {
        {"aside-visible", new() {
ssSideMenuBehavior = "aside-visible",
}},
{"aside-expandable", new() {
ssSideMenuBehavior = "aside-expandable",
}},
{"aside-overlay", new() {
ssSideMenuBehavior = "aside-overlay",
}},

    };

    protected override Dictionary<string, Dictionary<string, EN_c1e622743b79c1510fd62a0adf89686bEntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

