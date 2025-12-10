namespace ssZXingLibDemo.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (gX7kEWmBN0uKLjBqv+gzLQ)
///  <code>RC_57ba3d0d08ca4ec872815e3480261d89</code> that represents <code>BarcodeRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: BarcodeRecord
public partial struct RC_57ba3d0d08ca4ec872815e3480261d89 : ITypedRecord<RC_57ba3d0d08ca4ec872815e3480261d89>, OutSystems.Application.Extensibility.DataTypes.IStructure {
internal static readonly GlobalObjectKey IdBarcode = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*DT26V8oIyE5ygV40gCYdiQ");

[System.Xml.Serialization.XmlElement("Barcode")]
public ST_7750e71a4e018dabac19d9f560c2b017Structure ssSTBarcode;


public static implicit operator ST_7750e71a4e018dabac19d9f560c2b017Structure( RC_57ba3d0d08ca4ec872815e3480261d89 r) {
return r.ssSTBarcode;
}

public static implicit operator RC_57ba3d0d08ca4ec872815e3480261d89 (ST_7750e71a4e018dabac19d9f560c2b017Structure r) {
RC_57ba3d0d08ca4ec872815e3480261d89 res = new RC_57ba3d0d08ca4ec872815e3480261d89 ();
res.ssSTBarcode = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_57ba3d0d08ca4ec872815e3480261d89() {
OptimizedAttributes = null;
ssSTBarcode = new ST_7750e71a4e018dabac19d9f560c2b017Structure();
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
    ssSTBarcode.OptimizedAttributes = value[0];
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
ssSTBarcode.Read( r, ref index);
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
public void ReadIM(RC_57ba3d0d08ca4ec872815e3480261d89 r) {
this = r;
}


public static bool operator == (RC_57ba3d0d08ca4ec872815e3480261d89 a, RC_57ba3d0d08ca4ec872815e3480261d89 b) {
if (a.ssSTBarcode != b.ssSTBarcode) return false;
return true;
}

public static bool operator != (RC_57ba3d0d08ca4ec872815e3480261d89 a, RC_57ba3d0d08ca4ec872815e3480261d89 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_57ba3d0d08ca4ec872815e3480261d89)) return false;
return (this == (RC_57ba3d0d08ca4ec872815e3480261d89)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTBarcode.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTBarcode.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTBarcode.InternalRecursiveSave();
}


public RC_57ba3d0d08ca4ec872815e3480261d89 Duplicate() {
RC_57ba3d0d08ca4ec872815e3480261d89 t;
t.ssSTBarcode = (ST_7750e71a4e018dabac19d9f560c2b017Structure)this.ssSTBarcode.Duplicate();
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
if (head == "barcode") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Barcode")) variable.Value = ssSTBarcode; else variable.Optimized = true;
variable.SetFieldName("barcode");
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
if (key == IdBarcode) {
return ssSTBarcode;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdBarcode.Key.AsGuid) {
return ssSTBarcode;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTBarcode.FillFromOther((IRecord) other.AttributeGet(IdBarcode));
}
public void CopyFrom(OutSystems.Application.Extensibility.DataTypes.IRecord other) {
if (other == null) return;
ssSTBarcode.CopyFrom((OutSystems.Application.Extensibility.DataTypes.IRecord) other.GetAttribute(IdBarcode.Key.AsGuid));
}
} // RC_57ba3d0d08ca4ec872815e3480261d89
/// <summary>
/// RecordList type <code>BarcodeRecordList</code> that represents a record list of
///  <code>Barcode</code>
/// </summary>
public partial class RL_97e413b904c3def3d61e9c925d35e367 : GenericRecordList<RC_57ba3d0d08ca4ec872815e3480261d89>, IEnumerable, IEnumerator {

protected override RC_57ba3d0d08ca4ec872815e3480261d89 GetElementDefaultValue() {
return new RC_57ba3d0d08ca4ec872815e3480261d89();
}

public T[] ToArray<T>(Func<RC_57ba3d0d08ca4ec872815e3480261d89, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_97e413b904c3def3d61e9c925d35e367 recordList, Func<RC_57ba3d0d08ca4ec872815e3480261d89, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_97e413b904c3def3d61e9c925d35e367(RC_57ba3d0d08ca4ec872815e3480261d89[] array) {
  RL_97e413b904c3def3d61e9c925d35e367 result = new RL_97e413b904c3def3d61e9c925d35e367();
result.InnerFromArray(array);
    return result;
}

public static RL_97e413b904c3def3d61e9c925d35e367 ToList<T>(T[] array, Func <T, RC_57ba3d0d08ca4ec872815e3480261d89> converter) {
  RL_97e413b904c3def3d61e9c925d35e367 result = new RL_97e413b904c3def3d61e9c925d35e367();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_97e413b904c3def3d61e9c925d35e367 FromRestList<T>(RestList<T> restList, Func <T, RC_57ba3d0d08ca4ec872815e3480261d89> converter) {
  RL_97e413b904c3def3d61e9c925d35e367 result = new RL_97e413b904c3def3d61e9c925d35e367();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_97e413b904c3def3d61e9c925d35e367() : base() {
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
protected override OSList<RC_57ba3d0d08ca4ec872815e3480261d89> NewList() {
return new RL_97e413b904c3def3d61e9c925d35e367();
}


} // RL_97e413b904c3def3d61e9c925d35e367
}

