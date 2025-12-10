namespace ssOutSystemsUI {
/// <summary>
/// [Structure] SectionIndex_InternalConfig (_PlNAfTrIUm8GuGCu04Zzw)
///  <code>ST_3b9304e9875ccc71ec31b003d76d44c7Structure</code> that represent
/// s <code>SectionIndex_InternalConfig</code> <p>Description: Group of internal configurations for the
///  SectionIndex block. </p>
/// </summary>
// Name: SectionIndex_InternalConfig
public partial struct ST_3b9304e9875ccc71ec31b003d76d44c7Structure : ITypedRecord<ST_3b9304e9875ccc71ec31b003d76d44c7Structure> {
internal static readonly GlobalObjectKey IdUniqueId = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*SEVX8_lvP0y8invv6Au0Vg");
internal static readonly GlobalObjectKey IdSmoothScrolling = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*OHIfY2pJ60aZaUtFIxcj8w");
internal static readonly GlobalObjectKey IdIsFixed = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*287_2QNcm02f5q9raa2TcA");
internal static readonly GlobalObjectKey IdExtendedClass = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*nFjTtMUwRkqxAVmIS0tEgQ");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("UniqueId")]
public string ssUniqueId;

[System.Xml.Serialization.XmlElement("SmoothScrolling")]
public bool ssSmoothScrolling;

[System.Xml.Serialization.XmlElement("IsFixed")]
public bool ssIsFixed;

[System.Xml.Serialization.XmlElement("ExtendedClass")]
public string ssExtendedClass;


public BitArray OptimizedAttributes;

public ST_3b9304e9875ccc71ec31b003d76d44c7Structure() {
OptimizedAttributes = null;
ssUniqueId = "";
ssSmoothScrolling = false;
ssIsFixed = false;
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
ssUniqueId = r.ReadText(index++, "SectionIndex_InternalConfig.UniqueId", "");
ssSmoothScrolling = r.ReadBoolean(index++, "SectionIndex_InternalConfig.SmoothScrolling", false);
ssIsFixed = r.ReadBoolean(index++, "SectionIndex_InternalConfig.IsFixed", false);
ssExtendedClass = r.ReadText(index++, "SectionIndex_InternalConfig.ExtendedClass", "");
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
public void ReadIM(ST_3b9304e9875ccc71ec31b003d76d44c7Structure r) {
this = r;
}


public static bool operator == (ST_3b9304e9875ccc71ec31b003d76d44c7Structure a, ST_3b9304e9875ccc71ec31b003d76d44c7Structure b) {
if (a.ssUniqueId != b.ssUniqueId) return false;
if (a.ssSmoothScrolling != b.ssSmoothScrolling) return false;
if (a.ssIsFixed != b.ssIsFixed) return false;
if (a.ssExtendedClass != b.ssExtendedClass) return false;
return true;
}

public static bool operator != (ST_3b9304e9875ccc71ec31b003d76d44c7Structure a, ST_3b9304e9875ccc71ec31b003d76d44c7Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_3b9304e9875ccc71ec31b003d76d44c7Structure)) return false;
return (this == (ST_3b9304e9875ccc71ec31b003d76d44c7Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssUniqueId.GetHashCode()
 ^ ssSmoothScrolling.GetHashCode()
 ^ ssIsFixed.GetHashCode()
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


public ST_3b9304e9875ccc71ec31b003d76d44c7Structure Duplicate() {
ST_3b9304e9875ccc71ec31b003d76d44c7Structure t;
t.ssUniqueId = this.ssUniqueId;
t.ssSmoothScrolling = this.ssSmoothScrolling;
t.ssIsFixed = this.ssIsFixed;
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
} else if (head == "smoothscrolling") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SmoothScrolling")) variable.Value = ssSmoothScrolling; else variable.Optimized = true;
} else if (head == "isfixed") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsFixed")) variable.Value = ssIsFixed; else variable.Optimized = true;
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
if (key == IdSmoothScrolling) {
return ssSmoothScrolling;
}
if (key == IdIsFixed) {
return ssIsFixed;
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
if (attributeKey == IdSmoothScrolling.Key.AsGuid) {
return ssSmoothScrolling;
}
if (attributeKey == IdIsFixed.Key.AsGuid) {
return ssIsFixed;
}
if (attributeKey == IdExtendedClass.Key.AsGuid) {
return ssExtendedClass;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssUniqueId = (string) other.AttributeGet(IdUniqueId);
ssSmoothScrolling = (bool) other.AttributeGet(IdSmoothScrolling);
ssIsFixed = (bool) other.AttributeGet(IdIsFixed);
ssExtendedClass = (string) other.AttributeGet(IdExtendedClass);
}
} // ST_3b9304e9875ccc71ec31b003d76d44c7Structure
/// <summary>
/// RecordList type <code>SectionIndex_InternalConfigList</code> that represents a record list of
///  <code>SectionIndex_InternalConfig</code>
/// </summary>
public partial class RL_6e83700adc6fcd665137daf94937dfd4 : GenericRecordList<ST_3b9304e9875ccc71ec31b003d76d44c7Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_3b9304e9875ccc71ec31b003d76d44c7Structure GetElementDefaultValue() {
return new ST_3b9304e9875ccc71ec31b003d76d44c7Structure();
}

public T[] ToArray<T>(Func<ST_3b9304e9875ccc71ec31b003d76d44c7Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_6e83700adc6fcd665137daf94937dfd4 recordList, Func<ST_3b9304e9875ccc71ec31b003d76d44c7Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_6e83700adc6fcd665137daf94937dfd4(ST_3b9304e9875ccc71ec31b003d76d44c7Structure[] array) {
  RL_6e83700adc6fcd665137daf94937dfd4 result = new RL_6e83700adc6fcd665137daf94937dfd4();
result.InnerFromArray(array);
    return result;
}

public static RL_6e83700adc6fcd665137daf94937dfd4 ToList<T>(T[] array, Func <T, ST_3b9304e9875ccc71ec31b003d76d44c7Structure> converter) {
  RL_6e83700adc6fcd665137daf94937dfd4 result = new RL_6e83700adc6fcd665137daf94937dfd4();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_6e83700adc6fcd665137daf94937dfd4 FromRestList<T>(RestList<T> restList, Func <T, ST_3b9304e9875ccc71ec31b003d76d44c7Structure> converter) {
  RL_6e83700adc6fcd665137daf94937dfd4 result = new RL_6e83700adc6fcd665137daf94937dfd4();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_6e83700adc6fcd665137daf94937dfd4() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_3b9304e9875ccc71ec31b003d76d44c7Structure> NewList() {
return new RL_6e83700adc6fcd665137daf94937dfd4();
}


} // RL_6e83700adc6fcd665137daf94937dfd4
}

