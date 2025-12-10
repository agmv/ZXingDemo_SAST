using System.Diagnostics;
namespace ssOutSystemsMaps {

public sealed partial class ENZoomEntity {
private static readonly ActivitySource activitySource = new(typeof(ENZoomEntity).Namespace);
private static readonly System.Collections.Generic.Dictionary<string,string> entityAttributes = new() {{"id", "id"}, {"label", "label"}, {"zoom", "zoom"}};
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
} // ENZoomEntity
partial class ENZoomEntity : InMemoryStaticEntityRuntime<EN_480235a969b3f42eac91ad5813fe9bf9EntityRecord, int> {
    

    private static ENZoomEntity instance = new();
    public static ENZoomEntity GetInstance() => instance;

    public static EN_480235a969b3f42eac91ad5813fe9bf9EntityRecord GetRecordById(int id) {
return instance.GetRecord(id);
}

    public static EN_480235a969b3f42eac91ad5813fe9bf9EntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, int> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("Ms4iCTVAY0SnWtP4tU9PlA"), 13 },
{ ObjectKey.Parse("tQP2EQ4Eik+wg3nFJnxxtg"), 9 },
{ ObjectKey.Parse("scq6FVr04k+tdrqncP3+_w"), 10 },
{ ObjectKey.Parse("8QH2K7NNSUyYRbkyYVoy8Q"), 3 },
{ ObjectKey.Parse("nRSZVGjSIEGpOIza1IRsSA"), 15 },
{ ObjectKey.Parse("XmYZehXfjU+1ydByfuDGIQ"), 20 },
{ ObjectKey.Parse("aGs_g91UvkqGEEYD6CtUJg"), 19 },
{ ObjectKey.Parse("E4G_jdVaa0GlZ1vG0IS+eg"), 7 },
{ ObjectKey.Parse("k4FXjxQwckS4UgxBxHDOjg"), 4 },
{ ObjectKey.Parse("9FvsmszYy0aQ7E9MwOkUaA"), 16 },
{ ObjectKey.Parse("83MYm_QzRkOOPO0gI_C_Jw"), 5 },
{ ObjectKey.Parse("nrc6p0kwdU60Xipr8M0jQQ"), 18 },
{ ObjectKey.Parse("4Gt4uRN+HUK_tShG3WOE5A"), 11 },
{ ObjectKey.Parse("M_B_v_cGyEykLSY0nCEtmg"), 1 },
{ ObjectKey.Parse("vRPPv+T2X0mlFKP2CPyAkg"), 8 },
{ ObjectKey.Parse("6dMXxsvr002_oLfPUKlEiQ"), 2 },
{ ObjectKey.Parse("Gnv00FYCfEGMmiX_0OYrwg"), 6 },
{ ObjectKey.Parse("vWWj4UpiJUG0hK_QXYCSCw"), 17 },
{ ObjectKey.Parse("O1ir61a7eUGCeiy3yBTkjQ"), 12 },
{ ObjectKey.Parse("jEof89V2Hk6HLonoheeZnw"), 14 },
{ ObjectKey.Parse("WLo5+5B9A0iAL7Ee_Ty8xQ"), 0 },

    };

    protected override Dictionary<int, EN_480235a969b3f42eac91ad5813fe9bf9EntityRecord> RecordIdToRecordMap { get; } = new() {
        {13, new() {
ssId = 13,
ssLabel = "Zoom 13",
ssZoom = 13,
}},
{9, new() {
ssId = 9,
ssLabel = "Zoom 9",
ssZoom = 9,
}},
{10, new() {
ssId = 10,
ssLabel = "Zoom 10 (City)",
ssZoom = 10,
}},
{3, new() {
ssId = 3,
ssLabel = "Zoom 3",
ssZoom = 3,
}},
{15, new() {
ssId = 15,
ssLabel = "Zoom 15 (Streets)",
ssZoom = 15,
}},
{20, new() {
ssId = 20,
ssLabel = "Zoom 20 (Buildings)",
ssZoom = 20,
}},
{19, new() {
ssId = 19,
ssLabel = "Zoom 19",
ssZoom = 19,
}},
{7, new() {
ssId = 7,
ssLabel = "Zoom 7",
ssZoom = 7,
}},
{4, new() {
ssId = 4,
ssLabel = "Zoom 4",
ssZoom = 4,
}},
{16, new() {
ssId = 16,
ssLabel = "Zoom 16",
ssZoom = 16,
}},
{5, new() {
ssId = 5,
ssLabel = "Zoom 5 (Continent)",
ssZoom = 5,
}},
{18, new() {
ssId = 18,
ssLabel = "Zoom 18",
ssZoom = 18,
}},
{11, new() {
ssId = 11,
ssLabel = "Zoom 11",
ssZoom = 11,
}},
{1, new() {
ssId = 1,
ssLabel = "Zoom 1 (World)",
ssZoom = 1,
}},
{8, new() {
ssId = 8,
ssLabel = "Zoom 8",
ssZoom = 8,
}},
{2, new() {
ssId = 2,
ssLabel = "Zoom 2",
ssZoom = 2,
}},
{6, new() {
ssId = 6,
ssLabel = "Zoom 6",
ssZoom = 6,
}},
{17, new() {
ssId = 17,
ssLabel = "Zoom 17",
ssZoom = 17,
}},
{12, new() {
ssId = 12,
ssLabel = "Zoom 12",
ssZoom = 12,
}},
{14, new() {
ssId = 14,
ssLabel = "Zoom 14",
ssZoom = 14,
}},
{0, new() {
ssId = 0,
ssLabel = "Auto",
ssZoom = 0,
}},

    };

    protected override Dictionary<string, Dictionary<int, EN_480235a969b3f42eac91ad5813fe9bf9EntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

