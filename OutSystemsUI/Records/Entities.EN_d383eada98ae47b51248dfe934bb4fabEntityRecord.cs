using System.Diagnostics;
namespace ssOutSystemsUI {

public sealed partial class ENDEPRECATED_ColorEntity {
private static readonly ActivitySource activitySource = new(typeof(ENDEPRECATED_ColorEntity).Namespace);
private static readonly System.Collections.Generic.Dictionary<string,string> entityAttributes = new() {{"color", "color"}};
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
} // ENDEPRECATED_ColorEntity
partial class ENDEPRECATED_ColorEntity : InMemoryStaticEntityRuntime<EN_d383eada98ae47b51248dfe934bb4fabEntityRecord, string> {
    

    private static ENDEPRECATED_ColorEntity instance = new();
    public static ENDEPRECATED_ColorEntity GetInstance() => instance;

    public static EN_d383eada98ae47b51248dfe934bb4fabEntityRecord GetRecordById(string id) {
return instance.GetRecord(id);
}

    public static EN_d383eada98ae47b51248dfe934bb4fabEntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, string> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("E1pQBekf30qYRRE2jHTpiw"), "white" },
{ ObjectKey.Parse("5qFyB_a6jU+bY675sWvsMQ"), "blue" },
{ ObjectKey.Parse("7Sy6Js5rL0WzOnh03IDY0Q"), "black" },
{ ObjectKey.Parse("TnhpMrDW20agtVqaZO4OQQ"), "violet" },
{ ObjectKey.Parse("0GAiNKR0_USenfBQWjMCRA"), "default" },
{ ObjectKey.Parse("m18_gyUjkkuSheFKoaF8JQ"), "orange" },
{ ObjectKey.Parse("mCFolHA6jkWYiT7vEx0bAA"), "red" },
{ ObjectKey.Parse("4VHZm0zJS0OFy6TN4__mOA"), "primary-color" },
{ ObjectKey.Parse("iicArXGi3kasMJ+ZyH+XpA"), "green" },
{ ObjectKey.Parse("lOiG+UUH_UaqY3aAtf2SNA"), "grey" },

    };

    protected override Dictionary<string, EN_d383eada98ae47b51248dfe934bb4fabEntityRecord> RecordIdToRecordMap { get; } = new() {
        {"white", new() {
ssColor = "white",
}},
{"blue", new() {
ssColor = "blue",
}},
{"black", new() {
ssColor = "black",
}},
{"violet", new() {
ssColor = "violet",
}},
{"default", new() {
ssColor = "default",
}},
{"orange", new() {
ssColor = "orange",
}},
{"red", new() {
ssColor = "red",
}},
{"primary-color", new() {
ssColor = "primary-color",
}},
{"green", new() {
ssColor = "green",
}},
{"grey", new() {
ssColor = "grey",
}},

    };

    protected override Dictionary<string, Dictionary<string, EN_d383eada98ae47b51248dfe934bb4fabEntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

