namespace ssOutSystemsMaps {
/// <summary>
/// [AnonymousStructure] Record (Bi9eBmnaE0CGNm72zCE3EA)
///  <code>RC_df0786951d2357ea5f13ac02dccd68c2</code> that represents <code>LatLngRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: LatLngRecord
public partial struct RC_df0786951d2357ea5f13ac02dccd68c2 : ITypedRecord<RC_df0786951d2357ea5f13ac02dccd68c2> {
internal static readonly GlobalObjectKey IdLat = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*wLUT7UDCAuIjLg9Nj3hcvA");
internal static readonly GlobalObjectKey IdLng = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NIVc4O5cz4oCWuMS6Iq7mw");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Lat")]
public decimal ssLat;

[System.Xml.Serialization.XmlElement("Lng")]
public decimal ssLng;


public BitArray OptimizedAttributes;

public RC_df0786951d2357ea5f13ac02dccd68c2() {
OptimizedAttributes = null;
ssLat = 0.0M;
ssLng = 0.0M;
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[0];
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    }
}
get{
    BitArray[] all = new BitArray[0];
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssLat = r.ReadDecimal(index++, "LatLngRecord.Lat", 0.0M);
ssLng = r.ReadDecimal(index++, "LatLngRecord.Lng", 0.0M);
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
public void ReadIM(RC_df0786951d2357ea5f13ac02dccd68c2 r) {
this = r;
}


public static bool operator == (RC_df0786951d2357ea5f13ac02dccd68c2 a, RC_df0786951d2357ea5f13ac02dccd68c2 b) {
if (a.ssLat != b.ssLat) return false;
if (a.ssLng != b.ssLng) return false;
return true;
}

public static bool operator != (RC_df0786951d2357ea5f13ac02dccd68c2 a, RC_df0786951d2357ea5f13ac02dccd68c2 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_df0786951d2357ea5f13ac02dccd68c2)) return false;
return (this == (RC_df0786951d2357ea5f13ac02dccd68c2)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssLat.GetHashCode()
 ^ ssLng.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public RC_df0786951d2357ea5f13ac02dccd68c2 Duplicate() {
RC_df0786951d2357ea5f13ac02dccd68c2 t;
t.ssLat = this.ssLat;
t.ssLng = this.ssLng;
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
if (head == "lat") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Lat")) variable.Value = ssLat; else variable.Optimized = true;
} else if (head == "lng") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Lng")) variable.Value = ssLng; else variable.Optimized = true;
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
if (key == IdLat) {
return ssLat;
}
if (key == IdLng) {
return ssLng;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdLat.Key.AsGuid) {
return ssLat;
}
if (attributeKey == IdLng.Key.AsGuid) {
return ssLng;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssLat = (decimal) other.AttributeGet(IdLat);
ssLng = (decimal) other.AttributeGet(IdLng);
}
} // RC_df0786951d2357ea5f13ac02dccd68c2
/// <summary>
/// RecordList type <code>LatLngRecordList</code> that represents a record list of <code>Decimal,
///  Decimal</code>
/// </summary>
public partial class RL_9cb21d90c5001a7c161a10beb1618d1c : GenericRecordList<RC_df0786951d2357ea5f13ac02dccd68c2>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_df0786951d2357ea5f13ac02dccd68c2 GetElementDefaultValue() {
return new RC_df0786951d2357ea5f13ac02dccd68c2();
}

public T[] ToArray<T>(Func<RC_df0786951d2357ea5f13ac02dccd68c2, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_9cb21d90c5001a7c161a10beb1618d1c recordList, Func<RC_df0786951d2357ea5f13ac02dccd68c2, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_9cb21d90c5001a7c161a10beb1618d1c(RC_df0786951d2357ea5f13ac02dccd68c2[] array) {
  RL_9cb21d90c5001a7c161a10beb1618d1c result = new RL_9cb21d90c5001a7c161a10beb1618d1c();
result.InnerFromArray(array);
    return result;
}

public static RL_9cb21d90c5001a7c161a10beb1618d1c ToList<T>(T[] array, Func <T, RC_df0786951d2357ea5f13ac02dccd68c2> converter) {
  RL_9cb21d90c5001a7c161a10beb1618d1c result = new RL_9cb21d90c5001a7c161a10beb1618d1c();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_9cb21d90c5001a7c161a10beb1618d1c FromRestList<T>(RestList<T> restList, Func <T, RC_df0786951d2357ea5f13ac02dccd68c2> converter) {
  RL_9cb21d90c5001a7c161a10beb1618d1c result = new RL_9cb21d90c5001a7c161a10beb1618d1c();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_9cb21d90c5001a7c161a10beb1618d1c() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_df0786951d2357ea5f13ac02dccd68c2> NewList() {
return new RL_9cb21d90c5001a7c161a10beb1618d1c();
}


} // RL_9cb21d90c5001a7c161a10beb1618d1c
}

