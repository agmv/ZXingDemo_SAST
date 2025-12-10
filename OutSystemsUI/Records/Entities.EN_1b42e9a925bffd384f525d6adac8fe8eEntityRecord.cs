using System.Diagnostics;
namespace ssOutSystemsUI {

public sealed partial class ENDatePickerWeekDayEntity {
private static readonly ActivitySource activitySource = new(typeof(ENDatePickerWeekDayEntity).Namespace);
private static readonly System.Collections.Generic.Dictionary<string,string> entityAttributes = new() {{"weekday", "weekday"}};
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
} // ENDatePickerWeekDayEntity
partial class ENDatePickerWeekDayEntity : InMemoryStaticEntityRuntime<EN_1b42e9a925bffd384f525d6adac8fe8eEntityRecord, int> {
    

    private static ENDatePickerWeekDayEntity instance = new();
    public static ENDatePickerWeekDayEntity GetInstance() => instance;

    public static EN_1b42e9a925bffd384f525d6adac8fe8eEntityRecord GetRecordById(int id) {
return instance.GetRecord(id);
}

    public static EN_1b42e9a925bffd384f525d6adac8fe8eEntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, int> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("r1bGL8k1yEyU9815cOWv5A"), 1 },
{ ObjectKey.Parse("QYZ1Ve1Qk0q7OahsAuh4LA"), 6 },
{ ObjectKey.Parse("0CEPV769vkukUgLjN29p2A"), 0 },
{ ObjectKey.Parse("W3zsh+xSrk2C4_bwjt06Lg"), 5 },
{ ObjectKey.Parse("IhedxbHLO0WaKU+7JGdWzQ"), 2 },
{ ObjectKey.Parse("ChJs8GjDaEWSFkL3yKYNjA"), 4 },
{ ObjectKey.Parse("lbic8WSn4ESQ6AC6y4ThNA"), 3 },

    };

    protected override Dictionary<int, EN_1b42e9a925bffd384f525d6adac8fe8eEntityRecord> RecordIdToRecordMap { get; } = new() {
        {1, new() {
ssWeekDay = 1,
}},
{6, new() {
ssWeekDay = 6,
}},
{0, new() {
ssWeekDay = 0,
}},
{5, new() {
ssWeekDay = 5,
}},
{2, new() {
ssWeekDay = 2,
}},
{4, new() {
ssWeekDay = 4,
}},
{3, new() {
ssWeekDay = 3,
}},

    };

    protected override Dictionary<string, Dictionary<int, EN_1b42e9a925bffd384f525d6adac8fe8eEntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

