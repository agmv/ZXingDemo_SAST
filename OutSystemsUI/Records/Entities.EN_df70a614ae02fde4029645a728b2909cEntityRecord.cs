using System.Diagnostics;
namespace ssOutSystemsUI {

public sealed partial class ENRegisteredCallbackEventsEntity {
private static readonly ActivitySource activitySource = new(typeof(ENRegisteredCallbackEventsEntity).Namespace);
private static readonly System.Collections.Generic.Dictionary<string,string> entityAttributes = new() {{"name", "name"}};
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
} // ENRegisteredCallbackEventsEntity
partial class ENRegisteredCallbackEventsEntity : InMemoryStaticEntityRuntime<EN_df70a614ae02fde4029645a728b2909cEntityRecord, string> {
    

    private static ENRegisteredCallbackEventsEntity instance = new();
    public static ENRegisteredCallbackEventsEntity GetInstance() => instance;

    public static EN_df70a614ae02fde4029645a728b2909cEntityRecord GetRecordById(string id) {
return instance.GetRecord(id);
}

    public static EN_df70a614ae02fde4029645a728b2909cEntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, string> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("Mt6TCwUy0EK4dKuvySIcCQ"), "OnSlideMoved" },
{ ObjectKey.Parse("6lL_JO3cGkKbqcwK3mSNzg"), "OnChange" },
{ ObjectKey.Parse("hr19ZdQjMkGazAHJ99R+1w"), "Initialized" },
{ ObjectKey.Parse("iXuVthzNp0qii3htvMFnyw"), "OnValueChange" },
{ ObjectKey.Parse("xGWyxTQ3A0WBEv1dSE4Wpg"), "OnSelected" },
{ ObjectKey.Parse("zluN2rDk3USHBbgmljnRPA"), "OnToggle" },

    };

    protected override Dictionary<string, EN_df70a614ae02fde4029645a728b2909cEntityRecord> RecordIdToRecordMap { get; } = new() {
        {"OnSlideMoved", new() {
ssName = "OnSlideMoved",
}},
{"OnChange", new() {
ssName = "OnChange",
}},
{"Initialized", new() {
ssName = "Initialized",
}},
{"OnValueChange", new() {
ssName = "OnValueChange",
}},
{"OnSelected", new() {
ssName = "OnSelected",
}},
{"OnToggle", new() {
ssName = "OnToggle",
}},

    };

    protected override Dictionary<string, Dictionary<string, EN_df70a614ae02fde4029645a728b2909cEntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

