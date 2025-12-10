using System.Diagnostics;
namespace ssZXingLibDemo.ReferencesProxy {

public sealed partial class ENShapeEntity {
private static readonly ActivitySource activitySource = new(typeof(ENShapeEntity).Namespace);
private static readonly System.Collections.Generic.Dictionary<string,string> entityAttributes = new() {{"shape", "shape"}, {"order", "order"}};
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
} // ENShapeEntity
/// <summary>
/// Static Entity <code>ENShapeEntity</code> gets the values for this static entity records in runtime
///  <code>Shape</code>
/// </summary>
    partial class ENShapeEntity {
        

        static ENShapeEntity() {
            // Initialization handled by record class in the main project
        }

        public static EN_d11562be18a7e40ca777aa336c946163EntityRecord GetRecordById(string id) {
return (EN_d11562be18a7e40ca777aa336c946163EntityRecord) RsseSpaceOutSystemsUI.ENShapeEntity.GetRecordById(id);
}


        public static EN_d11562be18a7e40ca777aa336c946163EntityRecord GetRecordByKey(ObjectKey key) {
return (EN_d11562be18a7e40ca777aa336c946163EntityRecord) RsseSpaceOutSystemsUI.ENShapeEntity.GetRecordByKey(key);
}

    } // ENShapeEntity;

}

