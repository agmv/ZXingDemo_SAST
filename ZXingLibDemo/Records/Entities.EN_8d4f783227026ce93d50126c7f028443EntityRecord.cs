using System.Diagnostics;
namespace ssZXingLibDemo {

public sealed partial class ENOrientationEntity {
private static readonly ActivitySource activitySource = new(typeof(ENOrientationEntity).Namespace);
private static readonly System.Collections.Generic.Dictionary<string,string> entityAttributes = new() {{"orientation", "orientation"}};
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
} // ENOrientationEntity
/// <summary>
/// Static Entity <code>ENOrientationEntity</code> gets the values for this static entity records in
///  runtime <code>Orientation</code>
/// </summary>
    partial class ENOrientationEntity {
        

        static ENOrientationEntity() {
            EN_8d4f783227026ce93d50126c7f028443EntityRecordTypeFactoryImpl.InitializeFactory();
        }

        public static EN_8d4f783227026ce93d50126c7f028443EntityRecord GetRecordById(string id) {
return (EN_8d4f783227026ce93d50126c7f028443EntityRecord) RsseSpaceOutSystemsUI.ENOrientationEntity.GetRecordById(id);
}


        public static EN_8d4f783227026ce93d50126c7f028443EntityRecord GetRecordByKey(ObjectKey key) {
return (EN_8d4f783227026ce93d50126c7f028443EntityRecord) RsseSpaceOutSystemsUI.ENOrientationEntity.GetRecordByKey(key);
}

    } // ENOrientationEntity;

}

