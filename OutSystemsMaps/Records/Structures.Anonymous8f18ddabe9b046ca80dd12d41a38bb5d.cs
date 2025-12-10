namespace ssOutSystemsMaps {
/// <summary>
/// [AnonymousStructure] Record (q90Yj7DpykaA3RLUGji7XQ)
///  <code>RC_499511b992975daa9639159d76f69e74</code> that represent
/// s <code>DrawingToolsEventTriggeredRecord</code> <p>Description: </p>
/// </summary>
// Name: DrawingToolsEventTriggeredRecord
public partial struct RC_499511b992975daa9639159d76f69e74 : ITypedRecord<RC_499511b992975daa9639159d76f69e74> {
internal static readonly GlobalObjectKey IdDrawingToolsEventTriggered = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*uRGVSZeSql2WORWddvaedA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("DrawingToolsEventTriggered")]
public EN_8a068e43cce18c5870b845073fb713c1EntityRecord ssENDrawingToolsEventTriggered;


public static implicit operator EN_8a068e43cce18c5870b845073fb713c1EntityRecord( RC_499511b992975daa9639159d76f69e74 r) {
return r.ssENDrawingToolsEventTriggered;
}

public static implicit operator RC_499511b992975daa9639159d76f69e74 (EN_8a068e43cce18c5870b845073fb713c1EntityRecord r) {
RC_499511b992975daa9639159d76f69e74 res = new RC_499511b992975daa9639159d76f69e74 ();
res.ssENDrawingToolsEventTriggered = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENDrawingToolsEventTriggered.ChangedAttributes = value;
}
get {
    return ssENDrawingToolsEventTriggered.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_499511b992975daa9639159d76f69e74() {
OptimizedAttributes = null;
ssENDrawingToolsEventTriggered = new EN_8a068e43cce18c5870b845073fb713c1EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(1,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENDrawingToolsEventTriggered.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENDrawingToolsEventTriggered.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENDrawingToolsEventTriggered.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENDrawingToolsEventTriggered.Read( r, ref index);
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
public void ReadIM(RC_499511b992975daa9639159d76f69e74 r) {
this = r;
}


public static bool operator == (RC_499511b992975daa9639159d76f69e74 a, RC_499511b992975daa9639159d76f69e74 b) {
if (a.ssENDrawingToolsEventTriggered != b.ssENDrawingToolsEventTriggered) return false;
return true;
}

public static bool operator != (RC_499511b992975daa9639159d76f69e74 a, RC_499511b992975daa9639159d76f69e74 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_499511b992975daa9639159d76f69e74)) return false;
return (this == (RC_499511b992975daa9639159d76f69e74)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENDrawingToolsEventTriggered.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENDrawingToolsEventTriggered.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENDrawingToolsEventTriggered.InternalRecursiveSave();
}


public RC_499511b992975daa9639159d76f69e74 Duplicate() {
RC_499511b992975daa9639159d76f69e74 t;
t.ssENDrawingToolsEventTriggered = (EN_8a068e43cce18c5870b845073fb713c1EntityRecord)this.ssENDrawingToolsEventTriggered.Duplicate();
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
if (head == "drawingtoolseventtriggered") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DrawingToolsEventTriggered")) variable.Value = ssENDrawingToolsEventTriggered; else variable.Optimized = true;
variable.SetFieldName("drawingtoolseventtriggered");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENDrawingToolsEventTriggered.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENDrawingToolsEventTriggered.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdDrawingToolsEventTriggered) {
return ssENDrawingToolsEventTriggered;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdDrawingToolsEventTriggered.Key.AsGuid) {
return ssENDrawingToolsEventTriggered;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENDrawingToolsEventTriggered.FillFromOther((IRecord) other.AttributeGet(IdDrawingToolsEventTriggered));
}
} // RC_499511b992975daa9639159d76f69e74
/// <summary>
/// RecordList type <code>DrawingToolsEventTriggeredRecordList</code> that represents a record list of
///  <code>DrawingToolsEventTriggered</code>
/// </summary>
public partial class RL_8145c3d769f4c9bbbe231760708670b3 : GenericRecordList<RC_499511b992975daa9639159d76f69e74>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_499511b992975daa9639159d76f69e74 GetElementDefaultValue() {
return new RC_499511b992975daa9639159d76f69e74();
}

public T[] ToArray<T>(Func<RC_499511b992975daa9639159d76f69e74, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_8145c3d769f4c9bbbe231760708670b3 recordList, Func<RC_499511b992975daa9639159d76f69e74, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_8145c3d769f4c9bbbe231760708670b3(RC_499511b992975daa9639159d76f69e74[] array) {
  RL_8145c3d769f4c9bbbe231760708670b3 result = new RL_8145c3d769f4c9bbbe231760708670b3();
result.InnerFromArray(array);
    return result;
}

public static RL_8145c3d769f4c9bbbe231760708670b3 ToList<T>(T[] array, Func <T, RC_499511b992975daa9639159d76f69e74> converter) {
  RL_8145c3d769f4c9bbbe231760708670b3 result = new RL_8145c3d769f4c9bbbe231760708670b3();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_8145c3d769f4c9bbbe231760708670b3 FromRestList<T>(RestList<T> restList, Func <T, RC_499511b992975daa9639159d76f69e74> converter) {
  RL_8145c3d769f4c9bbbe231760708670b3 result = new RL_8145c3d769f4c9bbbe231760708670b3();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_8145c3d769f4c9bbbe231760708670b3() : base() {
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
protected override OSList<RC_499511b992975daa9639159d76f69e74> NewList() {
return new RL_8145c3d769f4c9bbbe231760708670b3();
}


} // RL_8145c3d769f4c9bbbe231760708670b3
}

