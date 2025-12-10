namespace ssOutSystemsMaps {
/// <summary>
/// [Structure] Offset (Vvpmd9jHNUqpUNrgJ9MmAw)
///  <code>ST_be62cc31fbe4705834275960beeb55e2Structure</code> that represents <code>Offset</code
/// > <p>Description: Expand the options to set the OffsetX(vertical) and OffsetY(horizontal) in
///  pixels, to apply on map. This will apply based on defined Location.</p>
/// </summary>
// Name: Offset
public partial struct ST_be62cc31fbe4705834275960beeb55e2Structure : ITypedRecord<ST_be62cc31fbe4705834275960beeb55e2Structure> {
internal static readonly GlobalObjectKey IdOffsetX = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*T6Qx6vlP3Eiw0Gh+pqvhGg");
internal static readonly GlobalObjectKey IdOffsetY = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*JDOHkYlUOEu8aQY6BEVvGQ");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("OffsetX")]
public int ssOffsetX;

[System.Xml.Serialization.XmlElement("OffsetY")]
public int ssOffsetY;


public BitArray OptimizedAttributes;

public ST_be62cc31fbe4705834275960beeb55e2Structure() {
OptimizedAttributes = null;
ssOffsetX = 0;
ssOffsetY = 0;
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
ssOffsetX = r.ReadInteger(index++, "Offset.OffsetX", 0);
ssOffsetY = r.ReadInteger(index++, "Offset.OffsetY", 0);
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
public void ReadIM(ST_be62cc31fbe4705834275960beeb55e2Structure r) {
this = r;
}


public static bool operator == (ST_be62cc31fbe4705834275960beeb55e2Structure a, ST_be62cc31fbe4705834275960beeb55e2Structure b) {
if (a.ssOffsetX != b.ssOffsetX) return false;
if (a.ssOffsetY != b.ssOffsetY) return false;
return true;
}

public static bool operator != (ST_be62cc31fbe4705834275960beeb55e2Structure a, ST_be62cc31fbe4705834275960beeb55e2Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_be62cc31fbe4705834275960beeb55e2Structure)) return false;
return (this == (ST_be62cc31fbe4705834275960beeb55e2Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssOffsetX.GetHashCode()
 ^ ssOffsetY.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_be62cc31fbe4705834275960beeb55e2Structure Duplicate() {
ST_be62cc31fbe4705834275960beeb55e2Structure t;
t.ssOffsetX = this.ssOffsetX;
t.ssOffsetY = this.ssOffsetY;
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
if (head == "offsetx") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OffsetX")) variable.Value = ssOffsetX; else variable.Optimized = true;
} else if (head == "offsety") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OffsetY")) variable.Value = ssOffsetY; else variable.Optimized = true;
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
if (key == IdOffsetX) {
return ssOffsetX;
}
if (key == IdOffsetY) {
return ssOffsetY;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOffsetX.Key.AsGuid) {
return ssOffsetX;
}
if (attributeKey == IdOffsetY.Key.AsGuid) {
return ssOffsetY;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssOffsetX = (int) other.AttributeGet(IdOffsetX);
ssOffsetY = (int) other.AttributeGet(IdOffsetY);
}
} // ST_be62cc31fbe4705834275960beeb55e2Structure
/// <summary>
/// RecordList type <code>OffsetList</code> that represents a record list of <code>Offset</code>
/// </summary>
public partial class RL_d082a22aaba2edcf587644f856c62a9a : GenericRecordList<ST_be62cc31fbe4705834275960beeb55e2Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_be62cc31fbe4705834275960beeb55e2Structure GetElementDefaultValue() {
return new ST_be62cc31fbe4705834275960beeb55e2Structure();
}

public T[] ToArray<T>(Func<ST_be62cc31fbe4705834275960beeb55e2Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_d082a22aaba2edcf587644f856c62a9a recordList, Func<ST_be62cc31fbe4705834275960beeb55e2Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_d082a22aaba2edcf587644f856c62a9a(ST_be62cc31fbe4705834275960beeb55e2Structure[] array) {
  RL_d082a22aaba2edcf587644f856c62a9a result = new RL_d082a22aaba2edcf587644f856c62a9a();
result.InnerFromArray(array);
    return result;
}

public static RL_d082a22aaba2edcf587644f856c62a9a ToList<T>(T[] array, Func <T, ST_be62cc31fbe4705834275960beeb55e2Structure> converter) {
  RL_d082a22aaba2edcf587644f856c62a9a result = new RL_d082a22aaba2edcf587644f856c62a9a();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_d082a22aaba2edcf587644f856c62a9a FromRestList<T>(RestList<T> restList, Func <T, ST_be62cc31fbe4705834275960beeb55e2Structure> converter) {
  RL_d082a22aaba2edcf587644f856c62a9a result = new RL_d082a22aaba2edcf587644f856c62a9a();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_d082a22aaba2edcf587644f856c62a9a() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_be62cc31fbe4705834275960beeb55e2Structure> NewList() {
return new RL_d082a22aaba2edcf587644f856c62a9a();
}


} // RL_d082a22aaba2edcf587644f856c62a9a
}

