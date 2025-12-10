using System.Diagnostics;
namespace ssZXingLibDemo.ReferencesProxy {

public sealed partial class ENDirectionEntity {
private static readonly ActivitySource activitySource = new(typeof(ENDirectionEntity).Namespace);
private static readonly System.Collections.Generic.Dictionary<string,string> entityAttributes = new() {{"direction", "direction"}, {"order", "order"}};
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
} // ENDirectionEntity
/// <summary>
/// Static Entity <code>ENDirectionEntity</code> gets the values for this static entity records in
///  runtime <code>Direction</code>
/// </summary>
    partial class ENDirectionEntity {
        

        static ENDirectionEntity() {
            // Initialization handled by record class in the main project
        }

        public static EN_50814454e481dd1773c2250bc248da5eEntityRecord GetRecordById(string id) {
return (EN_50814454e481dd1773c2250bc248da5eEntityRecord) RsseSpaceOutSystemsUI.ENDirectionEntity.GetRecordById(id);
}


        public static EN_50814454e481dd1773c2250bc248da5eEntityRecord GetRecordByKey(ObjectKey key) {
return (EN_50814454e481dd1773c2250bc248da5eEntityRecord) RsseSpaceOutSystemsUI.ENDirectionEntity.GetRecordByKey(key);
}

    } // ENDirectionEntity;

}

