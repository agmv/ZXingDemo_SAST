using System.Diagnostics;
namespace ssOutSystemsUI {

public sealed partial class ENDeviceResponsiveEntity {
private static readonly ActivitySource activitySource = new(typeof(ENDeviceResponsiveEntity).Namespace);
private static readonly System.Collections.Generic.Dictionary<string,string> entityAttributes = new() {{"type", "type"}, {"order", "order"}, {"is_active", "is_active"}};
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
} // ENDeviceResponsiveEntity
partial class ENDeviceResponsiveEntity : InMemoryStaticEntityRuntime<EN_ede7f8abbe990a3b2c1a9cfd79dc5b0fEntityRecord, string> {
    

    private static ENDeviceResponsiveEntity instance = new();
    public static ENDeviceResponsiveEntity GetInstance() => instance;

    public static EN_ede7f8abbe990a3b2c1a9cfd79dc5b0fEntityRecord GetRecordById(string id) {
return instance.GetRecord(id);
}

    public static EN_ede7f8abbe990a3b2c1a9cfd79dc5b0fEntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, string> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("RzBTCtanl0i_shQAR7j8zQ"), "DesktopAndTablet" },
{ ObjectKey.Parse("sMpkQQV7pEOceOgaU0MafQ"), "TabletOnly" },
{ ObjectKey.Parse("bu+DUtqEsUK5N176DuGmsA"), "AllDevices" },
{ ObjectKey.Parse("fphxppR7KkaWhea8+JBFTg"), "PhoneOnly" },
{ ObjectKey.Parse("0oZP4CZs20eeU0NOtjhkmA"), "TabletAndPhone" },
{ ObjectKey.Parse("9UHt66z7I0+a4EKcLkOf8g"), "DesktopOnly" },

    };

    protected override Dictionary<string, EN_ede7f8abbe990a3b2c1a9cfd79dc5b0fEntityRecord> RecordIdToRecordMap { get; } = new() {
        {"DesktopAndTablet", new() {
ssType = "DesktopAndTablet",
ssOrder = 2,
ssIs_Active = true,
}},
{"TabletOnly", new() {
ssType = "TabletOnly",
ssOrder = 3,
ssIs_Active = true,
}},
{"AllDevices", new() {
ssType = "AllDevices",
ssOrder = 6,
ssIs_Active = true,
}},
{"PhoneOnly", new() {
ssType = "PhoneOnly",
ssOrder = 5,
ssIs_Active = true,
}},
{"TabletAndPhone", new() {
ssType = "TabletAndPhone",
ssOrder = 4,
ssIs_Active = true,
}},
{"DesktopOnly", new() {
ssType = "DesktopOnly",
ssOrder = 1,
ssIs_Active = true,
}},

    };

    protected override Dictionary<string, Dictionary<string, EN_ede7f8abbe990a3b2c1a9cfd79dc5b0fEntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

