namespace ssOutSystemsMaps {
/// <summary>
/// [Structure] Coordinates (WZx1aHJQ0UWsUfXtv2pX2w)
///  <code>ST_0e474756a4be14d378c73cd05f602bcdStructure</code> that represents <code>Coordinates</code
/// > <p>Description: Coordinates indicate the Latitude and Longitude and will be filled in this
///  parameter.</p>
/// </summary>
// Name: Coordinates
public partial struct ST_0e474756a4be14d378c73cd05f602bcdStructure : ITypedRecord<ST_0e474756a4be14d378c73cd05f602bcdStructure> {
internal static readonly GlobalObjectKey IdLat = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*LuFnNKJEWk6fr+sv0L8Qng");
internal static readonly GlobalObjectKey IdLng = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*fpXfZdWarUyYGRD0uxgbLA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Lat")]
public decimal ssLat;

[System.Xml.Serialization.XmlElement("Lng")]
public decimal ssLng;


public BitArray OptimizedAttributes;

public ST_0e474756a4be14d378c73cd05f602bcdStructure() {
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
ssLat = r.ReadDecimal(index++, "Coordinates.Lat", 0.0M);
ssLng = r.ReadDecimal(index++, "Coordinates.Lng", 0.0M);
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
public void ReadIM(ST_0e474756a4be14d378c73cd05f602bcdStructure r) {
this = r;
}


public static bool operator == (ST_0e474756a4be14d378c73cd05f602bcdStructure a, ST_0e474756a4be14d378c73cd05f602bcdStructure b) {
if (a.ssLat != b.ssLat) return false;
if (a.ssLng != b.ssLng) return false;
return true;
}

public static bool operator != (ST_0e474756a4be14d378c73cd05f602bcdStructure a, ST_0e474756a4be14d378c73cd05f602bcdStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_0e474756a4be14d378c73cd05f602bcdStructure)) return false;
return (this == (ST_0e474756a4be14d378c73cd05f602bcdStructure)o);
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


public ST_0e474756a4be14d378c73cd05f602bcdStructure Duplicate() {
ST_0e474756a4be14d378c73cd05f602bcdStructure t;
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
} // ST_0e474756a4be14d378c73cd05f602bcdStructure
/// <summary>
/// RecordList type <code>CoordinatesList</code> that represents a record list of
///  <code>Coordinates</code>
/// </summary>
public partial class RL_7d169bd7c22bd4fc5143477f3a7cef9a : GenericRecordList<ST_0e474756a4be14d378c73cd05f602bcdStructure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_0e474756a4be14d378c73cd05f602bcdStructure GetElementDefaultValue() {
return new ST_0e474756a4be14d378c73cd05f602bcdStructure();
}

public T[] ToArray<T>(Func<ST_0e474756a4be14d378c73cd05f602bcdStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_7d169bd7c22bd4fc5143477f3a7cef9a recordList, Func<ST_0e474756a4be14d378c73cd05f602bcdStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_7d169bd7c22bd4fc5143477f3a7cef9a(ST_0e474756a4be14d378c73cd05f602bcdStructure[] array) {
  RL_7d169bd7c22bd4fc5143477f3a7cef9a result = new RL_7d169bd7c22bd4fc5143477f3a7cef9a();
result.InnerFromArray(array);
    return result;
}

public static RL_7d169bd7c22bd4fc5143477f3a7cef9a ToList<T>(T[] array, Func <T, ST_0e474756a4be14d378c73cd05f602bcdStructure> converter) {
  RL_7d169bd7c22bd4fc5143477f3a7cef9a result = new RL_7d169bd7c22bd4fc5143477f3a7cef9a();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_7d169bd7c22bd4fc5143477f3a7cef9a FromRestList<T>(RestList<T> restList, Func <T, ST_0e474756a4be14d378c73cd05f602bcdStructure> converter) {
  RL_7d169bd7c22bd4fc5143477f3a7cef9a result = new RL_7d169bd7c22bd4fc5143477f3a7cef9a();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_7d169bd7c22bd4fc5143477f3a7cef9a() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_0e474756a4be14d378c73cd05f602bcdStructure> NewList() {
return new RL_7d169bd7c22bd4fc5143477f3a7cef9a();
}


} // RL_7d169bd7c22bd4fc5143477f3a7cef9a
}

