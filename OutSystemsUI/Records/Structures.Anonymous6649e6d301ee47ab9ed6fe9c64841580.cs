namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (0+ZJZu4Bq0ee1v6cZIQVgA)
///  <code>RC_f52343ea94aab4a44927e9cbc0e79a19</code> that represent
/// s <code>Notification_InternalConfigRecord</code> <p>Description: </p>
/// </summary>
// Name: Notification_InternalConfigRecord
public partial struct RC_f52343ea94aab4a44927e9cbc0e79a19 : ITypedRecord<RC_f52343ea94aab4a44927e9cbc0e79a19> {
internal static readonly GlobalObjectKey IdNotification_InternalConfig = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*6kMj9aqUpLRJJ+nLwOeaGQ");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Notification_InternalConfig")]
public ST_46bd5f77d899939eaf145ae01d3efd6bStructure ssSTNotification_InternalConfig;


public static implicit operator ST_46bd5f77d899939eaf145ae01d3efd6bStructure( RC_f52343ea94aab4a44927e9cbc0e79a19 r) {
return r.ssSTNotification_InternalConfig;
}

public static implicit operator RC_f52343ea94aab4a44927e9cbc0e79a19 (ST_46bd5f77d899939eaf145ae01d3efd6bStructure r) {
RC_f52343ea94aab4a44927e9cbc0e79a19 res = new RC_f52343ea94aab4a44927e9cbc0e79a19 ();
res.ssSTNotification_InternalConfig = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_f52343ea94aab4a44927e9cbc0e79a19() {
OptimizedAttributes = null;
ssSTNotification_InternalConfig = new ST_46bd5f77d899939eaf145ae01d3efd6bStructure();
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
    ssSTNotification_InternalConfig.OptimizedAttributes = value[0];
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
ssSTNotification_InternalConfig.Read( r, ref index);
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
public void ReadIM(RC_f52343ea94aab4a44927e9cbc0e79a19 r) {
this = r;
}


public static bool operator == (RC_f52343ea94aab4a44927e9cbc0e79a19 a, RC_f52343ea94aab4a44927e9cbc0e79a19 b) {
if (a.ssSTNotification_InternalConfig != b.ssSTNotification_InternalConfig) return false;
return true;
}

public static bool operator != (RC_f52343ea94aab4a44927e9cbc0e79a19 a, RC_f52343ea94aab4a44927e9cbc0e79a19 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_f52343ea94aab4a44927e9cbc0e79a19)) return false;
return (this == (RC_f52343ea94aab4a44927e9cbc0e79a19)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTNotification_InternalConfig.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTNotification_InternalConfig.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTNotification_InternalConfig.InternalRecursiveSave();
}


public RC_f52343ea94aab4a44927e9cbc0e79a19 Duplicate() {
RC_f52343ea94aab4a44927e9cbc0e79a19 t;
t.ssSTNotification_InternalConfig = (ST_46bd5f77d899939eaf145ae01d3efd6bStructure)this.ssSTNotification_InternalConfig.Duplicate();
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
if (head == "notification_internalconfig") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Notification_InternalConfig")) variable.Value = ssSTNotification_InternalConfig; else variable.Optimized = true;
variable.SetFieldName("notification_internalconfig");
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
if (key == IdNotification_InternalConfig) {
return ssSTNotification_InternalConfig;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdNotification_InternalConfig.Key.AsGuid) {
return ssSTNotification_InternalConfig;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTNotification_InternalConfig.FillFromOther((IRecord) other.AttributeGet(IdNotification_InternalConfig));
}
} // RC_f52343ea94aab4a44927e9cbc0e79a19
/// <summary>
/// RecordList type <code>Notification_InternalConfigRecordList</code> that represents a record list of
///  <code>Notification_InternalConfig</code>
/// </summary>
public partial class RL_8b3d3d8dfdc8305db5da1ea630a7c3be : GenericRecordList<RC_f52343ea94aab4a44927e9cbc0e79a19>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_f52343ea94aab4a44927e9cbc0e79a19 GetElementDefaultValue() {
return new RC_f52343ea94aab4a44927e9cbc0e79a19();
}

public T[] ToArray<T>(Func<RC_f52343ea94aab4a44927e9cbc0e79a19, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_8b3d3d8dfdc8305db5da1ea630a7c3be recordList, Func<RC_f52343ea94aab4a44927e9cbc0e79a19, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_8b3d3d8dfdc8305db5da1ea630a7c3be(RC_f52343ea94aab4a44927e9cbc0e79a19[] array) {
  RL_8b3d3d8dfdc8305db5da1ea630a7c3be result = new RL_8b3d3d8dfdc8305db5da1ea630a7c3be();
result.InnerFromArray(array);
    return result;
}

public static RL_8b3d3d8dfdc8305db5da1ea630a7c3be ToList<T>(T[] array, Func <T, RC_f52343ea94aab4a44927e9cbc0e79a19> converter) {
  RL_8b3d3d8dfdc8305db5da1ea630a7c3be result = new RL_8b3d3d8dfdc8305db5da1ea630a7c3be();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_8b3d3d8dfdc8305db5da1ea630a7c3be FromRestList<T>(RestList<T> restList, Func <T, RC_f52343ea94aab4a44927e9cbc0e79a19> converter) {
  RL_8b3d3d8dfdc8305db5da1ea630a7c3be result = new RL_8b3d3d8dfdc8305db5da1ea630a7c3be();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_8b3d3d8dfdc8305db5da1ea630a7c3be() : base() {
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
protected override OSList<RC_f52343ea94aab4a44927e9cbc0e79a19> NewList() {
return new RL_8b3d3d8dfdc8305db5da1ea630a7c3be();
}


} // RL_8b3d3d8dfdc8305db5da1ea630a7c3be
}

