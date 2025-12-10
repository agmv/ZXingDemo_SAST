using System.Diagnostics;
namespace ssOutSystemsUI {

public sealed partial class ENCarouselProviderEntity {
private static readonly ActivitySource activitySource = new(typeof(ENCarouselProviderEntity).Namespace);
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
} // ENCarouselProviderEntity
partial class ENCarouselProviderEntity : InMemoryStaticEntityRuntime<EN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord, string> {
    

    private static ENCarouselProviderEntity instance = new();
    public static ENCarouselProviderEntity GetInstance() => instance;

    public static EN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord GetRecordById(string id) {
return instance.GetRecord(id);
}

    public static EN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, string> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("Mx17Gy6+n0GqW1TBtegF3w"), "Splide" },

    };

    protected override Dictionary<string, EN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord> RecordIdToRecordMap { get; } = new() {
        {"Splide", new() {
ssProvider = "Splide",
}},

    };

    protected override Dictionary<string, Dictionary<string, EN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

