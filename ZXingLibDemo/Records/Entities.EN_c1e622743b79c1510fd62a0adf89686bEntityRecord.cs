using System.Diagnostics;
namespace ssZXingLibDemo {

public sealed partial class ENSideMenuBehaviorEntity {
private static readonly ActivitySource activitySource = new(typeof(ENSideMenuBehaviorEntity).Namespace);
private static readonly System.Collections.Generic.Dictionary<string,string> entityAttributes = new() {{"sidemenubehavior", "sidemenubehavior"}};
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
} // ENSideMenuBehaviorEntity
/// <summary>
/// Static Entity <code>ENSideMenuBehaviorEntity</code> gets the values for this static entity records
///  in runtime <code>SideMenuBehavior</code>
/// </summary>
    partial class ENSideMenuBehaviorEntity {
        

        static ENSideMenuBehaviorEntity() {
            EN_c1e622743b79c1510fd62a0adf89686bEntityRecordTypeFactoryImpl.InitializeFactory();
        }

        public static EN_c1e622743b79c1510fd62a0adf89686bEntityRecord GetRecordById(string id) {
return (EN_c1e622743b79c1510fd62a0adf89686bEntityRecord) RsseSpaceOutSystemsUI.ENSideMenuBehaviorEntity.GetRecordById(id);
}


        public static EN_c1e622743b79c1510fd62a0adf89686bEntityRecord GetRecordByKey(ObjectKey key) {
return (EN_c1e622743b79c1510fd62a0adf89686bEntityRecord) RsseSpaceOutSystemsUI.ENSideMenuBehaviorEntity.GetRecordByKey(key);
}

    } // ENSideMenuBehaviorEntity;

}

