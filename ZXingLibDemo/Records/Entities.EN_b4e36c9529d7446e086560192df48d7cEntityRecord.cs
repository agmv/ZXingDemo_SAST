using System.Diagnostics;
namespace ssZXingLibDemo {

public sealed partial class ENDatePickerTimeFormatEntity {
private static readonly ActivitySource activitySource = new(typeof(ENDatePickerTimeFormatEntity).Namespace);
private static readonly System.Collections.Generic.Dictionary<string,string> entityAttributes = new() {{"timeformat", "timeformat"}};
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
} // ENDatePickerTimeFormatEntity
/// <summary>
/// Static Entity <code>ENDatePickerTimeFormatEntity</code> gets the values for this static entity
///  records in runtime <code>DatePickerTimeFormat</code>
/// </summary>
    partial class ENDatePickerTimeFormatEntity {
        

        static ENDatePickerTimeFormatEntity() {
            EN_b4e36c9529d7446e086560192df48d7cEntityRecordTypeFactoryImpl.InitializeFactory();
        }

        public static EN_b4e36c9529d7446e086560192df48d7cEntityRecord GetRecordById(string id) {
return (EN_b4e36c9529d7446e086560192df48d7cEntityRecord) RsseSpaceOutSystemsUI.ENDatePickerTimeFormatEntity.GetRecordById(id);
}


        public static EN_b4e36c9529d7446e086560192df48d7cEntityRecord GetRecordByKey(ObjectKey key) {
return (EN_b4e36c9529d7446e086560192df48d7cEntityRecord) RsseSpaceOutSystemsUI.ENDatePickerTimeFormatEntity.GetRecordByKey(key);
}

    } // ENDatePickerTimeFormatEntity;

}

