namespace ssOutSystemsUI {
/// <summary>
/// [Structure] Search_InternalConfig (qDXXIAp51Eayzpfhcrj8wg)
///  <code>ST_8ccec918bf91fdb79e42a7e1e178b4beStructure</code> that represent
/// s <code>Search_InternalConfig</code> <p>Description: Group of internal configurations for the
///  Search block. </p>
/// </summary>
// Name: Search_InternalConfig
public partial struct ST_8ccec918bf91fdb79e42a7e1e178b4beStructure : ITypedRecord<ST_8ccec918bf91fdb79e42a7e1e178b4beStructure> {
internal static readonly GlobalObjectKey IdUniqueId = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*5zz_I4_xgE6X8h1wNS+_tg");
internal static readonly GlobalObjectKey IdExtendedClass = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*wFwBDnTW9UaFK1FziA22ug");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("UniqueId")]
public string ssUniqueId;

[System.Xml.Serialization.XmlElement("ExtendedClass")]
public string ssExtendedClass;


public BitArray OptimizedAttributes;

public ST_8ccec918bf91fdb79e42a7e1e178b4beStructure() {
OptimizedAttributes = null;
ssUniqueId = "";
ssExtendedClass = "";
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[0];
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    }
}
get{
    BitArray[] all = new BitArray[0];
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssUniqueId = r.ReadText(index++, "Search_InternalConfig.UniqueId", "");
ssExtendedClass = r.ReadText(index++, "Search_InternalConfig.ExtendedClass", "");
}
/// <summary>
/// Read from database
/// </summary>
/// <param name="r"> Data reader</param>
public void ReadDB( DbDataReader r) {
int index = 0;
Read(r, ref index);
}

/// <summary>
/// Read from record
/// </summary>
/// <param name="r"> Record</param>
public void ReadIM(ST_8ccec918bf91fdb79e42a7e1e178b4beStructure r) {
this = r;
}


public static bool operator == (ST_8ccec918bf91fdb79e42a7e1e178b4beStructure a, ST_8ccec918bf91fdb79e42a7e1e178b4beStructure b) {
if (a.ssUniqueId != b.ssUniqueId) return false;
if (a.ssExtendedClass != b.ssExtendedClass) return false;
return true;
}

public static bool operator != (ST_8ccec918bf91fdb79e42a7e1e178b4beStructure a, ST_8ccec918bf91fdb79e42a7e1e178b4beStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_8ccec918bf91fdb79e42a7e1e178b4beStructure)) return false;
return (this == (ST_8ccec918bf91fdb79e42a7e1e178b4beStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssUniqueId.GetHashCode()
 ^ ssExtendedClass.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_8ccec918bf91fdb79e42a7e1e178b4beStructure Duplicate() {
ST_8ccec918bf91fdb79e42a7e1e178b4beStructure t;
t.ssUniqueId = this.ssUniqueId;
t.ssExtendedClass = this.ssExtendedClass;
t.OptimizedAttributes = null;
return t;
}

IRecord IRecord.Duplicate() {
return Duplicate();
}

public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
throw new System.InvalidOperationException();
}

public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
String head = VarValue.GetHead(fields);
String tail = VarValue.GetTail(fields);
variable.Found = false;
if (head == "uniqueid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UniqueId")) variable.Value = ssUniqueId; else variable.Optimized = true;
} else if (head == "extendedclass") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ExtendedClass")) variable.Value = ssExtendedClass; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdUniqueId) {
return ssUniqueId;
}
if (key == IdExtendedClass) {
return ssExtendedClass;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUniqueId.Key.AsGuid) {
return ssUniqueId;
}
if (attributeKey == IdExtendedClass.Key.AsGuid) {
return ssExtendedClass;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssUniqueId = (string) other.AttributeGet(IdUniqueId);
ssExtendedClass = (string) other.AttributeGet(IdExtendedClass);
}
} // ST_8ccec918bf91fdb79e42a7e1e178b4beStructure
/// <summary>
/// RecordList type <code>Search_InternalConfigList</code> that represents a record list of
///  <code>Search_InternalConfig</code>
/// </summary>
public partial class RL_e3429d51e0fc95e173d2cbcfc5f6b446 : GenericRecordList<ST_8ccec918bf91fdb79e42a7e1e178b4beStructure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_8ccec918bf91fdb79e42a7e1e178b4beStructure GetElementDefaultValue() {
return new ST_8ccec918bf91fdb79e42a7e1e178b4beStructure();
}

public T[] ToArray<T>(Func<ST_8ccec918bf91fdb79e42a7e1e178b4beStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_e3429d51e0fc95e173d2cbcfc5f6b446 recordList, Func<ST_8ccec918bf91fdb79e42a7e1e178b4beStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_e3429d51e0fc95e173d2cbcfc5f6b446(ST_8ccec918bf91fdb79e42a7e1e178b4beStructure[] array) {
  RL_e3429d51e0fc95e173d2cbcfc5f6b446 result = new RL_e3429d51e0fc95e173d2cbcfc5f6b446();
result.InnerFromArray(array);
    return result;
}

public static RL_e3429d51e0fc95e173d2cbcfc5f6b446 ToList<T>(T[] array, Func <T, ST_8ccec918bf91fdb79e42a7e1e178b4beStructure> converter) {
  RL_e3429d51e0fc95e173d2cbcfc5f6b446 result = new RL_e3429d51e0fc95e173d2cbcfc5f6b446();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_e3429d51e0fc95e173d2cbcfc5f6b446 FromRestList<T>(RestList<T> restList, Func <T, ST_8ccec918bf91fdb79e42a7e1e178b4beStructure> converter) {
  RL_e3429d51e0fc95e173d2cbcfc5f6b446 result = new RL_e3429d51e0fc95e173d2cbcfc5f6b446();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_e3429d51e0fc95e173d2cbcfc5f6b446() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_8ccec918bf91fdb79e42a7e1e178b4beStructure> NewList() {
return new RL_e3429d51e0fc95e173d2cbcfc5f6b446();
}


} // RL_e3429d51e0fc95e173d2cbcfc5f6b446
}

