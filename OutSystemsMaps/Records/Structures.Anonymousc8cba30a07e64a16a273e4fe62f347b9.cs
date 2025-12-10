namespace ssOutSystemsMaps {
/// <summary>
/// [AnonymousStructure] Record (CqPLyOYHFkqic+T+YvNHuQ)
///  <code>RC_0b102c453446be3ebcb793be90d6b209</code> that represents <code>MarkerTypeRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: MarkerTypeRecord
public partial struct RC_0b102c453446be3ebcb793be90d6b209 : ITypedRecord<RC_0b102c453446be3ebcb793be90d6b209> {
internal static readonly GlobalObjectKey IdMarkerType = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*RSwQC0Y0Pr68t5O+kNayCQ");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("MarkerType")]
public EN_c3a74b883bf36717c1c549a2bbfbc0daEntityRecord ssENMarkerType;


public static implicit operator EN_c3a74b883bf36717c1c549a2bbfbc0daEntityRecord( RC_0b102c453446be3ebcb793be90d6b209 r) {
return r.ssENMarkerType;
}

public static implicit operator RC_0b102c453446be3ebcb793be90d6b209 (EN_c3a74b883bf36717c1c549a2bbfbc0daEntityRecord r) {
RC_0b102c453446be3ebcb793be90d6b209 res = new RC_0b102c453446be3ebcb793be90d6b209 ();
res.ssENMarkerType = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENMarkerType.ChangedAttributes = value;
}
get {
    return ssENMarkerType.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_0b102c453446be3ebcb793be90d6b209() {
OptimizedAttributes = null;
ssENMarkerType = new EN_c3a74b883bf36717c1c549a2bbfbc0daEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(1,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENMarkerType.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENMarkerType.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENMarkerType.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENMarkerType.Read( r, ref index);
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
public void ReadIM(RC_0b102c453446be3ebcb793be90d6b209 r) {
this = r;
}


public static bool operator == (RC_0b102c453446be3ebcb793be90d6b209 a, RC_0b102c453446be3ebcb793be90d6b209 b) {
if (a.ssENMarkerType != b.ssENMarkerType) return false;
return true;
}

public static bool operator != (RC_0b102c453446be3ebcb793be90d6b209 a, RC_0b102c453446be3ebcb793be90d6b209 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_0b102c453446be3ebcb793be90d6b209)) return false;
return (this == (RC_0b102c453446be3ebcb793be90d6b209)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENMarkerType.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENMarkerType.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENMarkerType.InternalRecursiveSave();
}


public RC_0b102c453446be3ebcb793be90d6b209 Duplicate() {
RC_0b102c453446be3ebcb793be90d6b209 t;
t.ssENMarkerType = (EN_c3a74b883bf36717c1c549a2bbfbc0daEntityRecord)this.ssENMarkerType.Duplicate();
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
if (head == "markertype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MarkerType")) variable.Value = ssENMarkerType; else variable.Optimized = true;
variable.SetFieldName("markertype");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENMarkerType.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENMarkerType.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdMarkerType) {
return ssENMarkerType;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdMarkerType.Key.AsGuid) {
return ssENMarkerType;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENMarkerType.FillFromOther((IRecord) other.AttributeGet(IdMarkerType));
}
} // RC_0b102c453446be3ebcb793be90d6b209
/// <summary>
/// RecordList type <code>MarkerTypeRecordList</code> that represents a record list of
///  <code>MarkerType</code>
/// </summary>
public partial class RL_2041355d498997d1657fdf428c3b452d : GenericRecordList<RC_0b102c453446be3ebcb793be90d6b209>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_0b102c453446be3ebcb793be90d6b209 GetElementDefaultValue() {
return new RC_0b102c453446be3ebcb793be90d6b209();
}

public T[] ToArray<T>(Func<RC_0b102c453446be3ebcb793be90d6b209, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_2041355d498997d1657fdf428c3b452d recordList, Func<RC_0b102c453446be3ebcb793be90d6b209, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_2041355d498997d1657fdf428c3b452d(RC_0b102c453446be3ebcb793be90d6b209[] array) {
  RL_2041355d498997d1657fdf428c3b452d result = new RL_2041355d498997d1657fdf428c3b452d();
result.InnerFromArray(array);
    return result;
}

public static RL_2041355d498997d1657fdf428c3b452d ToList<T>(T[] array, Func <T, RC_0b102c453446be3ebcb793be90d6b209> converter) {
  RL_2041355d498997d1657fdf428c3b452d result = new RL_2041355d498997d1657fdf428c3b452d();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_2041355d498997d1657fdf428c3b452d FromRestList<T>(RestList<T> restList, Func <T, RC_0b102c453446be3ebcb793be90d6b209> converter) {
  RL_2041355d498997d1657fdf428c3b452d result = new RL_2041355d498997d1657fdf428c3b452d();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_2041355d498997d1657fdf428c3b452d() : base() {
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
protected override OSList<RC_0b102c453446be3ebcb793be90d6b209> NewList() {
return new RL_2041355d498997d1657fdf428c3b452d();
}


} // RL_2041355d498997d1657fdf428c3b452d
}

