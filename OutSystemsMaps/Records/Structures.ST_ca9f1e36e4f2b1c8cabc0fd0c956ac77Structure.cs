namespace ssOutSystemsMaps {
/// <summary>
/// [Structure] Points (0elbRAbFrkOKVAIEVD_IPg)
///  <code>ST_ca9f1e36e4f2b1c8cabc0fd0c956ac77Structure</code> that represents <code>Points</code
/// > <p>Description: List of heatmap data points.</p>
/// </summary>
// Name: Points
public partial struct ST_ca9f1e36e4f2b1c8cabc0fd0c956ac77Structure : ITypedRecord<ST_ca9f1e36e4f2b1c8cabc0fd0c956ac77Structure> {
internal static readonly GlobalObjectKey IdLat = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*oq2vM+i9Xk+GZ9tXCAcNtg");
internal static readonly GlobalObjectKey IdLng = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*emwSLqW2kEqy4fyX55bMpQ");
internal static readonly GlobalObjectKey IdWeight = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*GnerN100HkKgd1UVvGQdIA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Lat")]
public decimal ssLat;

[System.Xml.Serialization.XmlElement("Lng")]
public decimal ssLng;

[System.Xml.Serialization.XmlElement("Weight")]
public decimal ssWeight;


public BitArray OptimizedAttributes;

public ST_ca9f1e36e4f2b1c8cabc0fd0c956ac77Structure() {
OptimizedAttributes = null;
ssLat = 0.0M;
ssLng = 0.0M;
ssWeight = 1.0m;
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
ssLat = r.ReadDecimal(index++, "Points.Lat", 0.0M);
ssLng = r.ReadDecimal(index++, "Points.Lng", 0.0M);
ssWeight = r.ReadDecimal(index++, "Points.Weight", 0.0M);
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
public void ReadIM(ST_ca9f1e36e4f2b1c8cabc0fd0c956ac77Structure r) {
this = r;
}


public static bool operator == (ST_ca9f1e36e4f2b1c8cabc0fd0c956ac77Structure a, ST_ca9f1e36e4f2b1c8cabc0fd0c956ac77Structure b) {
if (a.ssLat != b.ssLat) return false;
if (a.ssLng != b.ssLng) return false;
if (a.ssWeight != b.ssWeight) return false;
return true;
}

public static bool operator != (ST_ca9f1e36e4f2b1c8cabc0fd0c956ac77Structure a, ST_ca9f1e36e4f2b1c8cabc0fd0c956ac77Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_ca9f1e36e4f2b1c8cabc0fd0c956ac77Structure)) return false;
return (this == (ST_ca9f1e36e4f2b1c8cabc0fd0c956ac77Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssLat.GetHashCode()
 ^ ssLng.GetHashCode()
 ^ ssWeight.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_ca9f1e36e4f2b1c8cabc0fd0c956ac77Structure Duplicate() {
ST_ca9f1e36e4f2b1c8cabc0fd0c956ac77Structure t;
t.ssLat = this.ssLat;
t.ssLng = this.ssLng;
t.ssWeight = this.ssWeight;
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
} else if (head == "weight") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Weight")) variable.Value = ssWeight; else variable.Optimized = true;
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
if (key == IdWeight) {
return ssWeight;
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
if (attributeKey == IdWeight.Key.AsGuid) {
return ssWeight;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssLat = (decimal) other.AttributeGet(IdLat);
ssLng = (decimal) other.AttributeGet(IdLng);
ssWeight = (decimal) other.AttributeGet(IdWeight);
}
} // ST_ca9f1e36e4f2b1c8cabc0fd0c956ac77Structure
/// <summary>
/// RecordList type <code>PointsList</code> that represents a record list of <code>Points</code>
/// </summary>
public partial class RL_3e9d003efe19bfd5edf008a600c8d3af : GenericRecordList<ST_ca9f1e36e4f2b1c8cabc0fd0c956ac77Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_ca9f1e36e4f2b1c8cabc0fd0c956ac77Structure GetElementDefaultValue() {
return new ST_ca9f1e36e4f2b1c8cabc0fd0c956ac77Structure();
}

public T[] ToArray<T>(Func<ST_ca9f1e36e4f2b1c8cabc0fd0c956ac77Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_3e9d003efe19bfd5edf008a600c8d3af recordList, Func<ST_ca9f1e36e4f2b1c8cabc0fd0c956ac77Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_3e9d003efe19bfd5edf008a600c8d3af(ST_ca9f1e36e4f2b1c8cabc0fd0c956ac77Structure[] array) {
  RL_3e9d003efe19bfd5edf008a600c8d3af result = new RL_3e9d003efe19bfd5edf008a600c8d3af();
result.InnerFromArray(array);
    return result;
}

public static RL_3e9d003efe19bfd5edf008a600c8d3af ToList<T>(T[] array, Func <T, ST_ca9f1e36e4f2b1c8cabc0fd0c956ac77Structure> converter) {
  RL_3e9d003efe19bfd5edf008a600c8d3af result = new RL_3e9d003efe19bfd5edf008a600c8d3af();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_3e9d003efe19bfd5edf008a600c8d3af FromRestList<T>(RestList<T> restList, Func <T, ST_ca9f1e36e4f2b1c8cabc0fd0c956ac77Structure> converter) {
  RL_3e9d003efe19bfd5edf008a600c8d3af result = new RL_3e9d003efe19bfd5edf008a600c8d3af();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_3e9d003efe19bfd5edf008a600c8d3af() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_ca9f1e36e4f2b1c8cabc0fd0c956ac77Structure> NewList() {
return new RL_3e9d003efe19bfd5edf008a600c8d3af();
}


} // RL_3e9d003efe19bfd5edf008a600c8d3af
}

