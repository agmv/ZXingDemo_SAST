namespace ssOutSystemsMaps {
/// <summary>
/// [AnonymousStructure] Record (uefbJAUVnUqB2HzaTtgzNg)
///  <code>RC_a3e0d02178b078a960ae427dd1751cbc</code> that represents <code>OffsetRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: OffsetRecord
public partial struct RC_a3e0d02178b078a960ae427dd1751cbc : ITypedRecord<RC_a3e0d02178b078a960ae427dd1751cbc> {
internal static readonly GlobalObjectKey IdOffset = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*IdDgo7B4qXhgrkJ90XUcvA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Offset")]
public ST_be62cc31fbe4705834275960beeb55e2Structure ssSTOffset;


public static implicit operator ST_be62cc31fbe4705834275960beeb55e2Structure( RC_a3e0d02178b078a960ae427dd1751cbc r) {
return r.ssSTOffset;
}

public static implicit operator RC_a3e0d02178b078a960ae427dd1751cbc (ST_be62cc31fbe4705834275960beeb55e2Structure r) {
RC_a3e0d02178b078a960ae427dd1751cbc res = new RC_a3e0d02178b078a960ae427dd1751cbc ();
res.ssSTOffset = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_a3e0d02178b078a960ae427dd1751cbc() {
OptimizedAttributes = null;
ssSTOffset = new ST_be62cc31fbe4705834275960beeb55e2Structure();
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
    ssSTOffset.OptimizedAttributes = value[0];
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
ssSTOffset.Read( r, ref index);
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
public void ReadIM(RC_a3e0d02178b078a960ae427dd1751cbc r) {
this = r;
}


public static bool operator == (RC_a3e0d02178b078a960ae427dd1751cbc a, RC_a3e0d02178b078a960ae427dd1751cbc b) {
if (a.ssSTOffset != b.ssSTOffset) return false;
return true;
}

public static bool operator != (RC_a3e0d02178b078a960ae427dd1751cbc a, RC_a3e0d02178b078a960ae427dd1751cbc b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_a3e0d02178b078a960ae427dd1751cbc)) return false;
return (this == (RC_a3e0d02178b078a960ae427dd1751cbc)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTOffset.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTOffset.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTOffset.InternalRecursiveSave();
}


public RC_a3e0d02178b078a960ae427dd1751cbc Duplicate() {
RC_a3e0d02178b078a960ae427dd1751cbc t;
t.ssSTOffset = (ST_be62cc31fbe4705834275960beeb55e2Structure)this.ssSTOffset.Duplicate();
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
if (head == "offset") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Offset")) variable.Value = ssSTOffset; else variable.Optimized = true;
variable.SetFieldName("offset");
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
if (key == IdOffset) {
return ssSTOffset;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOffset.Key.AsGuid) {
return ssSTOffset;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTOffset.FillFromOther((IRecord) other.AttributeGet(IdOffset));
}
} // RC_a3e0d02178b078a960ae427dd1751cbc
/// <summary>
/// RecordList type <code>OffsetRecordList</code> that represents a record list of <code>Offset</code>
/// </summary>
public partial class RL_37ebca9cc7a640553fda76d301ad4a68 : GenericRecordList<RC_a3e0d02178b078a960ae427dd1751cbc>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_a3e0d02178b078a960ae427dd1751cbc GetElementDefaultValue() {
return new RC_a3e0d02178b078a960ae427dd1751cbc();
}

public T[] ToArray<T>(Func<RC_a3e0d02178b078a960ae427dd1751cbc, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_37ebca9cc7a640553fda76d301ad4a68 recordList, Func<RC_a3e0d02178b078a960ae427dd1751cbc, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_37ebca9cc7a640553fda76d301ad4a68(RC_a3e0d02178b078a960ae427dd1751cbc[] array) {
  RL_37ebca9cc7a640553fda76d301ad4a68 result = new RL_37ebca9cc7a640553fda76d301ad4a68();
result.InnerFromArray(array);
    return result;
}

public static RL_37ebca9cc7a640553fda76d301ad4a68 ToList<T>(T[] array, Func <T, RC_a3e0d02178b078a960ae427dd1751cbc> converter) {
  RL_37ebca9cc7a640553fda76d301ad4a68 result = new RL_37ebca9cc7a640553fda76d301ad4a68();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_37ebca9cc7a640553fda76d301ad4a68 FromRestList<T>(RestList<T> restList, Func <T, RC_a3e0d02178b078a960ae427dd1751cbc> converter) {
  RL_37ebca9cc7a640553fda76d301ad4a68 result = new RL_37ebca9cc7a640553fda76d301ad4a68();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_37ebca9cc7a640553fda76d301ad4a68() : base() {
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
protected override OSList<RC_a3e0d02178b078a960ae427dd1751cbc> NewList() {
return new RL_37ebca9cc7a640553fda76d301ad4a68();
}


} // RL_37ebca9cc7a640553fda76d301ad4a68
}

