using System.Diagnostics;
namespace ssZXingLibDemo.ReferencesProxy {

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
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("8be17f2a-431c-4958-b894-c77b988a7271");
} // ENDatePickerWeekDayEntity
/// <summary>
/// Static Entity <code>ENDatePickerWeekDayEntity</code> gets the values for this static entity records
///  in runtime <code>DatePickerWeekDay</code>
/// </summary>
    partial class ENDatePickerWeekDayEntity {
        

        static ENDatePickerWeekDayEntity() {
            // Initialization handled by record class in the main project
        }

        public static EN_1b42e9a925bffd384f525d6adac8fe8eEntityRecord GetRecordById(int id) {
return (EN_1b42e9a925bffd384f525d6adac8fe8eEntityRecord) RsseSpaceOutSystemsUI.ENDatePickerWeekDayEntity.GetRecordById(id);
}


        public static EN_1b42e9a925bffd384f525d6adac8fe8eEntityRecord GetRecordByKey(ObjectKey key) {
return (EN_1b42e9a925bffd384f525d6adac8fe8eEntityRecord) RsseSpaceOutSystemsUI.ENDatePickerWeekDayEntity.GetRecordByKey(key);
}

    } // ENDatePickerWeekDayEntity;

}

