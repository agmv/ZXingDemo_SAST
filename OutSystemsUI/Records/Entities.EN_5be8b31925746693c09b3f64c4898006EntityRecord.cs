using System.Diagnostics;
namespace ssOutSystemsUI {

public sealed partial class ENMonthEntity {
private static readonly ActivitySource activitySource = new(typeof(ENMonthEntity).Namespace);
private static readonly System.Collections.Generic.Dictionary<string,string> entityAttributes = new() {{"month", "month"}, {"order", "order"}};
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
} // ENMonthEntity
partial class ENMonthEntity : InMemoryStaticEntityRuntime<EN_5be8b31925746693c09b3f64c4898006EntityRecord, string> {
    

    private static ENMonthEntity instance = new();
    public static ENMonthEntity GetInstance() => instance;

    public static EN_5be8b31925746693c09b3f64c4898006EntityRecord GetRecordById(string id) {
return instance.GetRecord(id);
}

    public static EN_5be8b31925746693c09b3f64c4898006EntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, string> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("_x_LAkOhwUiJIlssVi4ZOQ"), "June" },
{ ObjectKey.Parse("bo2FKVpw_Uyp4vnca9o0bA"), "March" },
{ ObjectKey.Parse("i_8OW9+ymk6AperFFhfNww"), "December" },
{ ObjectKey.Parse("HK9sa9vqMEuW7ISyJf6xpQ"), "February" },
{ ObjectKey.Parse("MJTNdvj0DUuKct3Kw5KK6w"), "May" },
{ ObjectKey.Parse("M1ZCfIBOek+hGcIdgoIFEQ"), "April" },
{ ObjectKey.Parse("MibihkS7rUKFiQtqrdqd1A"), "November" },
{ ObjectKey.Parse("SfVviXB+r0i5ZzHqaLc4kQ"), "August" },
{ ObjectKey.Parse("9UA4jeZqmUiWDT4hU0Li4w"), "January" },
{ ObjectKey.Parse("oD5IrCNESkCmHY1rzg7jng"), "July" },
{ ObjectKey.Parse("_etYyP7Jtkm7_FfCjIlbJg"), "September" },
{ ObjectKey.Parse("VYAb4MaZlkC8fV8Mglt2kg"), "October" },

    };

    protected override Dictionary<string, EN_5be8b31925746693c09b3f64c4898006EntityRecord> RecordIdToRecordMap { get; } = new() {
        {"June", new() {
ssMonth = "June",
ssOrder = 6,
}},
{"March", new() {
ssMonth = "March",
ssOrder = 3,
}},
{"December", new() {
ssMonth = "December",
ssOrder = 12,
}},
{"February", new() {
ssMonth = "February",
ssOrder = 2,
}},
{"May", new() {
ssMonth = "May",
ssOrder = 5,
}},
{"April", new() {
ssMonth = "April",
ssOrder = 4,
}},
{"November", new() {
ssMonth = "November",
ssOrder = 11,
}},
{"August", new() {
ssMonth = "August",
ssOrder = 8,
}},
{"January", new() {
ssMonth = "January",
ssOrder = 1,
}},
{"July", new() {
ssMonth = "July",
ssOrder = 7,
}},
{"September", new() {
ssMonth = "September",
ssOrder = 9,
}},
{"October", new() {
ssMonth = "October",
ssOrder = 10,
}},

    };

    protected override Dictionary<string, Dictionary<string, EN_5be8b31925746693c09b3f64c4898006EntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

