using System.Diagnostics;
namespace ssZXingLibDemo.ReferencesProxy {

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
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("8be17f2a-431c-4958-b894-c77b988a7271");
} // ENColorEntity
/// <summary>
/// Static Entity <code>ENColorEntity</code> gets the values for this static entity records in runtime
///  <code>Color</code>
/// </summary>
    partial class ENColorEntity {
        

        static ENColorEntity() {
            // Initialization handled by record class in the main project
        }

        public static EN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord GetRecordById(string id) {
return (EN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord) RsseSpaceOutSystemsUI.ENColorEntity.GetRecordById(id);
}


        public static EN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord GetRecordByKey(ObjectKey key) {
return (EN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord) RsseSpaceOutSystemsUI.ENColorEntity.GetRecordByKey(key);
}

    } // ENColorEntity;

}

