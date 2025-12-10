using System.Diagnostics;
namespace ssZXingLibDemo {

public sealed partial class ENCodeDefaultsEntity {
private static readonly ActivitySource activitySource = new(typeof(ENCodeDefaultsEntity).Namespace);
private static readonly System.Collections.Generic.Dictionary<string,string> entityAttributes = new() {{"label", "label"}, {"sample", "sample"}, {"margin", "margin"}, {"width", "width"}, {"height", "height"}};
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, "code_ic3hxschksdpz5mz9rqs7_i4");
}
} // ENCodeDefaultsEntity
partial class ENCodeDefaultsEntity : InMemoryStaticEntityRuntime<EN_8e4f4aeefdfc6896f169ba6182857006EntityRecord, string> {
    

    private static ENCodeDefaultsEntity instance = new();
    public static ENCodeDefaultsEntity GetInstance() => instance;

    public static EN_8e4f4aeefdfc6896f169ba6182857006EntityRecord GetRecordById(string id) {
return instance.GetRecord(id);
}

    public static EN_8e4f4aeefdfc6896f169ba6182857006EntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, string> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("LcsZDTa6YkiJKU__Ij6p8w"), "EAN_8" },
{ ObjectKey.Parse("VccFI56SPEKRkvS9mlbjLg"), "CODE_93" },
{ ObjectKey.Parse("kztwRk7pEk6dssrOr1MVbg"), "CODE_39" },
{ ObjectKey.Parse("6pQ1UK0SAEGOdIg3S1g1bA"), "MSI" },
{ ObjectKey.Parse("cMQtVBg22kG9Vj62oqZLNA"), "DATA_MATRIX" },
{ ObjectKey.Parse("VMMXWOJFiUyQBBPvZAx0tA"), "UPC_A" },
{ ObjectKey.Parse("ZkK+eqNSw021z8OriUdpLQ"), "AZTEC" },
{ ObjectKey.Parse("DeQJpuJi5kWAglojYT1VQA"), "UPC_E" },
{ ObjectKey.Parse("4VJSpqo1Yk6XkSQfZB8kVA"), "CODE_128" },
{ ObjectKey.Parse("+sZfq9iHnUOA87F9jW9g_g"), "EAN_13" },
{ ObjectKey.Parse("6nN9uJ32Ck21Lcuf56ewmw"), "QR_CODE" },
{ ObjectKey.Parse("_AcXz4zoDEO7FtFRZFjHtQ"), "PDF_417" },
{ ObjectKey.Parse("3cQW3IX9AUaI6XbKHKZ9RA"), "PLESSEY" },
{ ObjectKey.Parse("xYkN_Sj8Pk++E9FIUi6W6Q"), "ITF" },
{ ObjectKey.Parse("glJW_sUyBESluO5vzQpjiA"), "CODABAR" },

    };

    protected override Dictionary<string, EN_8e4f4aeefdfc6896f169ba6182857006EntityRecord> RecordIdToRecordMap { get; } = new() {
        {"EAN_8", new() {
ssLabel = "EAN_8",
ssSample = "52017063",
ssMargin = 0,
ssWidth = 200,
ssHeight = 80,
}},
{"CODE_93", new() {
ssLabel = "CODE_93",
ssSample = "CODE93",
ssMargin = 0,
ssWidth = 200,
ssHeight = 80,
}},
{"CODE_39", new() {
ssLabel = "CODE_39",
ssSample = "CODE39",
ssMargin = 0,
ssWidth = 200,
ssHeight = 80,
}},
{"MSI", new() {
ssLabel = "MSI",
ssSample = "1234567",
ssMargin = 0,
ssWidth = 200,
ssHeight = 80,
}},
{"DATA_MATRIX", new() {
ssLabel = "DATA_MATRIX",
ssSample = "ZXing rocks!",
ssMargin = 2,
ssWidth = 200,
ssHeight = 200,
}},
{"UPC_A", new() {
ssLabel = "UPC_A",
ssSample = "012345678905",
ssMargin = 6,
ssWidth = 200,
ssHeight = 80,
}},
{"AZTEC", new() {
ssLabel = "AZTEC",
ssSample = "ZXing rocks!",
ssMargin = 0,
ssWidth = 200,
ssHeight = 200,
}},
{"UPC_E", new() {
ssLabel = "UPC_E",
ssSample = "00123457",
ssMargin = 0,
ssWidth = 200,
ssHeight = 80,
}},
{"CODE_128", new() {
ssLabel = "CODE_128",
ssSample = "ZXing rocks!",
ssMargin = 0,
ssWidth = 200,
ssHeight = 80,
}},
{"EAN_13", new() {
ssLabel = "EAN_13",
ssSample = "5601009941568",
ssMargin = 6,
ssWidth = 200,
ssHeight = 80,
}},
{"QR_CODE", new() {
ssLabel = "QR_CODE",
ssSample = "ZXing rocks!",
ssMargin = 0,
ssWidth = 200,
ssHeight = 200,
}},
{"PDF_417", new() {
ssLabel = "PDF_417",
ssSample = "ZXing rocks!",
ssMargin = 0,
ssWidth = 200,
ssHeight = 200,
}},
{"PLESSEY", new() {
ssLabel = "PLESSEY",
ssSample = "1234567890ABCEDF",
ssMargin = 0,
ssWidth = 200,
ssHeight = 80,
}},
{"ITF", new() {
ssLabel = "ITF",
ssSample = "00012345678905",
ssMargin = 0,
ssWidth = 200,
ssHeight = 80,
}},
{"CODABAR", new() {
ssLabel = "CODABAR",
ssSample = "A40156B",
ssMargin = 0,
ssWidth = 200,
ssHeight = 80,
}},

    };

    protected override Dictionary<string, Dictionary<string, EN_8e4f4aeefdfc6896f169ba6182857006EntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

