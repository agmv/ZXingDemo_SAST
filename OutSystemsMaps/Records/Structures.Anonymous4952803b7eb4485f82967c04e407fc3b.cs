namespace ssOutSystemsMaps {
/// <summary>
/// [AnonymousStructure] Record (O4BSSbR+X0iClnwE5Af8Ow)
///  <code>RC_bff46e9299d53c31f52181ed865bd729</code> that represents <code>MarkerRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: MarkerRecord
public partial struct RC_bff46e9299d53c31f52181ed865bd729 : ITypedRecord<RC_bff46e9299d53c31f52181ed865bd729> {
internal static readonly GlobalObjectKey IdMarker = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*km70v9WZMTz1IYHthlvXKQ");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Marker")]
public ST_5a7ef7acf3b11e0c41074aefa2466f75Structure ssSTMarker;


public static implicit operator ST_5a7ef7acf3b11e0c41074aefa2466f75Structure( RC_bff46e9299d53c31f52181ed865bd729 r) {
return r.ssSTMarker;
}

public static implicit operator RC_bff46e9299d53c31f52181ed865bd729 (ST_5a7ef7acf3b11e0c41074aefa2466f75Structure r) {
RC_bff46e9299d53c31f52181ed865bd729 res = new RC_bff46e9299d53c31f52181ed865bd729 ();
res.ssSTMarker = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_bff46e9299d53c31f52181ed865bd729() {
OptimizedAttributes = null;
ssSTMarker = new ST_5a7ef7acf3b11e0c41074aefa2466f75Structure();
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
    ssSTMarker.OptimizedAttributes = value[0];
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
ssSTMarker.Read( r, ref index);
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
public void ReadIM(RC_bff46e9299d53c31f52181ed865bd729 r) {
this = r;
}


public static bool operator == (RC_bff46e9299d53c31f52181ed865bd729 a, RC_bff46e9299d53c31f52181ed865bd729 b) {
if (a.ssSTMarker != b.ssSTMarker) return false;
return true;
}

public static bool operator != (RC_bff46e9299d53c31f52181ed865bd729 a, RC_bff46e9299d53c31f52181ed865bd729 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_bff46e9299d53c31f52181ed865bd729)) return false;
return (this == (RC_bff46e9299d53c31f52181ed865bd729)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTMarker.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTMarker.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTMarker.InternalRecursiveSave();
}


public RC_bff46e9299d53c31f52181ed865bd729 Duplicate() {
RC_bff46e9299d53c31f52181ed865bd729 t;
t.ssSTMarker = (ST_5a7ef7acf3b11e0c41074aefa2466f75Structure)this.ssSTMarker.Duplicate();
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
if (head == "marker") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Marker")) variable.Value = ssSTMarker; else variable.Optimized = true;
variable.SetFieldName("marker");
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
if (key == IdMarker) {
return ssSTMarker;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdMarker.Key.AsGuid) {
return ssSTMarker;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTMarker.FillFromOther((IRecord) other.AttributeGet(IdMarker));
}
} // RC_bff46e9299d53c31f52181ed865bd729
/// <summary>
/// RecordList type <code>MarkerRecordList</code> that represents a record list of <code>Marker</code>
/// </summary>
public partial class RL_8258d5e6cd03d65a1d22f35ea70607e2 : GenericRecordList<RC_bff46e9299d53c31f52181ed865bd729>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_bff46e9299d53c31f52181ed865bd729 GetElementDefaultValue() {
return new RC_bff46e9299d53c31f52181ed865bd729();
}

public T[] ToArray<T>(Func<RC_bff46e9299d53c31f52181ed865bd729, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_8258d5e6cd03d65a1d22f35ea70607e2 recordList, Func<RC_bff46e9299d53c31f52181ed865bd729, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_8258d5e6cd03d65a1d22f35ea70607e2(RC_bff46e9299d53c31f52181ed865bd729[] array) {
  RL_8258d5e6cd03d65a1d22f35ea70607e2 result = new RL_8258d5e6cd03d65a1d22f35ea70607e2();
result.InnerFromArray(array);
    return result;
}

public static RL_8258d5e6cd03d65a1d22f35ea70607e2 ToList<T>(T[] array, Func <T, RC_bff46e9299d53c31f52181ed865bd729> converter) {
  RL_8258d5e6cd03d65a1d22f35ea70607e2 result = new RL_8258d5e6cd03d65a1d22f35ea70607e2();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_8258d5e6cd03d65a1d22f35ea70607e2 FromRestList<T>(RestList<T> restList, Func <T, RC_bff46e9299d53c31f52181ed865bd729> converter) {
  RL_8258d5e6cd03d65a1d22f35ea70607e2 result = new RL_8258d5e6cd03d65a1d22f35ea70607e2();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_8258d5e6cd03d65a1d22f35ea70607e2() : base() {
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
protected override OSList<RC_bff46e9299d53c31f52181ed865bd729> NewList() {
return new RL_8258d5e6cd03d65a1d22f35ea70607e2();
}


} // RL_8258d5e6cd03d65a1d22f35ea70607e2
}

