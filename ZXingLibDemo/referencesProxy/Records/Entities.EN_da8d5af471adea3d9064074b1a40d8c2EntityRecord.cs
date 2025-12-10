using System.Diagnostics;
namespace ssZXingLibDemo.ReferencesProxy {

public sealed partial class ENTypeEntity {
private static readonly ActivitySource activitySource = new(typeof(ENTypeEntity).Namespace);
private static readonly System.Collections.Generic.Dictionary<string,string> entityAttributes = new() {{"maptype", "maptype"}, {"label", "label"}, {"order", "order"}, {"is_active", "is_active"}};
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
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
} // ENTypeEntity
/// <summary>
/// Static Entity <code>ENTypeEntity</code> gets the values for this static entity records in runtime
///  <code>Type</code>
/// </summary>
    partial class ENTypeEntity {
        

        static ENTypeEntity() {
            // Initialization handled by record class in the main project
        }

        public static EN_da8d5af471adea3d9064074b1a40d8c2EntityRecord GetRecordById(string id) {
return (EN_da8d5af471adea3d9064074b1a40d8c2EntityRecord) RsseSpaceOutSystemsMaps.ENTypeEntity.GetRecordById(id);
}


        public static EN_da8d5af471adea3d9064074b1a40d8c2EntityRecord GetRecordByKey(ObjectKey key) {
return (EN_da8d5af471adea3d9064074b1a40d8c2EntityRecord) RsseSpaceOutSystemsMaps.ENTypeEntity.GetRecordByKey(key);
}

    } // ENTypeEntity;

}

