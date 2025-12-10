namespace ssOutSystemsMaps {
/// <summary>
/// [AnonymousStructure] Record (mcS2bb6IcEGgxM5kzqnn+A)
///  <code>RC_e2e4078a68f051b01b0e49ed4f3f6e07</code> that represents <code>DrawingToolTypeRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: DrawingToolTypeRecord
public partial struct RC_e2e4078a68f051b01b0e49ed4f3f6e07 : ITypedRecord<RC_e2e4078a68f051b01b0e49ed4f3f6e07> {
internal static readonly GlobalObjectKey IdDrawingToolType = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*igfk4vBosFEbDkntTz9uBw");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("DrawingToolType")]
public EN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord ssENDrawingToolType;


public static implicit operator EN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord( RC_e2e4078a68f051b01b0e49ed4f3f6e07 r) {
return r.ssENDrawingToolType;
}

public static implicit operator RC_e2e4078a68f051b01b0e49ed4f3f6e07 (EN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord r) {
RC_e2e4078a68f051b01b0e49ed4f3f6e07 res = new RC_e2e4078a68f051b01b0e49ed4f3f6e07 ();
res.ssENDrawingToolType = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENDrawingToolType.ChangedAttributes = value;
}
get {
    return ssENDrawingToolType.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_e2e4078a68f051b01b0e49ed4f3f6e07() {
OptimizedAttributes = null;
ssENDrawingToolType = new EN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(1,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENDrawingToolType.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENDrawingToolType.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENDrawingToolType.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENDrawingToolType.Read( r, ref index);
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
public void ReadIM(RC_e2e4078a68f051b01b0e49ed4f3f6e07 r) {
this = r;
}


public static bool operator == (RC_e2e4078a68f051b01b0e49ed4f3f6e07 a, RC_e2e4078a68f051b01b0e49ed4f3f6e07 b) {
if (a.ssENDrawingToolType != b.ssENDrawingToolType) return false;
return true;
}

public static bool operator != (RC_e2e4078a68f051b01b0e49ed4f3f6e07 a, RC_e2e4078a68f051b01b0e49ed4f3f6e07 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_e2e4078a68f051b01b0e49ed4f3f6e07)) return false;
return (this == (RC_e2e4078a68f051b01b0e49ed4f3f6e07)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENDrawingToolType.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENDrawingToolType.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENDrawingToolType.InternalRecursiveSave();
}


public RC_e2e4078a68f051b01b0e49ed4f3f6e07 Duplicate() {
RC_e2e4078a68f051b01b0e49ed4f3f6e07 t;
t.ssENDrawingToolType = (EN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord)this.ssENDrawingToolType.Duplicate();
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
if (head == "drawingtooltype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DrawingToolType")) variable.Value = ssENDrawingToolType; else variable.Optimized = true;
variable.SetFieldName("drawingtooltype");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENDrawingToolType.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENDrawingToolType.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdDrawingToolType) {
return ssENDrawingToolType;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdDrawingToolType.Key.AsGuid) {
return ssENDrawingToolType;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENDrawingToolType.FillFromOther((IRecord) other.AttributeGet(IdDrawingToolType));
}
} // RC_e2e4078a68f051b01b0e49ed4f3f6e07
/// <summary>
/// RecordList type <code>DrawingToolTypeRecordList</code> that represents a record list of
///  <code>DrawingToolType</code>
/// </summary>
public partial class RL_5428fe7a3573eea99d91fc6654eda2fe : GenericRecordList<RC_e2e4078a68f051b01b0e49ed4f3f6e07>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_e2e4078a68f051b01b0e49ed4f3f6e07 GetElementDefaultValue() {
return new RC_e2e4078a68f051b01b0e49ed4f3f6e07();
}

public T[] ToArray<T>(Func<RC_e2e4078a68f051b01b0e49ed4f3f6e07, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_5428fe7a3573eea99d91fc6654eda2fe recordList, Func<RC_e2e4078a68f051b01b0e49ed4f3f6e07, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_5428fe7a3573eea99d91fc6654eda2fe(RC_e2e4078a68f051b01b0e49ed4f3f6e07[] array) {
  RL_5428fe7a3573eea99d91fc6654eda2fe result = new RL_5428fe7a3573eea99d91fc6654eda2fe();
result.InnerFromArray(array);
    return result;
}

public static RL_5428fe7a3573eea99d91fc6654eda2fe ToList<T>(T[] array, Func <T, RC_e2e4078a68f051b01b0e49ed4f3f6e07> converter) {
  RL_5428fe7a3573eea99d91fc6654eda2fe result = new RL_5428fe7a3573eea99d91fc6654eda2fe();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_5428fe7a3573eea99d91fc6654eda2fe FromRestList<T>(RestList<T> restList, Func <T, RC_e2e4078a68f051b01b0e49ed4f3f6e07> converter) {
  RL_5428fe7a3573eea99d91fc6654eda2fe result = new RL_5428fe7a3573eea99d91fc6654eda2fe();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_5428fe7a3573eea99d91fc6654eda2fe() : base() {
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
protected override OSList<RC_e2e4078a68f051b01b0e49ed4f3f6e07> NewList() {
return new RL_5428fe7a3573eea99d91fc6654eda2fe();
}


} // RL_5428fe7a3573eea99d91fc6654eda2fe
}

