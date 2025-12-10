using System.Diagnostics;
namespace ssOutSystemsMaps {

public sealed partial class ENSearchTypesEntity {
private static readonly ActivitySource activitySource = new(typeof(ENSearchTypesEntity).Namespace);
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
} // ENSearchTypesEntity
partial class ENSearchTypesEntity : InMemoryStaticEntityRuntime<EN_2a64cd2fe4a253e65ea352434a6d389aEntityRecord, string> {
    

    private static ENSearchTypesEntity instance = new();
    public static ENSearchTypesEntity GetInstance() => instance;

    public static EN_2a64cd2fe4a253e65ea352434a6d389aEntityRecord GetRecordById(string id) {
return instance.GetRecord(id);
}

    public static EN_2a64cd2fe4a253e65ea352434a6d389aEntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, string> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("nn8le8qdPkaE9jaQje+5Qw"), "Addresses" },
{ ObjectKey.Parse("KwpyjQXax0GmlD9Ghs3iDA"), "Establishments" },
{ ObjectKey.Parse("sFuNlIUQWkagohd+o+5eOg"), "Cities" },
{ ObjectKey.Parse("MwUz143o90S8cyKczLl48Q"), "Regions" },
{ ObjectKey.Parse("9Lot4svujEeRT24MO+sJgw"), "Geocodes" },

    };

    protected override Dictionary<string, EN_2a64cd2fe4a253e65ea352434a6d389aEntityRecord> RecordIdToRecordMap { get; } = new() {
        {"Addresses", new() {
ssId = "Addresses",
}},
{"Establishments", new() {
ssId = "Establishments",
}},
{"Cities", new() {
ssId = "Cities",
}},
{"Regions", new() {
ssId = "Regions",
}},
{"Geocodes", new() {
ssId = "Geocodes",
}},

    };

    protected override Dictionary<string, Dictionary<string, EN_2a64cd2fe4a253e65ea352434a6d389aEntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

