namespace ssOutSystemsMaps {
/// <summary>
/// [Structure] Internal_DrawPolyline_Configs (IQMtCaojPEqdbCY2b461HA)
///  <code>ST_5223ca706bfb3de574fb0b39ebba3fb6Structure</code> that represent
/// s <code>Internal_DrawPolyline_Configs</code> <p>Description: Structure to handle internal
///  configurations associated with the Drawing Tools.</p>
/// </summary>
// Name: Internal_DrawPolyline_Configs
public partial struct ST_5223ca706bfb3de574fb0b39ebba3fb6Structure : ITypedRecord<ST_5223ca706bfb3de574fb0b39ebba3fb6Structure> {
internal static readonly GlobalObjectKey IdInternal_to_provider_tools_configs = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*2Bsp+7DyHkGFaRm0P9bJig");
internal static readonly GlobalObjectKey IdUniqueId = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*h+FDbQsAEU6C+Y54Exh0kA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Internal_to_provider_tools_configs")]
public ST_86d2610e9625abf0ecb7241e6d8099fbStructure ssInternal_to_provider_tools_configs;

[System.Xml.Serialization.XmlElement("UniqueId")]
public string ssUniqueId;


public BitArray OptimizedAttributes;

public ST_5223ca706bfb3de574fb0b39ebba3fb6Structure() {
OptimizedAttributes = null;
ssInternal_to_provider_tools_configs = new ST_86d2610e9625abf0ecb7241e6d8099fbStructure();
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
ssUniqueId = r.ReadText(index++, "Internal_DrawPolyline_Configs.UniqueId", "");
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
public void ReadIM(ST_5223ca706bfb3de574fb0b39ebba3fb6Structure r) {
this = r;
}


public static bool operator == (ST_5223ca706bfb3de574fb0b39ebba3fb6Structure a, ST_5223ca706bfb3de574fb0b39ebba3fb6Structure b) {
if (a.ssInternal_to_provider_tools_configs != b.ssInternal_to_provider_tools_configs) return false;
if (a.ssUniqueId != b.ssUniqueId) return false;
return true;
}

public static bool operator != (ST_5223ca706bfb3de574fb0b39ebba3fb6Structure a, ST_5223ca706bfb3de574fb0b39ebba3fb6Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_5223ca706bfb3de574fb0b39ebba3fb6Structure)) return false;
return (this == (ST_5223ca706bfb3de574fb0b39ebba3fb6Structure)o);
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


public ST_5223ca706bfb3de574fb0b39ebba3fb6Structure Duplicate() {
ST_5223ca706bfb3de574fb0b39ebba3fb6Structure t;
t.ssInternal_to_provider_tools_configs = (ST_86d2610e9625abf0ecb7241e6d8099fbStructure)this.ssInternal_to_provider_tools_configs.Duplicate();
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
} // ST_5223ca706bfb3de574fb0b39ebba3fb6Structure
/// <summary>
/// RecordList type <code>Internal_DrawPolyline_ConfigsList</code> that represents a record list of
///  <code>Internal_DrawPolyline_Configs</code>
/// </summary>
public partial class RL_389f2c39da50ad36f3dbeadd4af0b4d3 : GenericRecordList<ST_5223ca706bfb3de574fb0b39ebba3fb6Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_5223ca706bfb3de574fb0b39ebba3fb6Structure GetElementDefaultValue() {
return new ST_5223ca706bfb3de574fb0b39ebba3fb6Structure();
}

public T[] ToArray<T>(Func<ST_5223ca706bfb3de574fb0b39ebba3fb6Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_389f2c39da50ad36f3dbeadd4af0b4d3 recordList, Func<ST_5223ca706bfb3de574fb0b39ebba3fb6Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_389f2c39da50ad36f3dbeadd4af0b4d3(ST_5223ca706bfb3de574fb0b39ebba3fb6Structure[] array) {
  RL_389f2c39da50ad36f3dbeadd4af0b4d3 result = new RL_389f2c39da50ad36f3dbeadd4af0b4d3();
result.InnerFromArray(array);
    return result;
}

public static RL_389f2c39da50ad36f3dbeadd4af0b4d3 ToList<T>(T[] array, Func <T, ST_5223ca706bfb3de574fb0b39ebba3fb6Structure> converter) {
  RL_389f2c39da50ad36f3dbeadd4af0b4d3 result = new RL_389f2c39da50ad36f3dbeadd4af0b4d3();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_389f2c39da50ad36f3dbeadd4af0b4d3 FromRestList<T>(RestList<T> restList, Func <T, ST_5223ca706bfb3de574fb0b39ebba3fb6Structure> converter) {
  RL_389f2c39da50ad36f3dbeadd4af0b4d3 result = new RL_389f2c39da50ad36f3dbeadd4af0b4d3();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_389f2c39da50ad36f3dbeadd4af0b4d3() : base() {
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
protected override OSList<ST_5223ca706bfb3de574fb0b39ebba3fb6Structure> NewList() {
return new RL_389f2c39da50ad36f3dbeadd4af0b4d3();
}


} // RL_389f2c39da50ad36f3dbeadd4af0b4d3
}

