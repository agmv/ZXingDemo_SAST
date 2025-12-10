namespace ssOutSystemsMaps {
/// <summary>
/// [Structure] Private_MarkerClusterer (NQRHSfAuYkKi0eeoMaEvzA)
///  <code>ST_9f8ac95fe4e47e327de12de1b56bed45Structure</code> that represent
/// s <code>Private_MarkerClusterer</code> <p>Description: Allows you to aggregate markers of close
///  proximity into gropus and to simplify the display of markers on the map.</p>
/// </summary>
// Name: Private_MarkerClusterer
public partial struct ST_9f8ac95fe4e47e327de12de1b56bed45Structure : ITypedRecord<ST_9f8ac95fe4e47e327de12de1b56bed45Structure> {
internal static readonly GlobalObjectKey IdActive = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*Y43u8dIBxU+rtIONOiBXew");
internal static readonly GlobalObjectKey IdMaxZoom = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*ThEyMI+UakO_FWkPHeaZ2A");
internal static readonly GlobalObjectKey IdZoomOnClick = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*HWCbyFIyyEex6flU86jilQ");
internal static readonly GlobalObjectKey IdMinClusterSize = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*wJ3j6S_180qMRRkIlSNYPA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Active")]
public bool ssActive;

[System.Xml.Serialization.XmlElement("MaxZoom")]
public int ssMaxZoom;

[System.Xml.Serialization.XmlElement("ZoomOnClick")]
public bool ssZoomOnClick;

[System.Xml.Serialization.XmlElement("MinClusterSize")]
public int ssMinClusterSize;


public BitArray OptimizedAttributes;

public ST_9f8ac95fe4e47e327de12de1b56bed45Structure() {
OptimizedAttributes = null;
ssActive = false;
ssMaxZoom = 0;
ssZoomOnClick = true;
ssMinClusterSize = 2;
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
ssActive = r.ReadBoolean(index++, "Private_MarkerClusterer.Active", false);
ssMaxZoom = r.ReadEntityReference(index++, "Private_MarkerClusterer.MaxZoom", 0);
ssZoomOnClick = r.ReadBoolean(index++, "Private_MarkerClusterer.ZoomOnClick", false);
ssMinClusterSize = r.ReadInteger(index++, "Private_MarkerClusterer.MinClusterSize", 0);
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
public void ReadIM(ST_9f8ac95fe4e47e327de12de1b56bed45Structure r) {
this = r;
}


public static bool operator == (ST_9f8ac95fe4e47e327de12de1b56bed45Structure a, ST_9f8ac95fe4e47e327de12de1b56bed45Structure b) {
if (a.ssActive != b.ssActive) return false;
if (a.ssMaxZoom != b.ssMaxZoom) return false;
if (a.ssZoomOnClick != b.ssZoomOnClick) return false;
if (a.ssMinClusterSize != b.ssMinClusterSize) return false;
return true;
}

public static bool operator != (ST_9f8ac95fe4e47e327de12de1b56bed45Structure a, ST_9f8ac95fe4e47e327de12de1b56bed45Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_9f8ac95fe4e47e327de12de1b56bed45Structure)) return false;
return (this == (ST_9f8ac95fe4e47e327de12de1b56bed45Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssActive.GetHashCode()
 ^ ssMaxZoom.GetHashCode()
 ^ ssZoomOnClick.GetHashCode()
 ^ ssMinClusterSize.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_9f8ac95fe4e47e327de12de1b56bed45Structure Duplicate() {
ST_9f8ac95fe4e47e327de12de1b56bed45Structure t;
t.ssActive = this.ssActive;
t.ssMaxZoom = this.ssMaxZoom;
t.ssZoomOnClick = this.ssZoomOnClick;
t.ssMinClusterSize = this.ssMinClusterSize;
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
if (head == "active") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Active")) variable.Value = ssActive; else variable.Optimized = true;
} else if (head == "maxzoom") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MaxZoom")) variable.Value = ssMaxZoom; else variable.Optimized = true;
} else if (head == "zoomonclick") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ZoomOnClick")) variable.Value = ssZoomOnClick; else variable.Optimized = true;
} else if (head == "minclustersize") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MinClusterSize")) variable.Value = ssMinClusterSize; else variable.Optimized = true;
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
if (key == IdActive) {
return ssActive;
}
if (key == IdMaxZoom) {
return ssMaxZoom;
}
if (key == IdZoomOnClick) {
return ssZoomOnClick;
}
if (key == IdMinClusterSize) {
return ssMinClusterSize;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdActive.Key.AsGuid) {
return ssActive;
}
if (attributeKey == IdMaxZoom.Key.AsGuid) {
return ssMaxZoom;
}
if (attributeKey == IdZoomOnClick.Key.AsGuid) {
return ssZoomOnClick;
}
if (attributeKey == IdMinClusterSize.Key.AsGuid) {
return ssMinClusterSize;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssActive = (bool) other.AttributeGet(IdActive);
ssMaxZoom = (int) other.AttributeGet(IdMaxZoom);
ssZoomOnClick = (bool) other.AttributeGet(IdZoomOnClick);
ssMinClusterSize = (int) other.AttributeGet(IdMinClusterSize);
}
} // ST_9f8ac95fe4e47e327de12de1b56bed45Structure
/// <summary>
/// RecordList type <code>Private_MarkerClustererList</code> that represents a record list of
///  <code>Private_MarkerClusterer</code>
/// </summary>
public partial class RL_d44d85a1d6577bb886dcdf90ca46f0a1 : GenericRecordList<ST_9f8ac95fe4e47e327de12de1b56bed45Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_9f8ac95fe4e47e327de12de1b56bed45Structure GetElementDefaultValue() {
return new ST_9f8ac95fe4e47e327de12de1b56bed45Structure();
}

public T[] ToArray<T>(Func<ST_9f8ac95fe4e47e327de12de1b56bed45Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_d44d85a1d6577bb886dcdf90ca46f0a1 recordList, Func<ST_9f8ac95fe4e47e327de12de1b56bed45Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_d44d85a1d6577bb886dcdf90ca46f0a1(ST_9f8ac95fe4e47e327de12de1b56bed45Structure[] array) {
  RL_d44d85a1d6577bb886dcdf90ca46f0a1 result = new RL_d44d85a1d6577bb886dcdf90ca46f0a1();
result.InnerFromArray(array);
    return result;
}

public static RL_d44d85a1d6577bb886dcdf90ca46f0a1 ToList<T>(T[] array, Func <T, ST_9f8ac95fe4e47e327de12de1b56bed45Structure> converter) {
  RL_d44d85a1d6577bb886dcdf90ca46f0a1 result = new RL_d44d85a1d6577bb886dcdf90ca46f0a1();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_d44d85a1d6577bb886dcdf90ca46f0a1 FromRestList<T>(RestList<T> restList, Func <T, ST_9f8ac95fe4e47e327de12de1b56bed45Structure> converter) {
  RL_d44d85a1d6577bb886dcdf90ca46f0a1 result = new RL_d44d85a1d6577bb886dcdf90ca46f0a1();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_d44d85a1d6577bb886dcdf90ca46f0a1() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_9f8ac95fe4e47e327de12de1b56bed45Structure> NewList() {
return new RL_d44d85a1d6577bb886dcdf90ca46f0a1();
}


} // RL_d44d85a1d6577bb886dcdf90ca46f0a1
}

