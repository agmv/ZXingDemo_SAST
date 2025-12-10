using System.Diagnostics;
namespace ssOutSystemsMaps {

public sealed partial class ENDrawingToolsPositionEntity {
private static readonly ActivitySource activitySource = new(typeof(ENDrawingToolsPositionEntity).Namespace);
private static readonly System.Collections.Generic.Dictionary<string,string> entityAttributes = new() {{"id", "id"}};
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
} // ENDrawingToolsPositionEntity
partial class ENDrawingToolsPositionEntity : InMemoryStaticEntityRuntime<EN_f6b05f1cc2ae707d67f7da7ba2f4fd22EntityRecord, string> {
    

    private static ENDrawingToolsPositionEntity instance = new();
    public static ENDrawingToolsPositionEntity GetInstance() => instance;

    public static EN_f6b05f1cc2ae707d67f7da7ba2f4fd22EntityRecord GetRecordById(string id) {
return instance.GetRecord(id);
}

    public static EN_f6b05f1cc2ae707d67f7da7ba2f4fd22EntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, string> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("AK5VDUdJKUiCyUwHhG94bw"), "TOP_RIGHT" },
{ ObjectKey.Parse("jXpYIpUqhU62k_i9ABfxVQ"), "TOP_CENTER" },
{ ObjectKey.Parse("HIbvRXOsHkm_GsE4QtRRvw"), "RIGHT_CENTER" },
{ ObjectKey.Parse("xtBlYnDgQk+UXIBTCtF7Rw"), "TOP_LEFT" },
{ ObjectKey.Parse("+h2LYhbogkKmt2iiRauE1Q"), "BOTTOM_CENTER" },
{ ObjectKey.Parse("Ay+LaRoWBkOzrHvUiPn7uQ"), "RIGHT_TOP" },
{ ObjectKey.Parse("KZn9aYBkBEqma0jdwpmcAA"), "BOTTOM_RIGHT" },
{ ObjectKey.Parse("uiJZkobe8UKddOGIccIO2w"), "BOTTOM_LEFT" },
{ ObjectKey.Parse("w557pGNiTU2X5e9z_rXCOw"), "RIGHT_BOTTOM" },
{ ObjectKey.Parse("qorr0A8in0aLb4Tsv0BAEw"), "LEFT_CENTER" },
{ ObjectKey.Parse("oCzd6eWDKE+fN3p25XnptA"), "LEFT_TOP" },
{ ObjectKey.Parse("0xLi+o8HuEyvqoQ8j6JtKg"), "LEFT_BOTTOM" },

    };

    protected override Dictionary<string, EN_f6b05f1cc2ae707d67f7da7ba2f4fd22EntityRecord> RecordIdToRecordMap { get; } = new() {
        {"TOP_RIGHT", new() {
ssId = "TOP_RIGHT",
}},
{"TOP_CENTER", new() {
ssId = "TOP_CENTER",
}},
{"RIGHT_CENTER", new() {
ssId = "RIGHT_CENTER",
}},
{"TOP_LEFT", new() {
ssId = "TOP_LEFT",
}},
{"BOTTOM_CENTER", new() {
ssId = "BOTTOM_CENTER",
}},
{"RIGHT_TOP", new() {
ssId = "RIGHT_TOP",
}},
{"BOTTOM_RIGHT", new() {
ssId = "BOTTOM_RIGHT",
}},
{"BOTTOM_LEFT", new() {
ssId = "BOTTOM_LEFT",
}},
{"RIGHT_BOTTOM", new() {
ssId = "RIGHT_BOTTOM",
}},
{"LEFT_CENTER", new() {
ssId = "LEFT_CENTER",
}},
{"LEFT_TOP", new() {
ssId = "LEFT_TOP",
}},
{"LEFT_BOTTOM", new() {
ssId = "LEFT_BOTTOM",
}},

    };

    protected override Dictionary<string, Dictionary<string, EN_f6b05f1cc2ae707d67f7da7ba2f4fd22EntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

