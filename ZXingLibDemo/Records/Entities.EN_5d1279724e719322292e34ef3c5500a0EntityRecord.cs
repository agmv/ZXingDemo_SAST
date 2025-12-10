using System.Diagnostics;
namespace ssZXingLibDemo {

public sealed partial class ENPositionEntity {
private static readonly ActivitySource activitySource = new(typeof(ENPositionEntity).Namespace);
private static readonly System.Collections.Generic.Dictionary<string,string> entityAttributes = new() {{"position", "position"}};
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
} // ENPositionEntity
/// <summary>
/// Static Entity <code>ENPositionEntity</code> gets the values for this static entity records in
///  runtime <code>Position</code>
/// </summary>
    partial class ENPositionEntity {
        

        static ENPositionEntity() {
            EN_5d1279724e719322292e34ef3c5500a0EntityRecordTypeFactoryImpl.InitializeFactory();
        }

        public static EN_5d1279724e719322292e34ef3c5500a0EntityRecord GetRecordById(string id) {
return (EN_5d1279724e719322292e34ef3c5500a0EntityRecord) RsseSpaceOutSystemsUI.ENPositionEntity.GetRecordById(id);
}


        public static EN_5d1279724e719322292e34ef3c5500a0EntityRecord GetRecordByKey(ObjectKey key) {
return (EN_5d1279724e719322292e34ef3c5500a0EntityRecord) RsseSpaceOutSystemsUI.ENPositionEntity.GetRecordByKey(key);
}

    } // ENPositionEntity;

}

