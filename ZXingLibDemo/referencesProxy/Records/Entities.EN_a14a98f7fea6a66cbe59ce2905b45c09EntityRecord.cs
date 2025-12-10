using System.Diagnostics;
namespace ssZXingLibDemo.ReferencesProxy {

public sealed partial class ENSizeEntity {
private static readonly ActivitySource activitySource = new(typeof(ENSizeEntity).Namespace);
private static readonly System.Collections.Generic.Dictionary<string,string> entityAttributes = new() {{"size", "size"}};
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
} // ENSizeEntity
/// <summary>
/// Static Entity <code>ENSizeEntity</code> gets the values for this static entity records in runtime
///  <code>Size</code>
/// </summary>
    partial class ENSizeEntity {
        

        static ENSizeEntity() {
            // Initialization handled by record class in the main project
        }

        public static EN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord GetRecordById(string id) {
return (EN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord) RsseSpaceOutSystemsUI.ENSizeEntity.GetRecordById(id);
}


        public static EN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord GetRecordByKey(ObjectKey key) {
return (EN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord) RsseSpaceOutSystemsUI.ENSizeEntity.GetRecordByKey(key);
}

    } // ENSizeEntity;

}

