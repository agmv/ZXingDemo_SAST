namespace ssZXingLibDemo.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (Klcvafh0CkSimt5s1wWLJA)
///  <code>RC_b32e755d03dd085a4b975b8c0c7d4454</code> that represents <code>TypeRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: TypeRecord
public partial struct RC_b32e755d03dd085a4b975b8c0c7d4454 : ITypedRecord<RC_b32e755d03dd085a4b975b8c0c7d4454> {
internal static readonly GlobalObjectKey IdType = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*XXUus90DWghLl1uMDH1EVA");

[System.Xml.Serialization.XmlElement("Type")]
public EN_da8d5af471adea3d9064074b1a40d8c2EntityRecord ssENType;


public static implicit operator EN_da8d5af471adea3d9064074b1a40d8c2EntityRecord( RC_b32e755d03dd085a4b975b8c0c7d4454 r) {
return r.ssENType;
}

public static implicit operator RC_b32e755d03dd085a4b975b8c0c7d4454 (EN_da8d5af471adea3d9064074b1a40d8c2EntityRecord r) {
RC_b32e755d03dd085a4b975b8c0c7d4454 res = new RC_b32e755d03dd085a4b975b8c0c7d4454 ();
res.ssENType = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENType.ChangedAttributes = value;
}
get {
    return ssENType.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_b32e755d03dd085a4b975b8c0c7d4454() {
OptimizedAttributes = null;
ssENType = new EN_da8d5af471adea3d9064074b1a40d8c2EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(4,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENType.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENType.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENType.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENType.Read( r, ref index);
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
public void ReadIM(RC_b32e755d03dd085a4b975b8c0c7d4454 r) {
this = r;
}


public static bool operator == (RC_b32e755d03dd085a4b975b8c0c7d4454 a, RC_b32e755d03dd085a4b975b8c0c7d4454 b) {
if (a.ssENType != b.ssENType) return false;
return true;
}

public static bool operator != (RC_b32e755d03dd085a4b975b8c0c7d4454 a, RC_b32e755d03dd085a4b975b8c0c7d4454 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_b32e755d03dd085a4b975b8c0c7d4454)) return false;
return (this == (RC_b32e755d03dd085a4b975b8c0c7d4454)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENType.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENType.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENType.InternalRecursiveSave();
}


public RC_b32e755d03dd085a4b975b8c0c7d4454 Duplicate() {
RC_b32e755d03dd085a4b975b8c0c7d4454 t;
t.ssENType = (EN_da8d5af471adea3d9064074b1a40d8c2EntityRecord)this.ssENType.Duplicate();
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
if (head == "type") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Type")) variable.Value = ssENType; else variable.Optimized = true;
variable.SetFieldName("type");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENType.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENType.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdType) {
return ssENType;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdType.Key.AsGuid) {
return ssENType;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENType.FillFromOther((IRecord) other.AttributeGet(IdType));
}
} // RC_b32e755d03dd085a4b975b8c0c7d4454
/// <summary>
/// RecordList type <code>TypeRecordList</code> that represents a record list of <code>Type</code>
/// </summary>
public partial class RL_d15db589ea4d1a0a05d21cda4e2f9db2 : GenericRecordList<RC_b32e755d03dd085a4b975b8c0c7d4454>, IEnumerable, IEnumerator {

protected override RC_b32e755d03dd085a4b975b8c0c7d4454 GetElementDefaultValue() {
return new RC_b32e755d03dd085a4b975b8c0c7d4454();
}

public T[] ToArray<T>(Func<RC_b32e755d03dd085a4b975b8c0c7d4454, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_d15db589ea4d1a0a05d21cda4e2f9db2 recordList, Func<RC_b32e755d03dd085a4b975b8c0c7d4454, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_d15db589ea4d1a0a05d21cda4e2f9db2(RC_b32e755d03dd085a4b975b8c0c7d4454[] array) {
  RL_d15db589ea4d1a0a05d21cda4e2f9db2 result = new RL_d15db589ea4d1a0a05d21cda4e2f9db2();
result.InnerFromArray(array);
    return result;
}

public static RL_d15db589ea4d1a0a05d21cda4e2f9db2 ToList<T>(T[] array, Func <T, RC_b32e755d03dd085a4b975b8c0c7d4454> converter) {
  RL_d15db589ea4d1a0a05d21cda4e2f9db2 result = new RL_d15db589ea4d1a0a05d21cda4e2f9db2();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_d15db589ea4d1a0a05d21cda4e2f9db2 FromRestList<T>(RestList<T> restList, Func <T, RC_b32e755d03dd085a4b975b8c0c7d4454> converter) {
  RL_d15db589ea4d1a0a05d21cda4e2f9db2 result = new RL_d15db589ea4d1a0a05d21cda4e2f9db2();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_d15db589ea4d1a0a05d21cda4e2f9db2() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(4,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_b32e755d03dd085a4b975b8c0c7d4454> NewList() {
return new RL_d15db589ea4d1a0a05d21cda4e2f9db2();
}


} // RL_d15db589ea4d1a0a05d21cda4e2f9db2
}

