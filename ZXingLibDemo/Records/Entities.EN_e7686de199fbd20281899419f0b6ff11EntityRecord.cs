using System.Diagnostics;
namespace ssZXingLibDemo {

public sealed partial class ENStyleEntity {
private static readonly ActivitySource activitySource = new(typeof(ENStyleEntity).Namespace);
private static readonly System.Collections.Generic.Dictionary<string,string> entityAttributes = new() {{"id", "id"}, {"label", "label"}, {"order", "order"}, {"style", "style"}, {"urlstyle", "urlstyle"}, {"is_active", "is_active"}};
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
} // ENStyleEntity
/// <summary>
/// Static Entity <code>ENStyleEntity</code> gets the values for this static entity records in runtime
///  <code>Style</code>
/// </summary>
    partial class ENStyleEntity {
        

        static ENStyleEntity() {
            EN_e7686de199fbd20281899419f0b6ff11EntityRecordTypeFactoryImpl.InitializeFactory();
        }

        public static EN_e7686de199fbd20281899419f0b6ff11EntityRecord GetRecordById(int id) {
return (EN_e7686de199fbd20281899419f0b6ff11EntityRecord) RsseSpaceOutSystemsMaps.ENStyleEntity.GetRecordById(id);
}


        public static EN_e7686de199fbd20281899419f0b6ff11EntityRecord GetRecordByKey(ObjectKey key) {
return (EN_e7686de199fbd20281899419f0b6ff11EntityRecord) RsseSpaceOutSystemsMaps.ENStyleEntity.GetRecordByKey(key);
}

    } // ENStyleEntity;

}

