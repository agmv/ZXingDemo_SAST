using System.Diagnostics;
namespace ssZXingLibDemo {

public sealed partial class ENBreakColumnsEntity {
private static readonly ActivitySource activitySource = new(typeof(ENBreakColumnsEntity).Namespace);
private static readonly System.Collections.Generic.Dictionary<string,string> entityAttributes = new() {{"breakcolumns", "breakcolumns"}};
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
} // ENBreakColumnsEntity
/// <summary>
/// Static Entity <code>ENBreakColumnsEntity</code> gets the values for this static entity records in
///  runtime <code>BreakColumns</code>
/// </summary>
    partial class ENBreakColumnsEntity {
        

        static ENBreakColumnsEntity() {
            EN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecordTypeFactoryImpl.InitializeFactory();
        }

        public static EN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord GetRecordById(string id) {
return (EN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord) RsseSpaceOutSystemsUI.ENBreakColumnsEntity.GetRecordById(id);
}


        public static EN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord GetRecordByKey(ObjectKey key) {
return (EN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord) RsseSpaceOutSystemsUI.ENBreakColumnsEntity.GetRecordByKey(key);
}

    } // ENBreakColumnsEntity;

}

