using System.Diagnostics;
namespace ssOutSystemsUI {

public sealed partial class ENGutterSizeEntity {
private static readonly ActivitySource activitySource = new(typeof(ENGutterSizeEntity).Namespace);
private static readonly System.Collections.Generic.Dictionary<string,string> entityAttributes = new() {{"guttersize", "guttersize"}, {"order", "order"}};
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
} // ENGutterSizeEntity
partial class ENGutterSizeEntity : InMemoryStaticEntityRuntime<EN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord, string> {
    

    private static ENGutterSizeEntity instance = new();
    public static ENGutterSizeEntity GetInstance() => instance;

    public static EN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord GetRecordById(string id) {
return instance.GetRecord(id);
}

    public static EN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, string> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("xKR+CP+WxU+HyXDjXGH+bg"), "gutter-xxl" },
{ ObjectKey.Parse("cUOHEnf7B0ev2s3du6gRcw"), "gutter-m" },
{ ObjectKey.Parse("orJsGki0CE+6klvSTTCkIg"), "gutter-none" },
{ ObjectKey.Parse("zZ5mjSCygEu1e0cAmHc03Q"), "gutter-xl" },
{ ObjectKey.Parse("uRb4lhEl+UmOnMarT_hoPg"), "gutter-s" },
{ ObjectKey.Parse("i+fcqYcE70m1wNMFQpOBaw"), "gutter-l" },
{ ObjectKey.Parse("VJNUtywQ5kWMLrFxxvWJxQ"), "gutter-base" },
{ ObjectKey.Parse("9U1zuFd1CUalZs9cNaba3g"), "gutter-xs" },

    };

    protected override Dictionary<string, EN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord> RecordIdToRecordMap { get; } = new() {
        {"gutter-xxl", new() {
ssGutterSize = "gutter-xxl",
ssOrder = 8,
}},
{"gutter-m", new() {
ssGutterSize = "gutter-m",
ssOrder = 5,
}},
{"gutter-none", new() {
ssGutterSize = "gutter-none",
ssOrder = 1,
}},
{"gutter-xl", new() {
ssGutterSize = "gutter-xl",
ssOrder = 7,
}},
{"gutter-s", new() {
ssGutterSize = "gutter-s",
ssOrder = 3,
}},
{"gutter-l", new() {
ssGutterSize = "gutter-l",
ssOrder = 6,
}},
{"gutter-base", new() {
ssGutterSize = "gutter-base",
ssOrder = 4,
}},
{"gutter-xs", new() {
ssGutterSize = "gutter-xs",
ssOrder = 2,
}},

    };

    protected override Dictionary<string, Dictionary<string, EN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

