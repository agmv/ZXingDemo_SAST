namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (6vhFJgOGp0GnZRSBpiTIbg)
///  <code>RC_95c473136722ba7379611f73a3471de3</code> that represent
/// s <code>FloatingPositionRecord</code> <p>Description: </p>
/// </summary>
// Name: FloatingPositionRecord
public partial struct RC_95c473136722ba7379611f73a3471de3 : ITypedRecord<RC_95c473136722ba7379611f73a3471de3> {
internal static readonly GlobalObjectKey IdFloatingPosition = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*E3PElSJnc7p5YR9zo0cd4w");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("FloatingPosition")]
public EN_4f86046673de081f9834eb306850ab22EntityRecord ssENFloatingPosition;


public static implicit operator EN_4f86046673de081f9834eb306850ab22EntityRecord( RC_95c473136722ba7379611f73a3471de3 r) {
return r.ssENFloatingPosition;
}

public static implicit operator RC_95c473136722ba7379611f73a3471de3 (EN_4f86046673de081f9834eb306850ab22EntityRecord r) {
RC_95c473136722ba7379611f73a3471de3 res = new RC_95c473136722ba7379611f73a3471de3 ();
res.ssENFloatingPosition = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENFloatingPosition.ChangedAttributes = value;
}
get {
    return ssENFloatingPosition.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_95c473136722ba7379611f73a3471de3() {
OptimizedAttributes = null;
ssENFloatingPosition = new EN_4f86046673de081f9834eb306850ab22EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(1,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENFloatingPosition.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENFloatingPosition.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENFloatingPosition.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENFloatingPosition.Read( r, ref index);
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
public void ReadIM(RC_95c473136722ba7379611f73a3471de3 r) {
this = r;
}


public static bool operator == (RC_95c473136722ba7379611f73a3471de3 a, RC_95c473136722ba7379611f73a3471de3 b) {
if (a.ssENFloatingPosition != b.ssENFloatingPosition) return false;
return true;
}

public static bool operator != (RC_95c473136722ba7379611f73a3471de3 a, RC_95c473136722ba7379611f73a3471de3 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_95c473136722ba7379611f73a3471de3)) return false;
return (this == (RC_95c473136722ba7379611f73a3471de3)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENFloatingPosition.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENFloatingPosition.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENFloatingPosition.InternalRecursiveSave();
}


public RC_95c473136722ba7379611f73a3471de3 Duplicate() {
RC_95c473136722ba7379611f73a3471de3 t;
t.ssENFloatingPosition = (EN_4f86046673de081f9834eb306850ab22EntityRecord)this.ssENFloatingPosition.Duplicate();
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
if (head == "floatingposition") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FloatingPosition")) variable.Value = ssENFloatingPosition; else variable.Optimized = true;
variable.SetFieldName("floatingposition");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENFloatingPosition.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENFloatingPosition.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdFloatingPosition) {
return ssENFloatingPosition;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdFloatingPosition.Key.AsGuid) {
return ssENFloatingPosition;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENFloatingPosition.FillFromOther((IRecord) other.AttributeGet(IdFloatingPosition));
}
} // RC_95c473136722ba7379611f73a3471de3
/// <summary>
/// RecordList type <code>FloatingPositionRecordList</code> that represents a record list of
///  <code>FloatingPosition</code>
/// </summary>
public partial class RL_1ea3e84bcb11dff20d44cc2dd9bb0fe2 : GenericRecordList<RC_95c473136722ba7379611f73a3471de3>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_95c473136722ba7379611f73a3471de3 GetElementDefaultValue() {
return new RC_95c473136722ba7379611f73a3471de3();
}

public T[] ToArray<T>(Func<RC_95c473136722ba7379611f73a3471de3, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_1ea3e84bcb11dff20d44cc2dd9bb0fe2 recordList, Func<RC_95c473136722ba7379611f73a3471de3, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_1ea3e84bcb11dff20d44cc2dd9bb0fe2(RC_95c473136722ba7379611f73a3471de3[] array) {
  RL_1ea3e84bcb11dff20d44cc2dd9bb0fe2 result = new RL_1ea3e84bcb11dff20d44cc2dd9bb0fe2();
result.InnerFromArray(array);
    return result;
}

public static RL_1ea3e84bcb11dff20d44cc2dd9bb0fe2 ToList<T>(T[] array, Func <T, RC_95c473136722ba7379611f73a3471de3> converter) {
  RL_1ea3e84bcb11dff20d44cc2dd9bb0fe2 result = new RL_1ea3e84bcb11dff20d44cc2dd9bb0fe2();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_1ea3e84bcb11dff20d44cc2dd9bb0fe2 FromRestList<T>(RestList<T> restList, Func <T, RC_95c473136722ba7379611f73a3471de3> converter) {
  RL_1ea3e84bcb11dff20d44cc2dd9bb0fe2 result = new RL_1ea3e84bcb11dff20d44cc2dd9bb0fe2();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_1ea3e84bcb11dff20d44cc2dd9bb0fe2() : base() {
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
protected override OSList<RC_95c473136722ba7379611f73a3471de3> NewList() {
return new RL_1ea3e84bcb11dff20d44cc2dd9bb0fe2();
}


} // RL_1ea3e84bcb11dff20d44cc2dd9bb0fe2
}

