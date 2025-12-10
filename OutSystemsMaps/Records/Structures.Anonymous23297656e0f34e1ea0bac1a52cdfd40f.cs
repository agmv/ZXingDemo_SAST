namespace ssOutSystemsMaps {
/// <summary>
/// [AnonymousStructure] Record (VnYpI_PgHk6gusGlLN_UDw)
///  <code>RC_499414721b608cf3d3b8f99fae961f52</code> that represent
/// s <code>DrawingToolsEventRecord</code> <p>Description: </p>
/// </summary>
// Name: DrawingToolsEventRecord
public partial struct RC_499414721b608cf3d3b8f99fae961f52 : ITypedRecord<RC_499414721b608cf3d3b8f99fae961f52> {
internal static readonly GlobalObjectKey IdDrawingToolsEvent = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*chSUSWAb84zTuPmfrpYfUg");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("DrawingToolsEvent")]
public EN_91019cdb14b7c30434c481d431eb9bf2EntityRecord ssENDrawingToolsEvent;


public static implicit operator EN_91019cdb14b7c30434c481d431eb9bf2EntityRecord( RC_499414721b608cf3d3b8f99fae961f52 r) {
return r.ssENDrawingToolsEvent;
}

public static implicit operator RC_499414721b608cf3d3b8f99fae961f52 (EN_91019cdb14b7c30434c481d431eb9bf2EntityRecord r) {
RC_499414721b608cf3d3b8f99fae961f52 res = new RC_499414721b608cf3d3b8f99fae961f52 ();
res.ssENDrawingToolsEvent = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENDrawingToolsEvent.ChangedAttributes = value;
}
get {
    return ssENDrawingToolsEvent.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_499414721b608cf3d3b8f99fae961f52() {
OptimizedAttributes = null;
ssENDrawingToolsEvent = new EN_91019cdb14b7c30434c481d431eb9bf2EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(1,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENDrawingToolsEvent.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENDrawingToolsEvent.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENDrawingToolsEvent.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENDrawingToolsEvent.Read( r, ref index);
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
public void ReadIM(RC_499414721b608cf3d3b8f99fae961f52 r) {
this = r;
}


public static bool operator == (RC_499414721b608cf3d3b8f99fae961f52 a, RC_499414721b608cf3d3b8f99fae961f52 b) {
if (a.ssENDrawingToolsEvent != b.ssENDrawingToolsEvent) return false;
return true;
}

public static bool operator != (RC_499414721b608cf3d3b8f99fae961f52 a, RC_499414721b608cf3d3b8f99fae961f52 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_499414721b608cf3d3b8f99fae961f52)) return false;
return (this == (RC_499414721b608cf3d3b8f99fae961f52)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENDrawingToolsEvent.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENDrawingToolsEvent.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENDrawingToolsEvent.InternalRecursiveSave();
}


public RC_499414721b608cf3d3b8f99fae961f52 Duplicate() {
RC_499414721b608cf3d3b8f99fae961f52 t;
t.ssENDrawingToolsEvent = (EN_91019cdb14b7c30434c481d431eb9bf2EntityRecord)this.ssENDrawingToolsEvent.Duplicate();
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
if (head == "drawingtoolsevent") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DrawingToolsEvent")) variable.Value = ssENDrawingToolsEvent; else variable.Optimized = true;
variable.SetFieldName("drawingtoolsevent");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENDrawingToolsEvent.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENDrawingToolsEvent.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdDrawingToolsEvent) {
return ssENDrawingToolsEvent;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdDrawingToolsEvent.Key.AsGuid) {
return ssENDrawingToolsEvent;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENDrawingToolsEvent.FillFromOther((IRecord) other.AttributeGet(IdDrawingToolsEvent));
}
} // RC_499414721b608cf3d3b8f99fae961f52
/// <summary>
/// RecordList type <code>DrawingToolsEventRecordList</code> that represents a record list of
///  <code>DrawingToolsEvent</code>
/// </summary>
public partial class RL_69bc672632207b6ab7be38e5bf1c3e72 : GenericRecordList<RC_499414721b608cf3d3b8f99fae961f52>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_499414721b608cf3d3b8f99fae961f52 GetElementDefaultValue() {
return new RC_499414721b608cf3d3b8f99fae961f52();
}

public T[] ToArray<T>(Func<RC_499414721b608cf3d3b8f99fae961f52, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_69bc672632207b6ab7be38e5bf1c3e72 recordList, Func<RC_499414721b608cf3d3b8f99fae961f52, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_69bc672632207b6ab7be38e5bf1c3e72(RC_499414721b608cf3d3b8f99fae961f52[] array) {
  RL_69bc672632207b6ab7be38e5bf1c3e72 result = new RL_69bc672632207b6ab7be38e5bf1c3e72();
result.InnerFromArray(array);
    return result;
}

public static RL_69bc672632207b6ab7be38e5bf1c3e72 ToList<T>(T[] array, Func <T, RC_499414721b608cf3d3b8f99fae961f52> converter) {
  RL_69bc672632207b6ab7be38e5bf1c3e72 result = new RL_69bc672632207b6ab7be38e5bf1c3e72();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_69bc672632207b6ab7be38e5bf1c3e72 FromRestList<T>(RestList<T> restList, Func <T, RC_499414721b608cf3d3b8f99fae961f52> converter) {
  RL_69bc672632207b6ab7be38e5bf1c3e72 result = new RL_69bc672632207b6ab7be38e5bf1c3e72();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_69bc672632207b6ab7be38e5bf1c3e72() : base() {
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
protected override OSList<RC_499414721b608cf3d3b8f99fae961f52> NewList() {
return new RL_69bc672632207b6ab7be38e5bf1c3e72();
}


} // RL_69bc672632207b6ab7be38e5bf1c3e72
}

