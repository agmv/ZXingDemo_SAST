namespace ssZXingLibDemo {
/// <summary>
/// [ReferenceStructure] MarkerClusterer (d5A5nfua_UOySWPZb5vtLw)
///  <code>ST_30625b4ad0f3e10abf82b61ea58e8644Structure</code> that represent
/// s <code>MarkerClusterer</code> <p>Description: Allows you to aggregate markers of close proximity
///  into gropus and to simplify the display of markers on the map.</p>
/// </summary>
// Name: MarkerClusterer
public partial struct ST_30625b4ad0f3e10abf82b61ea58e8644Structure : ITypedRecord<ST_30625b4ad0f3e10abf82b61ea58e8644Structure> {
internal static readonly GlobalObjectKey IdActive = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*4BSApjJf5UyYoF7teaM44A");
internal static readonly GlobalObjectKey IdMaxZoom = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*6u1oNMQJgUmGSYaXe9bFGg");
internal static readonly GlobalObjectKey IdZoomOnClick = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*RC7XsKLJukKC905HmKJOIA");
internal static readonly GlobalObjectKey IdMinClusterSize = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*a8wn2GYxQUmM3a71kN48LA");

public static void EnsureInitialized(){}

static ST_30625b4ad0f3e10abf82b61ea58e8644Structure() {
ST_30625b4ad0f3e10abf82b61ea58e8644StructureTypeFactoryImpl.InitializeFactory();
}
[System.Xml.Serialization.XmlElement("Active")]
public bool ssActive;

[System.Xml.Serialization.XmlElement("MaxZoom")]
public int ssMaxZoom;

[System.Xml.Serialization.XmlElement("ZoomOnClick")]
public bool ssZoomOnClick;

[System.Xml.Serialization.XmlElement("MinClusterSize")]
public int ssMinClusterSize;


public BitArray OptimizedAttributes;

public ST_30625b4ad0f3e10abf82b61ea58e8644Structure() {
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
ssActive = r.ReadBoolean(index++, "MarkerClusterer.Active", false);
ssMaxZoom = r.ReadEntityReference(index++, "MarkerClusterer.MaxZoom", 0);
ssZoomOnClick = r.ReadBoolean(index++, "MarkerClusterer.ZoomOnClick", false);
ssMinClusterSize = r.ReadInteger(index++, "MarkerClusterer.MinClusterSize", 0);
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
public void ReadIM(ST_30625b4ad0f3e10abf82b61ea58e8644Structure r) {
this = r;
}


public static bool operator == (ST_30625b4ad0f3e10abf82b61ea58e8644Structure a, ST_30625b4ad0f3e10abf82b61ea58e8644Structure b) {
if (a.ssActive != b.ssActive) return false;
if (a.ssMaxZoom != b.ssMaxZoom) return false;
if (a.ssZoomOnClick != b.ssZoomOnClick) return false;
if (a.ssMinClusterSize != b.ssMinClusterSize) return false;
return true;
}

public static bool operator != (ST_30625b4ad0f3e10abf82b61ea58e8644Structure a, ST_30625b4ad0f3e10abf82b61ea58e8644Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_30625b4ad0f3e10abf82b61ea58e8644Structure)) return false;
return (this == (ST_30625b4ad0f3e10abf82b61ea58e8644Structure)o);
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


public ST_30625b4ad0f3e10abf82b61ea58e8644Structure Duplicate() {
ST_30625b4ad0f3e10abf82b61ea58e8644Structure t;
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
} // ST_30625b4ad0f3e10abf82b61ea58e8644Structure
/// <summary>
/// RecordList type <code>MarkerClustererList</code> that represents a record list of
///  <code>MarkerClusterer</code>
/// </summary>
public partial class RL_0bcd3c98d22adfc3203704c950fffba0 : GenericRecordList<ST_30625b4ad0f3e10abf82b61ea58e8644Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_30625b4ad0f3e10abf82b61ea58e8644Structure GetElementDefaultValue() {
return new ST_30625b4ad0f3e10abf82b61ea58e8644Structure();
}

public T[] ToArray<T>(Func<ST_30625b4ad0f3e10abf82b61ea58e8644Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_0bcd3c98d22adfc3203704c950fffba0 recordList, Func<ST_30625b4ad0f3e10abf82b61ea58e8644Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_0bcd3c98d22adfc3203704c950fffba0(ST_30625b4ad0f3e10abf82b61ea58e8644Structure[] array) {
  RL_0bcd3c98d22adfc3203704c950fffba0 result = new RL_0bcd3c98d22adfc3203704c950fffba0();
result.InnerFromArray(array);
    return result;
}

public static RL_0bcd3c98d22adfc3203704c950fffba0 ToList<T>(T[] array, Func <T, ST_30625b4ad0f3e10abf82b61ea58e8644Structure> converter) {
  RL_0bcd3c98d22adfc3203704c950fffba0 result = new RL_0bcd3c98d22adfc3203704c950fffba0();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_0bcd3c98d22adfc3203704c950fffba0 FromRestList<T>(RestList<T> restList, Func <T, ST_30625b4ad0f3e10abf82b61ea58e8644Structure> converter) {
  RL_0bcd3c98d22adfc3203704c950fffba0 result = new RL_0bcd3c98d22adfc3203704c950fffba0();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_0bcd3c98d22adfc3203704c950fffba0() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_30625b4ad0f3e10abf82b61ea58e8644Structure> NewList() {
return new RL_0bcd3c98d22adfc3203704c950fffba0();
}


} // RL_0bcd3c98d22adfc3203704c950fffba0
}

