namespace ssOutSystemsMaps {
/// <summary>
/// [Structure] Internal_DrawMarker_Configs (_T9cx_FZzUODJfVM89sbGg)
///  <code>ST_60018fad8b9768f5644ffadf96040a85Structure</code> that represent
/// s <code>Internal_DrawMarker_Configs</code> <p>Description: Structure to handle internal
///  configurations associated with the Drawing Tools.</p>
/// </summary>
// Name: Internal_DrawMarker_Configs
public partial struct ST_60018fad8b9768f5644ffadf96040a85Structure : ITypedRecord<ST_60018fad8b9768f5644ffadf96040a85Structure> {
internal static readonly GlobalObjectKey IdInternal_to_provider_tools_configs = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*co_oVCtsDES1H1HICv+hZA");
internal static readonly GlobalObjectKey IdUniqueId = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*_Syy8UX8JkyTOvC2slOwDw");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Internal_to_provider_tools_configs")]
public ST_f121435b3edb481ee03ab7ef58e5b805Structure ssInternal_to_provider_tools_configs;

[System.Xml.Serialization.XmlElement("UniqueId")]
public string ssUniqueId;


public BitArray OptimizedAttributes;

public ST_60018fad8b9768f5644ffadf96040a85Structure() {
OptimizedAttributes = null;
ssInternal_to_provider_tools_configs = new ST_f121435b3edb481ee03ab7ef58e5b805Structure();
ssUniqueId = "";
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
    ssInternal_to_provider_tools_configs.OptimizedAttributes = value[0];
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
ssUniqueId = r.ReadText(index++, "Internal_DrawMarker_Configs.UniqueId", "");
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
public void ReadIM(ST_60018fad8b9768f5644ffadf96040a85Structure r) {
this = r;
}


public static bool operator == (ST_60018fad8b9768f5644ffadf96040a85Structure a, ST_60018fad8b9768f5644ffadf96040a85Structure b) {
if (a.ssInternal_to_provider_tools_configs != b.ssInternal_to_provider_tools_configs) return false;
if (a.ssUniqueId != b.ssUniqueId) return false;
return true;
}

public static bool operator != (ST_60018fad8b9768f5644ffadf96040a85Structure a, ST_60018fad8b9768f5644ffadf96040a85Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_60018fad8b9768f5644ffadf96040a85Structure)) return false;
return (this == (ST_60018fad8b9768f5644ffadf96040a85Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssInternal_to_provider_tools_configs.GetHashCode()
 ^ ssUniqueId.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssInternal_to_provider_tools_configs.RecursiveReset();
}

public void InternalRecursiveSave() {
ssInternal_to_provider_tools_configs.InternalRecursiveSave();
}


public ST_60018fad8b9768f5644ffadf96040a85Structure Duplicate() {
ST_60018fad8b9768f5644ffadf96040a85Structure t;
t.ssInternal_to_provider_tools_configs = (ST_f121435b3edb481ee03ab7ef58e5b805Structure)this.ssInternal_to_provider_tools_configs.Duplicate();
t.ssUniqueId = this.ssUniqueId;
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
if (head == "internal_to_provider_tools_configs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Internal_to_provider_tools_configs")) variable.Value = ssInternal_to_provider_tools_configs; else variable.Optimized = true;
variable.SetFieldName("internal_to_provider_tools_configs");
} else if (head == "uniqueid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UniqueId")) variable.Value = ssUniqueId; else variable.Optimized = true;
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
if (key == IdInternal_to_provider_tools_configs) {
return ssInternal_to_provider_tools_configs;
}
if (key == IdUniqueId) {
return ssUniqueId;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInternal_to_provider_tools_configs.Key.AsGuid) {
return ssInternal_to_provider_tools_configs;
}
if (attributeKey == IdUniqueId.Key.AsGuid) {
return ssUniqueId;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssInternal_to_provider_tools_configs.FillFromOther((IRecord) other.AttributeGet(IdInternal_to_provider_tools_configs));
ssUniqueId = (string) other.AttributeGet(IdUniqueId);
}
} // ST_60018fad8b9768f5644ffadf96040a85Structure
/// <summary>
/// RecordList type <code>Internal_DrawMarker_ConfigsList</code> that represents a record list of
///  <code>Internal_DrawMarker_Configs</code>
/// </summary>
public partial class RL_252f0b4b2d4c4c22097e3688bd1ee0c6 : GenericRecordList<ST_60018fad8b9768f5644ffadf96040a85Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_60018fad8b9768f5644ffadf96040a85Structure GetElementDefaultValue() {
return new ST_60018fad8b9768f5644ffadf96040a85Structure();
}

public T[] ToArray<T>(Func<ST_60018fad8b9768f5644ffadf96040a85Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_252f0b4b2d4c4c22097e3688bd1ee0c6 recordList, Func<ST_60018fad8b9768f5644ffadf96040a85Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_252f0b4b2d4c4c22097e3688bd1ee0c6(ST_60018fad8b9768f5644ffadf96040a85Structure[] array) {
  RL_252f0b4b2d4c4c22097e3688bd1ee0c6 result = new RL_252f0b4b2d4c4c22097e3688bd1ee0c6();
result.InnerFromArray(array);
    return result;
}

public static RL_252f0b4b2d4c4c22097e3688bd1ee0c6 ToList<T>(T[] array, Func <T, ST_60018fad8b9768f5644ffadf96040a85Structure> converter) {
  RL_252f0b4b2d4c4c22097e3688bd1ee0c6 result = new RL_252f0b4b2d4c4c22097e3688bd1ee0c6();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_252f0b4b2d4c4c22097e3688bd1ee0c6 FromRestList<T>(RestList<T> restList, Func <T, ST_60018fad8b9768f5644ffadf96040a85Structure> converter) {
  RL_252f0b4b2d4c4c22097e3688bd1ee0c6 result = new RL_252f0b4b2d4c4c22097e3688bd1ee0c6();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_252f0b4b2d4c4c22097e3688bd1ee0c6() : base() {
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
protected override OSList<ST_60018fad8b9768f5644ffadf96040a85Structure> NewList() {
return new RL_252f0b4b2d4c4c22097e3688bd1ee0c6();
}


} // RL_252f0b4b2d4c4c22097e3688bd1ee0c6
}

