namespace ssOutSystemsMaps {
/// <summary>
/// [AnonymousStructure] Record (Ldu9BEHlAkOVMJUYQ_nEBg)
///  <code>RC_992836b5ddde04d0d91f0c87e7233524</code> that represents <code>MapTypeRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: MapTypeRecord
public partial struct RC_992836b5ddde04d0d91f0c87e7233524 : ITypedRecord<RC_992836b5ddde04d0d91f0c87e7233524> {
internal static readonly GlobalObjectKey IdMapType = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*tTYomd7d0ATZHwyH5yM1JA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("MapType")]
public EN_0df198ce2d64e9aa6113403a9d3f7309EntityRecord ssENMapType;


public static implicit operator EN_0df198ce2d64e9aa6113403a9d3f7309EntityRecord( RC_992836b5ddde04d0d91f0c87e7233524 r) {
return r.ssENMapType;
}

public static implicit operator RC_992836b5ddde04d0d91f0c87e7233524 (EN_0df198ce2d64e9aa6113403a9d3f7309EntityRecord r) {
RC_992836b5ddde04d0d91f0c87e7233524 res = new RC_992836b5ddde04d0d91f0c87e7233524 ();
res.ssENMapType = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENMapType.ChangedAttributes = value;
}
get {
    return ssENMapType.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_992836b5ddde04d0d91f0c87e7233524() {
OptimizedAttributes = null;
ssENMapType = new EN_0df198ce2d64e9aa6113403a9d3f7309EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(1,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENMapType.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENMapType.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENMapType.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENMapType.Read( r, ref index);
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
public void ReadIM(RC_992836b5ddde04d0d91f0c87e7233524 r) {
this = r;
}


public static bool operator == (RC_992836b5ddde04d0d91f0c87e7233524 a, RC_992836b5ddde04d0d91f0c87e7233524 b) {
if (a.ssENMapType != b.ssENMapType) return false;
return true;
}

public static bool operator != (RC_992836b5ddde04d0d91f0c87e7233524 a, RC_992836b5ddde04d0d91f0c87e7233524 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_992836b5ddde04d0d91f0c87e7233524)) return false;
return (this == (RC_992836b5ddde04d0d91f0c87e7233524)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENMapType.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENMapType.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENMapType.InternalRecursiveSave();
}


public RC_992836b5ddde04d0d91f0c87e7233524 Duplicate() {
RC_992836b5ddde04d0d91f0c87e7233524 t;
t.ssENMapType = (EN_0df198ce2d64e9aa6113403a9d3f7309EntityRecord)this.ssENMapType.Duplicate();
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
if (head == "maptype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MapType")) variable.Value = ssENMapType; else variable.Optimized = true;
variable.SetFieldName("maptype");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENMapType.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENMapType.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdMapType) {
return ssENMapType;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdMapType.Key.AsGuid) {
return ssENMapType;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENMapType.FillFromOther((IRecord) other.AttributeGet(IdMapType));
}
} // RC_992836b5ddde04d0d91f0c87e7233524
/// <summary>
/// RecordList type <code>MapTypeRecordList</code> that represents a record list of
///  <code>MapType</code>
/// </summary>
public partial class RL_5982f8687c5ac946ae2cbaf319e43b9f : GenericRecordList<RC_992836b5ddde04d0d91f0c87e7233524>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_992836b5ddde04d0d91f0c87e7233524 GetElementDefaultValue() {
return new RC_992836b5ddde04d0d91f0c87e7233524();
}

public T[] ToArray<T>(Func<RC_992836b5ddde04d0d91f0c87e7233524, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_5982f8687c5ac946ae2cbaf319e43b9f recordList, Func<RC_992836b5ddde04d0d91f0c87e7233524, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_5982f8687c5ac946ae2cbaf319e43b9f(RC_992836b5ddde04d0d91f0c87e7233524[] array) {
  RL_5982f8687c5ac946ae2cbaf319e43b9f result = new RL_5982f8687c5ac946ae2cbaf319e43b9f();
result.InnerFromArray(array);
    return result;
}

public static RL_5982f8687c5ac946ae2cbaf319e43b9f ToList<T>(T[] array, Func <T, RC_992836b5ddde04d0d91f0c87e7233524> converter) {
  RL_5982f8687c5ac946ae2cbaf319e43b9f result = new RL_5982f8687c5ac946ae2cbaf319e43b9f();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_5982f8687c5ac946ae2cbaf319e43b9f FromRestList<T>(RestList<T> restList, Func <T, RC_992836b5ddde04d0d91f0c87e7233524> converter) {
  RL_5982f8687c5ac946ae2cbaf319e43b9f result = new RL_5982f8687c5ac946ae2cbaf319e43b9f();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_5982f8687c5ac946ae2cbaf319e43b9f() : base() {
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
protected override OSList<RC_992836b5ddde04d0d91f0c87e7233524> NewList() {
return new RL_5982f8687c5ac946ae2cbaf319e43b9f();
}


} // RL_5982f8687c5ac946ae2cbaf319e43b9f
}

