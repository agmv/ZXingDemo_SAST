namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (jGYe4jYYEUqpJHz8p+KjgA)
///  <code>RC_3dc2f7b3c292c64f7476a99f4086df98</code> that represent
/// s <code>Search_InternalConfigRecord</code> <p>Description: </p>
/// </summary>
// Name: Search_InternalConfigRecord
public partial struct RC_3dc2f7b3c292c64f7476a99f4086df98 : ITypedRecord<RC_3dc2f7b3c292c64f7476a99f4086df98> {
internal static readonly GlobalObjectKey IdSearch_InternalConfig = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*s_fCPZLCT8Z0dqmfQIbfmA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Search_InternalConfig")]
public ST_8ccec918bf91fdb79e42a7e1e178b4beStructure ssSTSearch_InternalConfig;


public static implicit operator ST_8ccec918bf91fdb79e42a7e1e178b4beStructure( RC_3dc2f7b3c292c64f7476a99f4086df98 r) {
return r.ssSTSearch_InternalConfig;
}

public static implicit operator RC_3dc2f7b3c292c64f7476a99f4086df98 (ST_8ccec918bf91fdb79e42a7e1e178b4beStructure r) {
RC_3dc2f7b3c292c64f7476a99f4086df98 res = new RC_3dc2f7b3c292c64f7476a99f4086df98 ();
res.ssSTSearch_InternalConfig = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_3dc2f7b3c292c64f7476a99f4086df98() {
OptimizedAttributes = null;
ssSTSearch_InternalConfig = new ST_8ccec918bf91fdb79e42a7e1e178b4beStructure();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    ssSTSearch_InternalConfig.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssSTSearch_InternalConfig.Read( r, ref index);
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
public void ReadIM(RC_3dc2f7b3c292c64f7476a99f4086df98 r) {
this = r;
}


public static bool operator == (RC_3dc2f7b3c292c64f7476a99f4086df98 a, RC_3dc2f7b3c292c64f7476a99f4086df98 b) {
if (a.ssSTSearch_InternalConfig != b.ssSTSearch_InternalConfig) return false;
return true;
}

public static bool operator != (RC_3dc2f7b3c292c64f7476a99f4086df98 a, RC_3dc2f7b3c292c64f7476a99f4086df98 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_3dc2f7b3c292c64f7476a99f4086df98)) return false;
return (this == (RC_3dc2f7b3c292c64f7476a99f4086df98)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTSearch_InternalConfig.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTSearch_InternalConfig.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTSearch_InternalConfig.InternalRecursiveSave();
}


public RC_3dc2f7b3c292c64f7476a99f4086df98 Duplicate() {
RC_3dc2f7b3c292c64f7476a99f4086df98 t;
t.ssSTSearch_InternalConfig = (ST_8ccec918bf91fdb79e42a7e1e178b4beStructure)this.ssSTSearch_InternalConfig.Duplicate();
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
if (head == "search_internalconfig") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Search_InternalConfig")) variable.Value = ssSTSearch_InternalConfig; else variable.Optimized = true;
variable.SetFieldName("search_internalconfig");
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
if (key == IdSearch_InternalConfig) {
return ssSTSearch_InternalConfig;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdSearch_InternalConfig.Key.AsGuid) {
return ssSTSearch_InternalConfig;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTSearch_InternalConfig.FillFromOther((IRecord) other.AttributeGet(IdSearch_InternalConfig));
}
} // RC_3dc2f7b3c292c64f7476a99f4086df98
/// <summary>
/// RecordList type <code>Search_InternalConfigRecordList</code> that represents a record list of
///  <code>Search_InternalConfig</code>
/// </summary>
public partial class RL_b90257b403297564a341dbb0631e7230 : GenericRecordList<RC_3dc2f7b3c292c64f7476a99f4086df98>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_3dc2f7b3c292c64f7476a99f4086df98 GetElementDefaultValue() {
return new RC_3dc2f7b3c292c64f7476a99f4086df98();
}

public T[] ToArray<T>(Func<RC_3dc2f7b3c292c64f7476a99f4086df98, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_b90257b403297564a341dbb0631e7230 recordList, Func<RC_3dc2f7b3c292c64f7476a99f4086df98, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_b90257b403297564a341dbb0631e7230(RC_3dc2f7b3c292c64f7476a99f4086df98[] array) {
  RL_b90257b403297564a341dbb0631e7230 result = new RL_b90257b403297564a341dbb0631e7230();
result.InnerFromArray(array);
    return result;
}

public static RL_b90257b403297564a341dbb0631e7230 ToList<T>(T[] array, Func <T, RC_3dc2f7b3c292c64f7476a99f4086df98> converter) {
  RL_b90257b403297564a341dbb0631e7230 result = new RL_b90257b403297564a341dbb0631e7230();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_b90257b403297564a341dbb0631e7230 FromRestList<T>(RestList<T> restList, Func <T, RC_3dc2f7b3c292c64f7476a99f4086df98> converter) {
  RL_b90257b403297564a341dbb0631e7230 result = new RL_b90257b403297564a341dbb0631e7230();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_b90257b403297564a341dbb0631e7230() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = null;
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_3dc2f7b3c292c64f7476a99f4086df98> NewList() {
return new RL_b90257b403297564a341dbb0631e7230();
}


} // RL_b90257b403297564a341dbb0631e7230
}

