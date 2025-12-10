using System.Diagnostics;
namespace ssZXingLibDemo.ReferencesProxy {

public sealed partial class ENMapEventTriggeredEntity {
private static readonly ActivitySource activitySource = new(typeof(ENMapEventTriggeredEntity).Namespace);
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
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
} // ENMapEventTriggeredEntity
/// <summary>
/// Static Entity <code>ENMapEventTriggeredEntity</code> gets the values for this static entity records
///  in runtime <code>MapEventTriggered</code>
/// </summary>
    partial class ENMapEventTriggeredEntity {
        

        static ENMapEventTriggeredEntity() {
            // Initialization handled by record class in the main project
        }

        public static EN_2b877a58494bdf7ca89c3ea2061b88c8EntityRecord GetRecordById(string id) {
return (EN_2b877a58494bdf7ca89c3ea2061b88c8EntityRecord) RsseSpaceOutSystemsMaps.ENMapEventTriggeredEntity.GetRecordById(id);
}


        public static EN_2b877a58494bdf7ca89c3ea2061b88c8EntityRecord GetRecordByKey(ObjectKey key) {
return (EN_2b877a58494bdf7ca89c3ea2061b88c8EntityRecord) RsseSpaceOutSystemsMaps.ENMapEventTriggeredEntity.GetRecordByKey(key);
}

    } // ENMapEventTriggeredEntity;

}

