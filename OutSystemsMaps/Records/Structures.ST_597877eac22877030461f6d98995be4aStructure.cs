namespace ssOutSystemsMaps {
/// <summary>
/// [Structure] OptionalLeafletMapConfigs (jYtHonLdqU6KCvSh0FMlSA)
///  <code>ST_597877eac22877030461f6d98995be4aStructure</code> that represent
/// s <code>OptionalLeafletMapConfigs</code> <p>Description: Set additional parameters to customize
///  map’s behavior and functionality.</p>
/// </summary>
// Name: OptionalLeafletMapConfigs
public partial struct ST_597877eac22877030461f6d98995be4aStructure : ITypedRecord<ST_597877eac22877030461f6d98995be4aStructure> {
internal static readonly GlobalObjectKey IdAutoZoomOnShapes = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*Q5sPOW540EKSF8Msx1zFug");
internal static readonly GlobalObjectKey IdOffset = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*9UVTMHFkN0O4gIIXn4+RgQ");
internal static readonly GlobalObjectKey IdRespectUserZoom = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*58naHD_9QE+VaGpPuHjPbg");
internal static readonly GlobalObjectKey IdZoom = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*pPyyDZJaekikCayANazGEw");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("AutoZoomOnShapes")]
public bool ssAutoZoomOnShapes;

[System.Xml.Serialization.XmlElement("Offset")]
public ST_be62cc31fbe4705834275960beeb55e2Structure ssOffset;

[System.Xml.Serialization.XmlElement("RespectUserZoom")]
public bool ssRespectUserZoom;

[System.Xml.Serialization.XmlElement("Zoom")]
public int ssZoom;


public BitArray OptimizedAttributes;

public ST_597877eac22877030461f6d98995be4aStructure() {
OptimizedAttributes = null;
ssAutoZoomOnShapes = false;
ssOffset = new ST_be62cc31fbe4705834275960beeb55e2Structure();
ssRespectUserZoom = false;
ssZoom = (ENZoomEntity.GetRecordByKey(ObjectKey.Parse("WLo5+5B9A0iAL7Ee_Ty8xQ"))).ssId;
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
    ssOffset.OptimizedAttributes = value[0];
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
ssAutoZoomOnShapes = r.ReadBoolean(index++, "OptionalLeafletMapConfigs.AutoZoomOnShapes", false);
ssRespectUserZoom = r.ReadBoolean(index++, "OptionalLeafletMapConfigs.RespectUserZoom", false);
ssZoom = r.ReadEntityReference(index++, "OptionalLeafletMapConfigs.Zoom", 0);
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
public void ReadIM(ST_597877eac22877030461f6d98995be4aStructure r) {
this = r;
}


public static bool operator == (ST_597877eac22877030461f6d98995be4aStructure a, ST_597877eac22877030461f6d98995be4aStructure b) {
if (a.ssAutoZoomOnShapes != b.ssAutoZoomOnShapes) return false;
if (a.ssOffset != b.ssOffset) return false;
if (a.ssRespectUserZoom != b.ssRespectUserZoom) return false;
if (a.ssZoom != b.ssZoom) return false;
return true;
}

public static bool operator != (ST_597877eac22877030461f6d98995be4aStructure a, ST_597877eac22877030461f6d98995be4aStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_597877eac22877030461f6d98995be4aStructure)) return false;
return (this == (ST_597877eac22877030461f6d98995be4aStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssAutoZoomOnShapes.GetHashCode()
 ^ ssOffset.GetHashCode()
 ^ ssRespectUserZoom.GetHashCode()
 ^ ssZoom.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssOffset.RecursiveReset();
}

public void InternalRecursiveSave() {
ssOffset.InternalRecursiveSave();
}


public ST_597877eac22877030461f6d98995be4aStructure Duplicate() {
ST_597877eac22877030461f6d98995be4aStructure t;
t.ssAutoZoomOnShapes = this.ssAutoZoomOnShapes;
t.ssOffset = (ST_be62cc31fbe4705834275960beeb55e2Structure)this.ssOffset.Duplicate();
t.ssRespectUserZoom = this.ssRespectUserZoom;
t.ssZoom = this.ssZoom;
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
if (head == "autozoomonshapes") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AutoZoomOnShapes")) variable.Value = ssAutoZoomOnShapes; else variable.Optimized = true;
} else if (head == "offset") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Offset")) variable.Value = ssOffset; else variable.Optimized = true;
variable.SetFieldName("offset");
} else if (head == "respectuserzoom") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RespectUserZoom")) variable.Value = ssRespectUserZoom; else variable.Optimized = true;
} else if (head == "zoom") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Zoom")) variable.Value = ssZoom; else variable.Optimized = true;
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
if (key == IdAutoZoomOnShapes) {
return ssAutoZoomOnShapes;
}
if (key == IdOffset) {
return ssOffset;
}
if (key == IdRespectUserZoom) {
return ssRespectUserZoom;
}
if (key == IdZoom) {
return ssZoom;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdAutoZoomOnShapes.Key.AsGuid) {
return ssAutoZoomOnShapes;
}
if (attributeKey == IdOffset.Key.AsGuid) {
return ssOffset;
}
if (attributeKey == IdRespectUserZoom.Key.AsGuid) {
return ssRespectUserZoom;
}
if (attributeKey == IdZoom.Key.AsGuid) {
return ssZoom;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssAutoZoomOnShapes = (bool) other.AttributeGet(IdAutoZoomOnShapes);
ssOffset.FillFromOther((IRecord) other.AttributeGet(IdOffset));
ssRespectUserZoom = (bool) other.AttributeGet(IdRespectUserZoom);
ssZoom = (int) other.AttributeGet(IdZoom);
}
} // ST_597877eac22877030461f6d98995be4aStructure
/// <summary>
/// RecordList type <code>OptionalLeafletMapConfigsList</code> that represents a record list of
///  <code>OptionalLeafletMapConfigs</code>
/// </summary>
public partial class RL_3edf9b671d971f98015ab6b1b5f47187 : GenericRecordList<ST_597877eac22877030461f6d98995be4aStructure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_597877eac22877030461f6d98995be4aStructure GetElementDefaultValue() {
return new ST_597877eac22877030461f6d98995be4aStructure();
}

public T[] ToArray<T>(Func<ST_597877eac22877030461f6d98995be4aStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_3edf9b671d971f98015ab6b1b5f47187 recordList, Func<ST_597877eac22877030461f6d98995be4aStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_3edf9b671d971f98015ab6b1b5f47187(ST_597877eac22877030461f6d98995be4aStructure[] array) {
  RL_3edf9b671d971f98015ab6b1b5f47187 result = new RL_3edf9b671d971f98015ab6b1b5f47187();
result.InnerFromArray(array);
    return result;
}

public static RL_3edf9b671d971f98015ab6b1b5f47187 ToList<T>(T[] array, Func <T, ST_597877eac22877030461f6d98995be4aStructure> converter) {
  RL_3edf9b671d971f98015ab6b1b5f47187 result = new RL_3edf9b671d971f98015ab6b1b5f47187();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_3edf9b671d971f98015ab6b1b5f47187 FromRestList<T>(RestList<T> restList, Func <T, ST_597877eac22877030461f6d98995be4aStructure> converter) {
  RL_3edf9b671d971f98015ab6b1b5f47187 result = new RL_3edf9b671d971f98015ab6b1b5f47187();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_3edf9b671d971f98015ab6b1b5f47187() : base() {
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
protected override OSList<ST_597877eac22877030461f6d98995be4aStructure> NewList() {
return new RL_3edf9b671d971f98015ab6b1b5f47187();
}


} // RL_3edf9b671d971f98015ab6b1b5f47187
}

