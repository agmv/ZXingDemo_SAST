using System.Diagnostics;
namespace ssZXingLibDemo.ReferencesProxy {

public sealed partial class ENTriggerEntity {
private static readonly ActivitySource activitySource = new(typeof(ENTriggerEntity).Namespace);
private static readonly System.Collections.Generic.Dictionary<string,string> entityAttributes = new() {{"trigger", "trigger"}};
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
} // ENTriggerEntity
/// <summary>
/// Static Entity <code>ENTriggerEntity</code> gets the values for this static entity records in
///  runtime <code>Trigger</code>
/// </summary>
    partial class ENTriggerEntity {
        

        static ENTriggerEntity() {
            // Initialization handled by record class in the main project
        }

        public static EN_52e55d60c515b6016f81404afb220594EntityRecord GetRecordById(string id) {
return (EN_52e55d60c515b6016f81404afb220594EntityRecord) RsseSpaceOutSystemsUI.ENTriggerEntity.GetRecordById(id);
}


        public static EN_52e55d60c515b6016f81404afb220594EntityRecord GetRecordByKey(ObjectKey key) {
return (EN_52e55d60c515b6016f81404afb220594EntityRecord) RsseSpaceOutSystemsUI.ENTriggerEntity.GetRecordByKey(key);
}

    } // ENTriggerEntity;

}

