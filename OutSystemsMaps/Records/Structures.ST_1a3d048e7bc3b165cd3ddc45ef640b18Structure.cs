namespace ssOutSystemsMaps {
/// <summary>
/// [Structure] Internal_FileLayer_Configs (aQVrbvsCukGmEUBZhy+V1g)
///  <code>ST_1a3d048e7bc3b165cd3ddc45ef640b18Structure</code> that represent
/// s <code>Internal_FileLayer_Configs</code> <p>Description: Structure to handle internal
///  configurations associated with the File Layers.</p>
/// </summary>
// Name: Internal_FileLayer_Configs
public partial struct ST_1a3d048e7bc3b165cd3ddc45ef640b18Structure : ITypedRecord<ST_1a3d048e7bc3b165cd3ddc45ef640b18Structure> {
internal static readonly GlobalObjectKey IdInternal_to_provider_fileLayer_configs = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*qW2Q5elsCUGOg96+618rvw");
internal static readonly GlobalObjectKey IdUniqueId = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*9hXaFQev+0yTzdte40_5SQ");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Internal_to_provider_fileLayer_configs")]
public ST_793e574f3ddb64f39831eacf8a4462b0Structure ssInternal_to_provider_fileLayer_configs;

[System.Xml.Serialization.XmlElement("UniqueId")]
public string ssUniqueId;


public BitArray OptimizedAttributes;

public ST_1a3d048e7bc3b165cd3ddc45ef640b18Structure() {
OptimizedAttributes = null;
ssInternal_to_provider_fileLayer_configs = new ST_793e574f3ddb64f39831eacf8a4462b0Structure();
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
    ssInternal_to_provider_fileLayer_configs.OptimizedAttributes = value[0];
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
ssUniqueId = r.ReadText(index++, "Internal_FileLayer_Configs.UniqueId", "");
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
public void ReadIM(ST_1a3d048e7bc3b165cd3ddc45ef640b18Structure r) {
this = r;
}


public static bool operator == (ST_1a3d048e7bc3b165cd3ddc45ef640b18Structure a, ST_1a3d048e7bc3b165cd3ddc45ef640b18Structure b) {
if (a.ssInternal_to_provider_fileLayer_configs != b.ssInternal_to_provider_fileLayer_configs) return false;
if (a.ssUniqueId != b.ssUniqueId) return false;
return true;
}

public static bool operator != (ST_1a3d048e7bc3b165cd3ddc45ef640b18Structure a, ST_1a3d048e7bc3b165cd3ddc45ef640b18Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_1a3d048e7bc3b165cd3ddc45ef640b18Structure)) return false;
return (this == (ST_1a3d048e7bc3b165cd3ddc45ef640b18Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssInternal_to_provider_fileLayer_configs.GetHashCode()
 ^ ssUniqueId.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssInternal_to_provider_fileLayer_configs.RecursiveReset();
}

public void InternalRecursiveSave() {
ssInternal_to_provider_fileLayer_configs.InternalRecursiveSave();
}


public ST_1a3d048e7bc3b165cd3ddc45ef640b18Structure Duplicate() {
ST_1a3d048e7bc3b165cd3ddc45ef640b18Structure t;
t.ssInternal_to_provider_fileLayer_configs = (ST_793e574f3ddb64f39831eacf8a4462b0Structure)this.ssInternal_to_provider_fileLayer_configs.Duplicate();
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
if (head == "internal_to_provider_filelayer_configs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Internal_to_provider_fileLayer_configs")) variable.Value = ssInternal_to_provider_fileLayer_configs; else variable.Optimized = true;
variable.SetFieldName("internal_to_provider_filelayer_configs");
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
if (key == IdInternal_to_provider_fileLayer_configs) {
return ssInternal_to_provider_fileLayer_configs;
}
if (key == IdUniqueId) {
return ssUniqueId;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInternal_to_provider_fileLayer_configs.Key.AsGuid) {
return ssInternal_to_provider_fileLayer_configs;
}
if (attributeKey == IdUniqueId.Key.AsGuid) {
return ssUniqueId;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssInternal_to_provider_fileLayer_configs.FillFromOther((IRecord) other.AttributeGet(IdInternal_to_provider_fileLayer_configs));
ssUniqueId = (string) other.AttributeGet(IdUniqueId);
}
} // ST_1a3d048e7bc3b165cd3ddc45ef640b18Structure
/// <summary>
/// RecordList type <code>Internal_FileLayer_ConfigsList</code> that represents a record list of
///  <code>Internal_FileLayer_Configs</code>
/// </summary>
public partial class RL_fbc6d3557cbab24aad22edbe8e93b6f4 : GenericRecordList<ST_1a3d048e7bc3b165cd3ddc45ef640b18Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_1a3d048e7bc3b165cd3ddc45ef640b18Structure GetElementDefaultValue() {
return new ST_1a3d048e7bc3b165cd3ddc45ef640b18Structure();
}

public T[] ToArray<T>(Func<ST_1a3d048e7bc3b165cd3ddc45ef640b18Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_fbc6d3557cbab24aad22edbe8e93b6f4 recordList, Func<ST_1a3d048e7bc3b165cd3ddc45ef640b18Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_fbc6d3557cbab24aad22edbe8e93b6f4(ST_1a3d048e7bc3b165cd3ddc45ef640b18Structure[] array) {
  RL_fbc6d3557cbab24aad22edbe8e93b6f4 result = new RL_fbc6d3557cbab24aad22edbe8e93b6f4();
result.InnerFromArray(array);
    return result;
}

public static RL_fbc6d3557cbab24aad22edbe8e93b6f4 ToList<T>(T[] array, Func <T, ST_1a3d048e7bc3b165cd3ddc45ef640b18Structure> converter) {
  RL_fbc6d3557cbab24aad22edbe8e93b6f4 result = new RL_fbc6d3557cbab24aad22edbe8e93b6f4();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_fbc6d3557cbab24aad22edbe8e93b6f4 FromRestList<T>(RestList<T> restList, Func <T, ST_1a3d048e7bc3b165cd3ddc45ef640b18Structure> converter) {
  RL_fbc6d3557cbab24aad22edbe8e93b6f4 result = new RL_fbc6d3557cbab24aad22edbe8e93b6f4();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_fbc6d3557cbab24aad22edbe8e93b6f4() : base() {
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
protected override OSList<ST_1a3d048e7bc3b165cd3ddc45ef640b18Structure> NewList() {
return new RL_fbc6d3557cbab24aad22edbe8e93b6f4();
}


} // RL_fbc6d3557cbab24aad22edbe8e93b6f4
}

