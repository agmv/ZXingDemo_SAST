using System.Diagnostics;
namespace ssZXingLibDemo.ReferencesProxy {

public sealed partial class ENSpaceEntity {
private static readonly ActivitySource activitySource = new(typeof(ENSpaceEntity).Namespace);
private static readonly System.Collections.Generic.Dictionary<string,string> entityAttributes = new() {{"space", "space"}, {"order", "order"}};
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
} // ENSpaceEntity
/// <summary>
/// Static Entity <code>ENSpaceEntity</code> gets the values for this static entity records in runtime
///  <code>Space</code>
/// </summary>
    partial class ENSpaceEntity {
        

        static ENSpaceEntity() {
            // Initialization handled by record class in the main project
        }

        public static EN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord GetRecordById(string id) {
return (EN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord) RsseSpaceOutSystemsUI.ENSpaceEntity.GetRecordById(id);
}


        public static EN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord GetRecordByKey(ObjectKey key) {
return (EN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord) RsseSpaceOutSystemsUI.ENSpaceEntity.GetRecordByKey(key);
}

    } // ENSpaceEntity;

}

