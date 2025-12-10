namespace ssOutSystemsMaps {
/// <summary>
/// [AnonymousStructure] Record (hB77a6q2i0CYG6gLbC0Z8w)
///  <code>RC_c52fa927f09489f1c90f3a0526a1c8c9</code> that represent
/// s <code>DrawingToolsPositionRecord</code> <p>Description: </p>
/// </summary>
// Name: DrawingToolsPositionRecord
public partial struct RC_c52fa927f09489f1c90f3a0526a1c8c9 : ITypedRecord<RC_c52fa927f09489f1c90f3a0526a1c8c9> {
internal static readonly GlobalObjectKey IdDrawingToolsPosition = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*J6kvxZTw8YnJDzoFJqHIyQ");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("DrawingToolsPosition")]
public EN_f6b05f1cc2ae707d67f7da7ba2f4fd22EntityRecord ssENDrawingToolsPosition;


public static implicit operator EN_f6b05f1cc2ae707d67f7da7ba2f4fd22EntityRecord( RC_c52fa927f09489f1c90f3a0526a1c8c9 r) {
return r.ssENDrawingToolsPosition;
}

public static implicit operator RC_c52fa927f09489f1c90f3a0526a1c8c9 (EN_f6b05f1cc2ae707d67f7da7ba2f4fd22EntityRecord r) {
RC_c52fa927f09489f1c90f3a0526a1c8c9 res = new RC_c52fa927f09489f1c90f3a0526a1c8c9 ();
res.ssENDrawingToolsPosition = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENDrawingToolsPosition.ChangedAttributes = value;
}
get {
    return ssENDrawingToolsPosition.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_c52fa927f09489f1c90f3a0526a1c8c9() {
OptimizedAttributes = null;
ssENDrawingToolsPosition = new EN_f6b05f1cc2ae707d67f7da7ba2f4fd22EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(1,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENDrawingToolsPosition.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENDrawingToolsPosition.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENDrawingToolsPosition.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENDrawingToolsPosition.Read( r, ref index);
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
public void ReadIM(RC_c52fa927f09489f1c90f3a0526a1c8c9 r) {
this = r;
}


public static bool operator == (RC_c52fa927f09489f1c90f3a0526a1c8c9 a, RC_c52fa927f09489f1c90f3a0526a1c8c9 b) {
if (a.ssENDrawingToolsPosition != b.ssENDrawingToolsPosition) return false;
return true;
}

public static bool operator != (RC_c52fa927f09489f1c90f3a0526a1c8c9 a, RC_c52fa927f09489f1c90f3a0526a1c8c9 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_c52fa927f09489f1c90f3a0526a1c8c9)) return false;
return (this == (RC_c52fa927f09489f1c90f3a0526a1c8c9)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENDrawingToolsPosition.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENDrawingToolsPosition.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENDrawingToolsPosition.InternalRecursiveSave();
}


public RC_c52fa927f09489f1c90f3a0526a1c8c9 Duplicate() {
RC_c52fa927f09489f1c90f3a0526a1c8c9 t;
t.ssENDrawingToolsPosition = (EN_f6b05f1cc2ae707d67f7da7ba2f4fd22EntityRecord)this.ssENDrawingToolsPosition.Duplicate();
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
if (head == "drawingtoolsposition") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DrawingToolsPosition")) variable.Value = ssENDrawingToolsPosition; else variable.Optimized = true;
variable.SetFieldName("drawingtoolsposition");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENDrawingToolsPosition.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENDrawingToolsPosition.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdDrawingToolsPosition) {
return ssENDrawingToolsPosition;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdDrawingToolsPosition.Key.AsGuid) {
return ssENDrawingToolsPosition;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENDrawingToolsPosition.FillFromOther((IRecord) other.AttributeGet(IdDrawingToolsPosition));
}
} // RC_c52fa927f09489f1c90f3a0526a1c8c9
/// <summary>
/// RecordList type <code>DrawingToolsPositionRecordList</code> that represents a record list of
///  <code>DrawingToolsPosition</code>
/// </summary>
public partial class RL_9e18711d0e128678787e38cf96c062ee : GenericRecordList<RC_c52fa927f09489f1c90f3a0526a1c8c9>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_c52fa927f09489f1c90f3a0526a1c8c9 GetElementDefaultValue() {
return new RC_c52fa927f09489f1c90f3a0526a1c8c9();
}

public T[] ToArray<T>(Func<RC_c52fa927f09489f1c90f3a0526a1c8c9, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_9e18711d0e128678787e38cf96c062ee recordList, Func<RC_c52fa927f09489f1c90f3a0526a1c8c9, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_9e18711d0e128678787e38cf96c062ee(RC_c52fa927f09489f1c90f3a0526a1c8c9[] array) {
  RL_9e18711d0e128678787e38cf96c062ee result = new RL_9e18711d0e128678787e38cf96c062ee();
result.InnerFromArray(array);
    return result;
}

public static RL_9e18711d0e128678787e38cf96c062ee ToList<T>(T[] array, Func <T, RC_c52fa927f09489f1c90f3a0526a1c8c9> converter) {
  RL_9e18711d0e128678787e38cf96c062ee result = new RL_9e18711d0e128678787e38cf96c062ee();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_9e18711d0e128678787e38cf96c062ee FromRestList<T>(RestList<T> restList, Func <T, RC_c52fa927f09489f1c90f3a0526a1c8c9> converter) {
  RL_9e18711d0e128678787e38cf96c062ee result = new RL_9e18711d0e128678787e38cf96c062ee();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_9e18711d0e128678787e38cf96c062ee() : base() {
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
protected override OSList<RC_c52fa927f09489f1c90f3a0526a1c8c9> NewList() {
return new RL_9e18711d0e128678787e38cf96c062ee();
}


} // RL_9e18711d0e128678787e38cf96c062ee
}

