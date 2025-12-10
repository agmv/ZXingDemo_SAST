namespace ssZXingLibDemo {
/// <summary>
/// [AnonymousStructure] Record (X1kyN23AWUKcmDz1Q2sIjw)
///  <code>RC_bf75694d8016688134fa555a2fd4f5d7</code> that represent
/// s <code>MapEventTriggeredRecord</code> <p>Description: </p>
/// </summary>
// Name: MapEventTriggeredRecord
public partial struct RC_bf75694d8016688134fa555a2fd4f5d7 : ITypedRecord<RC_bf75694d8016688134fa555a2fd4f5d7> {
internal static readonly GlobalObjectKey IdMapEventTriggered = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*TWl1vxaAgWg0+lVaL9T11w");

public static void EnsureInitialized(){}

static RC_bf75694d8016688134fa555a2fd4f5d7() {
RC_bf75694d8016688134fa555a2fd4f5d7TypeFactoryImpl.InitializeFactory();
}
[System.Xml.Serialization.XmlElement("MapEventTriggered")]
public EN_2b877a58494bdf7ca89c3ea2061b88c8EntityRecord ssENMapEventTriggered;


public static implicit operator EN_2b877a58494bdf7ca89c3ea2061b88c8EntityRecord( RC_bf75694d8016688134fa555a2fd4f5d7 r) {
return r.ssENMapEventTriggered;
}

public static implicit operator RC_bf75694d8016688134fa555a2fd4f5d7 (EN_2b877a58494bdf7ca89c3ea2061b88c8EntityRecord r) {
RC_bf75694d8016688134fa555a2fd4f5d7 res = new RC_bf75694d8016688134fa555a2fd4f5d7 ();
res.ssENMapEventTriggered = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENMapEventTriggered.ChangedAttributes = value;
}
get {
    return ssENMapEventTriggered.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_bf75694d8016688134fa555a2fd4f5d7() {
OptimizedAttributes = null;
ssENMapEventTriggered = new EN_2b877a58494bdf7ca89c3ea2061b88c8EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(1,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENMapEventTriggered.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENMapEventTriggered.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENMapEventTriggered.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENMapEventTriggered.Read( r, ref index);
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
public void ReadIM(RC_bf75694d8016688134fa555a2fd4f5d7 r) {
this = r;
}


public static bool operator == (RC_bf75694d8016688134fa555a2fd4f5d7 a, RC_bf75694d8016688134fa555a2fd4f5d7 b) {
if (a.ssENMapEventTriggered != b.ssENMapEventTriggered) return false;
return true;
}

public static bool operator != (RC_bf75694d8016688134fa555a2fd4f5d7 a, RC_bf75694d8016688134fa555a2fd4f5d7 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_bf75694d8016688134fa555a2fd4f5d7)) return false;
return (this == (RC_bf75694d8016688134fa555a2fd4f5d7)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENMapEventTriggered.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENMapEventTriggered.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENMapEventTriggered.InternalRecursiveSave();
}


public RC_bf75694d8016688134fa555a2fd4f5d7 Duplicate() {
RC_bf75694d8016688134fa555a2fd4f5d7 t;
t.ssENMapEventTriggered = (EN_2b877a58494bdf7ca89c3ea2061b88c8EntityRecord)this.ssENMapEventTriggered.Duplicate();
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
if (head == "mapeventtriggered") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MapEventTriggered")) variable.Value = ssENMapEventTriggered; else variable.Optimized = true;
variable.SetFieldName("mapeventtriggered");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENMapEventTriggered.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENMapEventTriggered.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdMapEventTriggered) {
return ssENMapEventTriggered;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdMapEventTriggered.Key.AsGuid) {
return ssENMapEventTriggered;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENMapEventTriggered.FillFromOther((IRecord) other.AttributeGet(IdMapEventTriggered));
}
} // RC_bf75694d8016688134fa555a2fd4f5d7
/// <summary>
/// RecordList type <code>MapEventTriggeredRecordList</code> that represents a record list of
///  <code>MapEventTriggered</code>
/// </summary>
public partial class RL_5544cfc15f95ff239b7f04e7101e83bb : GenericRecordList<RC_bf75694d8016688134fa555a2fd4f5d7>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_bf75694d8016688134fa555a2fd4f5d7 GetElementDefaultValue() {
return new RC_bf75694d8016688134fa555a2fd4f5d7();
}

public T[] ToArray<T>(Func<RC_bf75694d8016688134fa555a2fd4f5d7, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_5544cfc15f95ff239b7f04e7101e83bb recordList, Func<RC_bf75694d8016688134fa555a2fd4f5d7, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_5544cfc15f95ff239b7f04e7101e83bb(RC_bf75694d8016688134fa555a2fd4f5d7[] array) {
  RL_5544cfc15f95ff239b7f04e7101e83bb result = new RL_5544cfc15f95ff239b7f04e7101e83bb();
result.InnerFromArray(array);
    return result;
}

public static RL_5544cfc15f95ff239b7f04e7101e83bb ToList<T>(T[] array, Func <T, RC_bf75694d8016688134fa555a2fd4f5d7> converter) {
  RL_5544cfc15f95ff239b7f04e7101e83bb result = new RL_5544cfc15f95ff239b7f04e7101e83bb();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_5544cfc15f95ff239b7f04e7101e83bb FromRestList<T>(RestList<T> restList, Func <T, RC_bf75694d8016688134fa555a2fd4f5d7> converter) {
  RL_5544cfc15f95ff239b7f04e7101e83bb result = new RL_5544cfc15f95ff239b7f04e7101e83bb();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_5544cfc15f95ff239b7f04e7101e83bb() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(1,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_bf75694d8016688134fa555a2fd4f5d7> NewList() {
return new RL_5544cfc15f95ff239b7f04e7101e83bb();
}


} // RL_5544cfc15f95ff239b7f04e7101e83bb
}

