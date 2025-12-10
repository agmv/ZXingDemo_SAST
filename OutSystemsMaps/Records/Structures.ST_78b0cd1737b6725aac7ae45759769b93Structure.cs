namespace ssOutSystemsMaps {
/// <summary>
/// [Structure] DirectionOptions (nykU7Hcq5E60d+s_IMcFGQ)
///  <code>ST_78b0cd1737b6725aac7ae45759769b93Structure</code> that represent
/// s <code>DirectionOptions</code> <p>Description: Structure to handle direction options.</p>
/// </summary>
// Name: DirectionOptions
public partial struct ST_78b0cd1737b6725aac7ae45759769b93Structure : ITypedRecord<ST_78b0cd1737b6725aac7ae45759769b93Structure> {
internal static readonly GlobalObjectKey IdOrigin = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*1gM9cH3H_EKo3mSQYu62uA");
internal static readonly GlobalObjectKey IdDestination = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*7Kfx6UXH7k+m83WrhtJSdw");
internal static readonly GlobalObjectKey IdTravelMode = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*TFUTsT8NT0ibiYpsRrXVxQ");
internal static readonly GlobalObjectKey IdWaypoints = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*J2o1HcRmHEqua4M43LJecw");
internal static readonly GlobalObjectKey IdOptimizeWaypoints = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*+j_KcJ83O0WnK0Us0RXKLw");
internal static readonly GlobalObjectKey IdExclude = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*LMu2jab7D0KtK8yERvv_nQ");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Origin")]
public string ssOrigin;

[System.Xml.Serialization.XmlElement("Destination")]
public string ssDestination;

[System.Xml.Serialization.XmlElement("TravelMode")]
public string ssTravelMode;

[System.Xml.Serialization.XmlElement("Waypoints")]
public BasicTypeList<string> ssWaypoints;

[System.Xml.Serialization.XmlElement("OptimizeWaypoints")]
public bool ssOptimizeWaypoints;

[System.Xml.Serialization.XmlElement("Exclude")]
public ST_78fd8c130caeaf241d821392d1010014Structure ssExclude;


public BitArray OptimizedAttributes;

public ST_78b0cd1737b6725aac7ae45759769b93Structure() {
OptimizedAttributes = null;
ssOrigin = "";
ssDestination = "";
ssTravelMode = "";
ssWaypoints = new BasicTypeList<string>();
ssOptimizeWaypoints = false;
ssExclude = new ST_78fd8c130caeaf241d821392d1010014Structure();
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
    ssExclude.OptimizedAttributes = value[0];
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
ssOrigin = r.ReadText(index++, "DirectionOptions.Origin", "");
ssDestination = r.ReadText(index++, "DirectionOptions.Destination", "");
ssTravelMode = r.ReadEntityReferenceText(index++, "DirectionOptions.TravelMode", "");
ssOptimizeWaypoints = r.ReadBoolean(index++, "DirectionOptions.OptimizeWaypoints", false);
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
public void ReadIM(ST_78b0cd1737b6725aac7ae45759769b93Structure r) {
this = r;
}


public static bool operator == (ST_78b0cd1737b6725aac7ae45759769b93Structure a, ST_78b0cd1737b6725aac7ae45759769b93Structure b) {
if (a.ssOrigin != b.ssOrigin) return false;
if (a.ssDestination != b.ssDestination) return false;
if (a.ssTravelMode != b.ssTravelMode) return false;
if (a.ssWaypoints != b.ssWaypoints) return false;
if (a.ssOptimizeWaypoints != b.ssOptimizeWaypoints) return false;
if (a.ssExclude != b.ssExclude) return false;
return true;
}

public static bool operator != (ST_78b0cd1737b6725aac7ae45759769b93Structure a, ST_78b0cd1737b6725aac7ae45759769b93Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_78b0cd1737b6725aac7ae45759769b93Structure)) return false;
return (this == (ST_78b0cd1737b6725aac7ae45759769b93Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssOrigin.GetHashCode()
 ^ ssDestination.GetHashCode()
 ^ ssTravelMode.GetHashCode()
 ^ ssWaypoints.GetHashCode()
 ^ ssOptimizeWaypoints.GetHashCode()
 ^ ssExclude.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssWaypoints.RecursiveReset();
ssExclude.RecursiveReset();
}

public void InternalRecursiveSave() {
ssWaypoints.InternalRecursiveSave();
ssExclude.InternalRecursiveSave();
}


public ST_78b0cd1737b6725aac7ae45759769b93Structure Duplicate() {
ST_78b0cd1737b6725aac7ae45759769b93Structure t;
t.ssOrigin = this.ssOrigin;
t.ssDestination = this.ssDestination;
t.ssTravelMode = this.ssTravelMode;
t.ssWaypoints = (BasicTypeList<string>)this.ssWaypoints.Duplicate();
t.ssOptimizeWaypoints = this.ssOptimizeWaypoints;
t.ssExclude = (ST_78fd8c130caeaf241d821392d1010014Structure)this.ssExclude.Duplicate();
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
if (head == "origin") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Origin")) variable.Value = ssOrigin; else variable.Optimized = true;
} else if (head == "destination") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Destination")) variable.Value = ssDestination; else variable.Optimized = true;
} else if (head == "travelmode") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TravelMode")) variable.Value = ssTravelMode; else variable.Optimized = true;
} else if (head == "waypoints") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Waypoints")) variable.Value = ssWaypoints; else variable.Optimized = true;
variable.SetFieldName("waypoints");
} else if (head == "optimizewaypoints") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OptimizeWaypoints")) variable.Value = ssOptimizeWaypoints; else variable.Optimized = true;
} else if (head == "exclude") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Exclude")) variable.Value = ssExclude; else variable.Optimized = true;
variable.SetFieldName("exclude");
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
if (key == IdOrigin) {
return ssOrigin;
}
if (key == IdDestination) {
return ssDestination;
}
if (key == IdTravelMode) {
return ssTravelMode;
}
if (key == IdWaypoints) {
return ssWaypoints;
}
if (key == IdOptimizeWaypoints) {
return ssOptimizeWaypoints;
}
if (key == IdExclude) {
return ssExclude;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrigin.Key.AsGuid) {
return ssOrigin;
}
if (attributeKey == IdDestination.Key.AsGuid) {
return ssDestination;
}
if (attributeKey == IdTravelMode.Key.AsGuid) {
return ssTravelMode;
}
if (attributeKey == IdWaypoints.Key.AsGuid) {
return ssWaypoints;
}
if (attributeKey == IdOptimizeWaypoints.Key.AsGuid) {
return ssOptimizeWaypoints;
}
if (attributeKey == IdExclude.Key.AsGuid) {
return ssExclude;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssOrigin = (string) other.AttributeGet(IdOrigin);
ssDestination = (string) other.AttributeGet(IdDestination);
ssTravelMode = (string) other.AttributeGet(IdTravelMode);
ssWaypoints = new BasicTypeList<string>();
ssWaypoints.FillFromOther((IOSList) other.AttributeGet(IdWaypoints));
ssOptimizeWaypoints = (bool) other.AttributeGet(IdOptimizeWaypoints);
ssExclude.FillFromOther((IRecord) other.AttributeGet(IdExclude));
}
} // ST_78b0cd1737b6725aac7ae45759769b93Structure
/// <summary>
/// RecordList type <code>DirectionOptionsList</code> that represents a record list of
///  <code>DirectionOptions</code>
/// </summary>
public partial class RL_c3bfb55b3eb1f9d65964545596508105 : GenericRecordList<ST_78b0cd1737b6725aac7ae45759769b93Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_78b0cd1737b6725aac7ae45759769b93Structure GetElementDefaultValue() {
return new ST_78b0cd1737b6725aac7ae45759769b93Structure();
}

public T[] ToArray<T>(Func<ST_78b0cd1737b6725aac7ae45759769b93Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_c3bfb55b3eb1f9d65964545596508105 recordList, Func<ST_78b0cd1737b6725aac7ae45759769b93Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_c3bfb55b3eb1f9d65964545596508105(ST_78b0cd1737b6725aac7ae45759769b93Structure[] array) {
  RL_c3bfb55b3eb1f9d65964545596508105 result = new RL_c3bfb55b3eb1f9d65964545596508105();
result.InnerFromArray(array);
    return result;
}

public static RL_c3bfb55b3eb1f9d65964545596508105 ToList<T>(T[] array, Func <T, ST_78b0cd1737b6725aac7ae45759769b93Structure> converter) {
  RL_c3bfb55b3eb1f9d65964545596508105 result = new RL_c3bfb55b3eb1f9d65964545596508105();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_c3bfb55b3eb1f9d65964545596508105 FromRestList<T>(RestList<T> restList, Func <T, ST_78b0cd1737b6725aac7ae45759769b93Structure> converter) {
  RL_c3bfb55b3eb1f9d65964545596508105 result = new RL_c3bfb55b3eb1f9d65964545596508105();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_c3bfb55b3eb1f9d65964545596508105() : base() {
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
protected override OSList<ST_78b0cd1737b6725aac7ae45759769b93Structure> NewList() {
return new RL_c3bfb55b3eb1f9d65964545596508105();
}


} // RL_c3bfb55b3eb1f9d65964545596508105
}

