namespace ssOutSystemsUI {
/// <summary>
/// [Structure] TimePicker_InternalConfig (753khxpcok2rLf1iGx3S0A)
///  <code>ST_613242ff7dd22d356200cb1f89298a39Structure</code> that represent
/// s <code>TimePicker_InternalConfig</code> <p>Description: Group of internal configurations for the
///  TimePicker block. </p>
/// </summary>
// Name: TimePicker_InternalConfig
public partial struct ST_613242ff7dd22d356200cb1f89298a39Structure : ITypedRecord<ST_613242ff7dd22d356200cb1f89298a39Structure> {
internal static readonly GlobalObjectKey IdUniqueId = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*sNNtSPoTJk+2y9qw0sgbPA");
internal static readonly GlobalObjectKey IdTimeFormat = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*dfyO_6YChk6p96nt9ZEy4w");
internal static readonly GlobalObjectKey IdIs24Hours = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*h_BCSF_GJkyEUVSHpu8amg");
internal static readonly GlobalObjectKey IdInitialTime = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*dH2H+HU3v0iv43uWAWIWWg");
internal static readonly GlobalObjectKey IdMinTime = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*VtLudHhonk6EE0Tw8i5+hA");
internal static readonly GlobalObjectKey IdMaxTime = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*axvEd+F0L0G9P_AAmShQFA");
internal static readonly GlobalObjectKey IdExtendedClass = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*62e7VZqEdU2wBxrJTSafTw");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("UniqueId")]
public string ssUniqueId;

[System.Xml.Serialization.XmlElement("TimeFormat")]
public string ssTimeFormat;

[System.Xml.Serialization.XmlElement("Is24Hours")]
public bool ssIs24Hours;

[System.Xml.Serialization.XmlElement("InitialTime")]
public DateTime ssInitialTime;

[System.Xml.Serialization.XmlElement("MinTime")]
public DateTime ssMinTime;

[System.Xml.Serialization.XmlElement("MaxTime")]
public DateTime ssMaxTime;

[System.Xml.Serialization.XmlElement("ExtendedClass")]
public string ssExtendedClass;


public BitArray OptimizedAttributes;

public ST_613242ff7dd22d356200cb1f89298a39Structure() {
OptimizedAttributes = null;
ssUniqueId = "";
ssTimeFormat = "";
ssIs24Hours = true;
ssInitialTime = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
ssMinTime = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
ssMaxTime = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
ssExtendedClass = "";
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
ssUniqueId = r.ReadText(index++, "TimePicker_InternalConfig.UniqueId", "");
ssTimeFormat = r.ReadText(index++, "TimePicker_InternalConfig.TimeFormat", "");
ssIs24Hours = r.ReadBoolean(index++, "TimePicker_InternalConfig.Is24Hours", false);
ssInitialTime = r.ReadTime(index++, "TimePicker_InternalConfig.InitialTime", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssMinTime = r.ReadTime(index++, "TimePicker_InternalConfig.MinTime", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssMaxTime = r.ReadTime(index++, "TimePicker_InternalConfig.MaxTime", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssExtendedClass = r.ReadText(index++, "TimePicker_InternalConfig.ExtendedClass", "");
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
public void ReadIM(ST_613242ff7dd22d356200cb1f89298a39Structure r) {
this = r;
}


public static bool operator == (ST_613242ff7dd22d356200cb1f89298a39Structure a, ST_613242ff7dd22d356200cb1f89298a39Structure b) {
if (a.ssUniqueId != b.ssUniqueId) return false;
if (a.ssTimeFormat != b.ssTimeFormat) return false;
if (a.ssIs24Hours != b.ssIs24Hours) return false;
if (a.ssInitialTime != b.ssInitialTime) return false;
if (a.ssMinTime != b.ssMinTime) return false;
if (a.ssMaxTime != b.ssMaxTime) return false;
if (a.ssExtendedClass != b.ssExtendedClass) return false;
return true;
}

public static bool operator != (ST_613242ff7dd22d356200cb1f89298a39Structure a, ST_613242ff7dd22d356200cb1f89298a39Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_613242ff7dd22d356200cb1f89298a39Structure)) return false;
return (this == (ST_613242ff7dd22d356200cb1f89298a39Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssUniqueId.GetHashCode()
 ^ ssTimeFormat.GetHashCode()
 ^ ssIs24Hours.GetHashCode()
 ^ ssInitialTime.GetHashCode()
 ^ ssMinTime.GetHashCode()
 ^ ssMaxTime.GetHashCode()
 ^ ssExtendedClass.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_613242ff7dd22d356200cb1f89298a39Structure Duplicate() {
ST_613242ff7dd22d356200cb1f89298a39Structure t;
t.ssUniqueId = this.ssUniqueId;
t.ssTimeFormat = this.ssTimeFormat;
t.ssIs24Hours = this.ssIs24Hours;
t.ssInitialTime = this.ssInitialTime;
t.ssMinTime = this.ssMinTime;
t.ssMaxTime = this.ssMaxTime;
t.ssExtendedClass = this.ssExtendedClass;
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
if (head == "uniqueid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UniqueId")) variable.Value = ssUniqueId; else variable.Optimized = true;
} else if (head == "timeformat") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TimeFormat")) variable.Value = ssTimeFormat; else variable.Optimized = true;
} else if (head == "is24hours") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Is24Hours")) variable.Value = ssIs24Hours; else variable.Optimized = true;
} else if (head == "initialtime") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InitialTime")) variable.Value = ssInitialTime; else variable.Optimized = true;
} else if (head == "mintime") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MinTime")) variable.Value = ssMinTime; else variable.Optimized = true;
} else if (head == "maxtime") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MaxTime")) variable.Value = ssMaxTime; else variable.Optimized = true;
} else if (head == "extendedclass") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ExtendedClass")) variable.Value = ssExtendedClass; else variable.Optimized = true;
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
if (key == IdUniqueId) {
return ssUniqueId;
}
if (key == IdTimeFormat) {
return ssTimeFormat;
}
if (key == IdIs24Hours) {
return ssIs24Hours;
}
if (key == IdInitialTime) {
return ssInitialTime;
}
if (key == IdMinTime) {
return ssMinTime;
}
if (key == IdMaxTime) {
return ssMaxTime;
}
if (key == IdExtendedClass) {
return ssExtendedClass;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUniqueId.Key.AsGuid) {
return ssUniqueId;
}
if (attributeKey == IdTimeFormat.Key.AsGuid) {
return ssTimeFormat;
}
if (attributeKey == IdIs24Hours.Key.AsGuid) {
return ssIs24Hours;
}
if (attributeKey == IdInitialTime.Key.AsGuid) {
return ssInitialTime;
}
if (attributeKey == IdMinTime.Key.AsGuid) {
return ssMinTime;
}
if (attributeKey == IdMaxTime.Key.AsGuid) {
return ssMaxTime;
}
if (attributeKey == IdExtendedClass.Key.AsGuid) {
return ssExtendedClass;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssUniqueId = (string) other.AttributeGet(IdUniqueId);
ssTimeFormat = (string) other.AttributeGet(IdTimeFormat);
ssIs24Hours = (bool) other.AttributeGet(IdIs24Hours);
ssInitialTime = (DateTime) other.AttributeGet(IdInitialTime);
ssMinTime = (DateTime) other.AttributeGet(IdMinTime);
ssMaxTime = (DateTime) other.AttributeGet(IdMaxTime);
ssExtendedClass = (string) other.AttributeGet(IdExtendedClass);
}
} // ST_613242ff7dd22d356200cb1f89298a39Structure
/// <summary>
/// RecordList type <code>TimePicker_InternalConfigList</code> that represents a record list of
///  <code>TimePicker_InternalConfig</code>
/// </summary>
public partial class RL_c99beeed1b27505b6fc6f74a47981ee8 : GenericRecordList<ST_613242ff7dd22d356200cb1f89298a39Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_613242ff7dd22d356200cb1f89298a39Structure GetElementDefaultValue() {
return new ST_613242ff7dd22d356200cb1f89298a39Structure();
}

public T[] ToArray<T>(Func<ST_613242ff7dd22d356200cb1f89298a39Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_c99beeed1b27505b6fc6f74a47981ee8 recordList, Func<ST_613242ff7dd22d356200cb1f89298a39Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_c99beeed1b27505b6fc6f74a47981ee8(ST_613242ff7dd22d356200cb1f89298a39Structure[] array) {
  RL_c99beeed1b27505b6fc6f74a47981ee8 result = new RL_c99beeed1b27505b6fc6f74a47981ee8();
result.InnerFromArray(array);
    return result;
}

public static RL_c99beeed1b27505b6fc6f74a47981ee8 ToList<T>(T[] array, Func <T, ST_613242ff7dd22d356200cb1f89298a39Structure> converter) {
  RL_c99beeed1b27505b6fc6f74a47981ee8 result = new RL_c99beeed1b27505b6fc6f74a47981ee8();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_c99beeed1b27505b6fc6f74a47981ee8 FromRestList<T>(RestList<T> restList, Func <T, ST_613242ff7dd22d356200cb1f89298a39Structure> converter) {
  RL_c99beeed1b27505b6fc6f74a47981ee8 result = new RL_c99beeed1b27505b6fc6f74a47981ee8();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_c99beeed1b27505b6fc6f74a47981ee8() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_613242ff7dd22d356200cb1f89298a39Structure> NewList() {
return new RL_c99beeed1b27505b6fc6f74a47981ee8();
}


} // RL_c99beeed1b27505b6fc6f74a47981ee8
}

