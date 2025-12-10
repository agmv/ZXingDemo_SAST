using System.Diagnostics;
namespace ssOutSystemsUI {

public sealed partial class ENColorEntity {
private static readonly ActivitySource activitySource = new(typeof(ENColorEntity).Namespace);
private static readonly System.Collections.Generic.Dictionary<string,string> entityAttributes = new() {{"color", "color"}, {"order", "order"}};
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
} // ENColorEntity
partial class ENColorEntity : InMemoryStaticEntityRuntime<EN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord, string> {
    

    private static ENColorEntity instance = new();
    public static ENColorEntity GetInstance() => instance;

    public static EN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord GetRecordById(string id) {
return instance.GetRecord(id);
}

    public static EN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, string> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("AMemBOUK1USBzjTsgdcsHA"), "neutral-9" },
{ ObjectKey.Parse("TzKBDa6B60S4Hs0n6850YA"), "grape" },
{ ObjectKey.Parse("S0U0FERNx06p7oNTUpsWIQ"), "neutral-7" },
{ ObjectKey.Parse("PolmFQ2jX0CHi+ZO_at_ew"), "neutral-10" },
{ ObjectKey.Parse("FUQlGbIIh0imzzZDO7Gt4A"), "teal" },
{ ObjectKey.Parse("v2HyHU5FoEmVHof2B3y7wQ"), "primary" },
{ ObjectKey.Parse("0efUIJbCU0i1hNKwBN359Q"), "neutral-4" },
{ ObjectKey.Parse("lYTNMY1DJUiKk8CDv28Bag"), "neutral-8" },
{ ObjectKey.Parse("Wla5R4JPnUqlQ0qqcHhTrA"), "indigo" },
{ ObjectKey.Parse("uNUgTXBVGE6TRVV3JDSprQ"), "orange" },
{ ObjectKey.Parse("UQ2yUKYJ30OqXWrjyZ8x6A"), "lime" },
{ ObjectKey.Parse("3a_tWZ4InkCi0ngpjlXg8g"), "cyan" },
{ ObjectKey.Parse("uUX1YXTg7kCohIECpW2e5w"), "secondary" },
{ ObjectKey.Parse("vF_GadxdQU6vzwOs_0DnqA"), "neutral-6" },
{ ObjectKey.Parse("mVAUgIQOAUOQKyvWqTPjGQ"), "yellow" },
{ ObjectKey.Parse("I+R3hZZCT0OcoZoYuR4MKQ"), "neutral-2" },
{ ObjectKey.Parse("DJhGmWoXRUOQ_zElI1ee8A"), "neutral-1" },
{ ObjectKey.Parse("lnJEt7XCAU2IO7SdJbHIpg"), "neutral-3" },
{ ObjectKey.Parse("2Vl8uJVKZ0WHbbl4ykE0KQ"), "transparent" },
{ ObjectKey.Parse("bjA5u4LOp0ecD6ePkv9Txg"), "violet" },
{ ObjectKey.Parse("G4u7wQkv6U++ye6yQ7kD1Q"), "blue" },
{ ObjectKey.Parse("STLWwef9OES0ydRFvPySVw"), "neutral-5" },
{ ObjectKey.Parse("9WTF1nqEVUG6hJG4Jr1nbw"), "red" },
{ ObjectKey.Parse("YBWZ6YypHkOlg7cHhA3C8w"), "pink" },
{ ObjectKey.Parse("mwnk7V9Z8EeY7Vg0FPT2vQ"), "green" },
{ ObjectKey.Parse("5UyT+zNrlkyNQLBjUnBqjQ"), "neutral-0" },

    };

    protected override Dictionary<string, EN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord> RecordIdToRecordMap { get; } = new() {
        {"neutral-9", new() {
ssColor = "neutral-9",
ssOrder = 25,
}},
{"grape", new() {
ssColor = "grape",
ssOrder = 13,
}},
{"neutral-7", new() {
ssColor = "neutral-7",
ssOrder = 23,
}},
{"neutral-10", new() {
ssColor = "neutral-10",
ssOrder = 26,
}},
{"teal", new() {
ssColor = "teal",
ssOrder = 8,
}},
{"primary", new() {
ssColor = "primary",
ssOrder = 1,
}},
{"neutral-4", new() {
ssColor = "neutral-4",
ssOrder = 20,
}},
{"neutral-8", new() {
ssColor = "neutral-8",
ssOrder = 24,
}},
{"indigo", new() {
ssColor = "indigo",
ssOrder = 11,
}},
{"orange", new() {
ssColor = "orange",
ssOrder = 4,
}},
{"lime", new() {
ssColor = "lime",
ssOrder = 6,
}},
{"cyan", new() {
ssColor = "cyan",
ssOrder = 9,
}},
{"secondary", new() {
ssColor = "secondary",
ssOrder = 2,
}},
{"neutral-6", new() {
ssColor = "neutral-6",
ssOrder = 22,
}},
{"yellow", new() {
ssColor = "yellow",
ssOrder = 5,
}},
{"neutral-2", new() {
ssColor = "neutral-2",
ssOrder = 18,
}},
{"neutral-1", new() {
ssColor = "neutral-1",
ssOrder = 17,
}},
{"neutral-3", new() {
ssColor = "neutral-3",
ssOrder = 19,
}},
{"transparent", new() {
ssColor = "transparent",
ssOrder = 15,
}},
{"violet", new() {
ssColor = "violet",
ssOrder = 12,
}},
{"blue", new() {
ssColor = "blue",
ssOrder = 10,
}},
{"neutral-5", new() {
ssColor = "neutral-5",
ssOrder = 21,
}},
{"red", new() {
ssColor = "red",
ssOrder = 3,
}},
{"pink", new() {
ssColor = "pink",
ssOrder = 14,
}},
{"green", new() {
ssColor = "green",
ssOrder = 7,
}},
{"neutral-0", new() {
ssColor = "neutral-0",
ssOrder = 16,
}},

    };

    protected override Dictionary<string, Dictionary<string, EN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

