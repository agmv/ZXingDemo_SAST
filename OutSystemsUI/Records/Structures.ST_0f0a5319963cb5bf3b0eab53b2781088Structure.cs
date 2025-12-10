namespace ssOutSystemsUI {
/// <summary>
/// [Structure] Accordion_InternalConfigs (dF7yvGjCl02siMvhJqsuzg)
///  <code>ST_0f0a5319963cb5bf3b0eab53b2781088Structure</code> that represent
/// s <code>Accordion_InternalConfigs</code> <p>Description: Group of internal configurations for the
///  Accordion block. </p>
/// </summary>
// Name: Accordion_InternalConfigs
public partial struct ST_0f0a5319963cb5bf3b0eab53b2781088Structure : ITypedRecord<ST_0f0a5319963cb5bf3b0eab53b2781088Structure> {
internal static readonly GlobalObjectKey IdUniqueId = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*N3qKeiWMKU+rRAj9RzV1Mw");
internal static readonly GlobalObjectKey IdMultipleItems = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*jZobcoPj4EunVE_c+bkyoA");
internal static readonly GlobalObjectKey IdExtendedClass = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*TQT0hLD110WApANvZEykPg");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("UniqueId")]
public string ssUniqueId;

[System.Xml.Serialization.XmlElement("MultipleItems")]
public bool ssMultipleItems;

[System.Xml.Serialization.XmlElement("ExtendedClass")]
public string ssExtendedClass;


public BitArray OptimizedAttributes;

public ST_0f0a5319963cb5bf3b0eab53b2781088Structure() {
OptimizedAttributes = null;
ssUniqueId = "";
ssMultipleItems = false;
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
ssUniqueId = r.ReadText(index++, "Accordion_InternalConfigs.UniqueId", "");
ssMultipleItems = r.ReadBoolean(index++, "Accordion_InternalConfigs.MultipleItems", false);
ssExtendedClass = r.ReadText(index++, "Accordion_InternalConfigs.ExtendedClass", "");
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
public void ReadIM(ST_0f0a5319963cb5bf3b0eab53b2781088Structure r) {
this = r;
}


public static bool operator == (ST_0f0a5319963cb5bf3b0eab53b2781088Structure a, ST_0f0a5319963cb5bf3b0eab53b2781088Structure b) {
if (a.ssUniqueId != b.ssUniqueId) return false;
if (a.ssMultipleItems != b.ssMultipleItems) return false;
if (a.ssExtendedClass != b.ssExtendedClass) return false;
return true;
}

public static bool operator != (ST_0f0a5319963cb5bf3b0eab53b2781088Structure a, ST_0f0a5319963cb5bf3b0eab53b2781088Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_0f0a5319963cb5bf3b0eab53b2781088Structure)) return false;
return (this == (ST_0f0a5319963cb5bf3b0eab53b2781088Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssUniqueId.GetHashCode()
 ^ ssMultipleItems.GetHashCode()
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


public ST_0f0a5319963cb5bf3b0eab53b2781088Structure Duplicate() {
ST_0f0a5319963cb5bf3b0eab53b2781088Structure t;
t.ssUniqueId = this.ssUniqueId;
t.ssMultipleItems = this.ssMultipleItems;
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
} else if (head == "multipleitems") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MultipleItems")) variable.Value = ssMultipleItems; else variable.Optimized = true;
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
if (key == IdMultipleItems) {
return ssMultipleItems;
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
if (attributeKey == IdMultipleItems.Key.AsGuid) {
return ssMultipleItems;
}
if (attributeKey == IdExtendedClass.Key.AsGuid) {
return ssExtendedClass;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssUniqueId = (string) other.AttributeGet(IdUniqueId);
ssMultipleItems = (bool) other.AttributeGet(IdMultipleItems);
ssExtendedClass = (string) other.AttributeGet(IdExtendedClass);
}
} // ST_0f0a5319963cb5bf3b0eab53b2781088Structure
/// <summary>
/// RecordList type <code>Accordion_InternalConfigsList</code> that represents a record list of
///  <code>Accordion_InternalConfigs</code>
/// </summary>
public partial class RL_166d9c488ed75ab70d02b1e5d330558b : GenericRecordList<ST_0f0a5319963cb5bf3b0eab53b2781088Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_0f0a5319963cb5bf3b0eab53b2781088Structure GetElementDefaultValue() {
return new ST_0f0a5319963cb5bf3b0eab53b2781088Structure();
}

public T[] ToArray<T>(Func<ST_0f0a5319963cb5bf3b0eab53b2781088Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_166d9c488ed75ab70d02b1e5d330558b recordList, Func<ST_0f0a5319963cb5bf3b0eab53b2781088Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_166d9c488ed75ab70d02b1e5d330558b(ST_0f0a5319963cb5bf3b0eab53b2781088Structure[] array) {
  RL_166d9c488ed75ab70d02b1e5d330558b result = new RL_166d9c488ed75ab70d02b1e5d330558b();
result.InnerFromArray(array);
    return result;
}

public static RL_166d9c488ed75ab70d02b1e5d330558b ToList<T>(T[] array, Func <T, ST_0f0a5319963cb5bf3b0eab53b2781088Structure> converter) {
  RL_166d9c488ed75ab70d02b1e5d330558b result = new RL_166d9c488ed75ab70d02b1e5d330558b();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_166d9c488ed75ab70d02b1e5d330558b FromRestList<T>(RestList<T> restList, Func <T, ST_0f0a5319963cb5bf3b0eab53b2781088Structure> converter) {
  RL_166d9c488ed75ab70d02b1e5d330558b result = new RL_166d9c488ed75ab70d02b1e5d330558b();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_166d9c488ed75ab70d02b1e5d330558b() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_0f0a5319963cb5bf3b0eab53b2781088Structure> NewList() {
return new RL_166d9c488ed75ab70d02b1e5d330558b();
}


} // RL_166d9c488ed75ab70d02b1e5d330558b
}

