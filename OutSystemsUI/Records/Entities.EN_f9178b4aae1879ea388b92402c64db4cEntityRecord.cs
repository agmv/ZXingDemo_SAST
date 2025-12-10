using System.Diagnostics;
namespace ssOutSystemsUI {

public sealed partial class ENIdentityProviderEntity {
private static readonly ActivitySource activitySource = new(typeof(ENIdentityProviderEntity).Namespace);
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
} // ENIdentityProviderEntity
partial class ENIdentityProviderEntity : InMemoryStaticEntityRuntime<EN_f9178b4aae1879ea388b92402c64db4cEntityRecord, string> {
    

    private static ENIdentityProviderEntity instance = new();
    public static ENIdentityProviderEntity GetInstance() => instance;

    public static EN_f9178b4aae1879ea388b92402c64db4cEntityRecord GetRecordById(string id) {
return instance.GetRecord(id);
}

    public static EN_f9178b4aae1879ea388b92402c64db4cEntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, string> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("uiaWdsKEskWFtrVKAbC6Jg"), "facebook" },
{ ObjectKey.Parse("yH0Vu13k2EC4SCyUmzy+6w"), "google" },
{ ObjectKey.Parse("DePn_88hD0KviB2iOJeJjQ"), "apple" },

    };

    protected override Dictionary<string, EN_f9178b4aae1879ea388b92402c64db4cEntityRecord> RecordIdToRecordMap { get; } = new() {
        {"facebook", new() {
ssProvider = "facebook",
}},
{"google", new() {
ssProvider = "google",
}},
{"apple", new() {
ssProvider = "apple",
}},

    };

    protected override Dictionary<string, Dictionary<string, EN_f9178b4aae1879ea388b92402c64db4cEntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

