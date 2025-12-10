namespace ssOutSystemsMaps {
/// <summary>
/// [AnonymousStructure] Record (qdejyMqT8kO26MS4TnIPjw)
///  <code>RC_edb1f7bb91ddbc761736a4f9fe9ed955</code> that represents <code>ShapeEventRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: ShapeEventRecord
public partial struct RC_edb1f7bb91ddbc761736a4f9fe9ed955 : ITypedRecord<RC_edb1f7bb91ddbc761736a4f9fe9ed955> {
internal static readonly GlobalObjectKey IdShapeEvent = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*u_ex7d2RdrwXNqT5_p7ZVQ");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("ShapeEvent")]
public EN_bb81f40812568e1c8d85e64e62cfe06cEntityRecord ssENShapeEvent;


public static implicit operator EN_bb81f40812568e1c8d85e64e62cfe06cEntityRecord( RC_edb1f7bb91ddbc761736a4f9fe9ed955 r) {
return r.ssENShapeEvent;
}

public static implicit operator RC_edb1f7bb91ddbc761736a4f9fe9ed955 (EN_bb81f40812568e1c8d85e64e62cfe06cEntityRecord r) {
RC_edb1f7bb91ddbc761736a4f9fe9ed955 res = new RC_edb1f7bb91ddbc761736a4f9fe9ed955 ();
res.ssENShapeEvent = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENShapeEvent.ChangedAttributes = value;
}
get {
    return ssENShapeEvent.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_edb1f7bb91ddbc761736a4f9fe9ed955() {
OptimizedAttributes = null;
ssENShapeEvent = new EN_bb81f40812568e1c8d85e64e62cfe06cEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(1,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENShapeEvent.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENShapeEvent.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENShapeEvent.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENShapeEvent.Read( r, ref index);
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
public void ReadIM(RC_edb1f7bb91ddbc761736a4f9fe9ed955 r) {
this = r;
}


public static bool operator == (RC_edb1f7bb91ddbc761736a4f9fe9ed955 a, RC_edb1f7bb91ddbc761736a4f9fe9ed955 b) {
if (a.ssENShapeEvent != b.ssENShapeEvent) return false;
return true;
}

public static bool operator != (RC_edb1f7bb91ddbc761736a4f9fe9ed955 a, RC_edb1f7bb91ddbc761736a4f9fe9ed955 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_edb1f7bb91ddbc761736a4f9fe9ed955)) return false;
return (this == (RC_edb1f7bb91ddbc761736a4f9fe9ed955)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENShapeEvent.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENShapeEvent.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENShapeEvent.InternalRecursiveSave();
}


public RC_edb1f7bb91ddbc761736a4f9fe9ed955 Duplicate() {
RC_edb1f7bb91ddbc761736a4f9fe9ed955 t;
t.ssENShapeEvent = (EN_bb81f40812568e1c8d85e64e62cfe06cEntityRecord)this.ssENShapeEvent.Duplicate();
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
if (head == "shapeevent") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ShapeEvent")) variable.Value = ssENShapeEvent; else variable.Optimized = true;
variable.SetFieldName("shapeevent");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENShapeEvent.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENShapeEvent.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdShapeEvent) {
return ssENShapeEvent;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdShapeEvent.Key.AsGuid) {
return ssENShapeEvent;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENShapeEvent.FillFromOther((IRecord) other.AttributeGet(IdShapeEvent));
}
} // RC_edb1f7bb91ddbc761736a4f9fe9ed955
/// <summary>
/// RecordList type <code>ShapeEventRecordList</code> that represents a record list of
///  <code>ShapeEvent</code>
/// </summary>
public partial class RL_a63434523705ad5af804bdbeb8b187a0 : GenericRecordList<RC_edb1f7bb91ddbc761736a4f9fe9ed955>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_edb1f7bb91ddbc761736a4f9fe9ed955 GetElementDefaultValue() {
return new RC_edb1f7bb91ddbc761736a4f9fe9ed955();
}

public T[] ToArray<T>(Func<RC_edb1f7bb91ddbc761736a4f9fe9ed955, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_a63434523705ad5af804bdbeb8b187a0 recordList, Func<RC_edb1f7bb91ddbc761736a4f9fe9ed955, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_a63434523705ad5af804bdbeb8b187a0(RC_edb1f7bb91ddbc761736a4f9fe9ed955[] array) {
  RL_a63434523705ad5af804bdbeb8b187a0 result = new RL_a63434523705ad5af804bdbeb8b187a0();
result.InnerFromArray(array);
    return result;
}

public static RL_a63434523705ad5af804bdbeb8b187a0 ToList<T>(T[] array, Func <T, RC_edb1f7bb91ddbc761736a4f9fe9ed955> converter) {
  RL_a63434523705ad5af804bdbeb8b187a0 result = new RL_a63434523705ad5af804bdbeb8b187a0();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_a63434523705ad5af804bdbeb8b187a0 FromRestList<T>(RestList<T> restList, Func <T, RC_edb1f7bb91ddbc761736a4f9fe9ed955> converter) {
  RL_a63434523705ad5af804bdbeb8b187a0 result = new RL_a63434523705ad5af804bdbeb8b187a0();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_a63434523705ad5af804bdbeb8b187a0() : base() {
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
protected override OSList<RC_edb1f7bb91ddbc761736a4f9fe9ed955> NewList() {
return new RL_a63434523705ad5af804bdbeb8b187a0();
}


} // RL_a63434523705ad5af804bdbeb8b187a0
}

