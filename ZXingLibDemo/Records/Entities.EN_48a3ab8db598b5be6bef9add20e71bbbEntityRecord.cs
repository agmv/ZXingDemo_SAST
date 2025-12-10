using System.Diagnostics;
namespace ssZXingLibDemo {

public sealed partial class ENGutterSizeEntity {
private static readonly ActivitySource activitySource = new(typeof(ENGutterSizeEntity).Namespace);
private static readonly System.Collections.Generic.Dictionary<string,string> entityAttributes = new() {{"guttersize", "guttersize"}, {"order", "order"}};
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
} // ENGutterSizeEntity
/// <summary>
/// Static Entity <code>ENGutterSizeEntity</code> gets the values for this static entity records in
///  runtime <code>GutterSize</code>
/// </summary>
    partial class ENGutterSizeEntity {
        

        static ENGutterSizeEntity() {
            EN_48a3ab8db598b5be6bef9add20e71bbbEntityRecordTypeFactoryImpl.InitializeFactory();
        }

        public static EN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord GetRecordById(string id) {
return (EN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord) RsseSpaceOutSystemsUI.ENGutterSizeEntity.GetRecordById(id);
}


        public static EN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord GetRecordByKey(ObjectKey key) {
return (EN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord) RsseSpaceOutSystemsUI.ENGutterSizeEntity.GetRecordByKey(key);
}

    } // ENGutterSizeEntity;

}

