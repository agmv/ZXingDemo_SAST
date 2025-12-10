using System.Diagnostics;
namespace ssZXingLibDemo {

public sealed partial class ENZoomEntity {
private static readonly ActivitySource activitySource = new(typeof(ENZoomEntity).Namespace);
private static readonly System.Collections.Generic.Dictionary<string,string> entityAttributes = new() {{"id", "id"}, {"label", "label"}, {"zoom", "zoom"}};
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
} // ENZoomEntity
/// <summary>
/// Static Entity <code>ENZoomEntity</code> gets the values for this static entity records in runtime
///  <code>Zoom</code>
/// </summary>
    partial class ENZoomEntity {
        

        static ENZoomEntity() {
            EN_480235a969b3f42eac91ad5813fe9bf9EntityRecordTypeFactoryImpl.InitializeFactory();
        }

        public static EN_480235a969b3f42eac91ad5813fe9bf9EntityRecord GetRecordById(int id) {
return (EN_480235a969b3f42eac91ad5813fe9bf9EntityRecord) RsseSpaceOutSystemsMaps.ENZoomEntity.GetRecordById(id);
}


        public static EN_480235a969b3f42eac91ad5813fe9bf9EntityRecord GetRecordByKey(ObjectKey key) {
return (EN_480235a969b3f42eac91ad5813fe9bf9EntityRecord) RsseSpaceOutSystemsMaps.ENZoomEntity.GetRecordByKey(key);
}

    } // ENZoomEntity;

}

