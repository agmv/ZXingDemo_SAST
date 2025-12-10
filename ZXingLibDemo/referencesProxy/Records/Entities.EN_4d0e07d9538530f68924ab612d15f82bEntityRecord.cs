using System.Diagnostics;
namespace ssZXingLibDemo.ReferencesProxy {

public sealed partial class ENMapErrorsEntity {
private static readonly ActivitySource activitySource = new(typeof(ENMapErrorsEntity).Namespace);
private static readonly System.Collections.Generic.Dictionary<string,string> entityAttributes = new() {{"code", "code"}, {"message", "message"}};
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
} // ENMapErrorsEntity
/// <summary>
/// Static Entity <code>ENMapErrorsEntity</code> gets the values for this static entity records in
///  runtime <code>MapErrors</code>
/// </summary>
    partial class ENMapErrorsEntity {
        

        static ENMapErrorsEntity() {
            // Initialization handled by record class in the main project
        }

        public static EN_4d0e07d9538530f68924ab612d15f82bEntityRecord GetRecordById(string id) {
return (EN_4d0e07d9538530f68924ab612d15f82bEntityRecord) RsseSpaceOutSystemsMaps.ENMapErrorsEntity.GetRecordById(id);
}


        public static EN_4d0e07d9538530f68924ab612d15f82bEntityRecord GetRecordByKey(ObjectKey key) {
return (EN_4d0e07d9538530f68924ab612d15f82bEntityRecord) RsseSpaceOutSystemsMaps.ENMapErrorsEntity.GetRecordByKey(key);
}

    } // ENMapErrorsEntity;

}

