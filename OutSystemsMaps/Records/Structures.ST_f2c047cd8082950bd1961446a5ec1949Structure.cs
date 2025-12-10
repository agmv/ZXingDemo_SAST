namespace ssOutSystemsMaps {
/// <summary>
/// [Structure] Internal_HeatmapLayer_Configs (pCGK3R4jQ06axG2gYDP4uA)
///  <code>ST_f2c047cd8082950bd1961446a5ec1949Structure</code> that represent
/// s <code>Internal_HeatmapLayer_Configs</code> <p>Description: Structure to handle internal
///  configurations associated with the Heatmap Layer.</p>
/// </summary>
// Name: Internal_HeatmapLayer_Configs
public partial struct ST_f2c047cd8082950bd1961446a5ec1949Structure : ITypedRecord<ST_f2c047cd8082950bd1961446a5ec1949Structure> {
internal static readonly GlobalObjectKey IdInternal_to_provider_heatmapLayer_configs = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*b4tRVc92VEK1R7hpeAwQ0w");
internal static readonly GlobalObjectKey IdUniqueId = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*cgD6djqvFU+TjA76lZvbog");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Internal_to_provider_heatmapLayer_configs")]
public ST_ca5fecbdf222b72d179909c1f030119cStructure ssInternal_to_provider_heatmapLayer_configs;

[System.Xml.Serialization.XmlElement("UniqueId")]
public string ssUniqueId;


public BitArray OptimizedAttributes;

public ST_f2c047cd8082950bd1961446a5ec1949Structure() {
OptimizedAttributes = null;
ssInternal_to_provider_heatmapLayer_configs = new ST_ca5fecbdf222b72d179909c1f030119cStructure();
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
    ssInternal_to_provider_heatmapLayer_configs.OptimizedAttributes = value[0];
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
ssUniqueId = r.ReadText(index++, "Internal_HeatmapLayer_Configs.UniqueId", "");
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
public void ReadIM(ST_f2c047cd8082950bd1961446a5ec1949Structure r) {
this = r;
}


public static bool operator == (ST_f2c047cd8082950bd1961446a5ec1949Structure a, ST_f2c047cd8082950bd1961446a5ec1949Structure b) {
if (a.ssInternal_to_provider_heatmapLayer_configs != b.ssInternal_to_provider_heatmapLayer_configs) return false;
if (a.ssUniqueId != b.ssUniqueId) return false;
return true;
}

public static bool operator != (ST_f2c047cd8082950bd1961446a5ec1949Structure a, ST_f2c047cd8082950bd1961446a5ec1949Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_f2c047cd8082950bd1961446a5ec1949Structure)) return false;
return (this == (ST_f2c047cd8082950bd1961446a5ec1949Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssInternal_to_provider_heatmapLayer_configs.GetHashCode()
 ^ ssUniqueId.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssInternal_to_provider_heatmapLayer_configs.RecursiveReset();
}

public void InternalRecursiveSave() {
ssInternal_to_provider_heatmapLayer_configs.InternalRecursiveSave();
}


public ST_f2c047cd8082950bd1961446a5ec1949Structure Duplicate() {
ST_f2c047cd8082950bd1961446a5ec1949Structure t;
t.ssInternal_to_provider_heatmapLayer_configs = (ST_ca5fecbdf222b72d179909c1f030119cStructure)this.ssInternal_to_provider_heatmapLayer_configs.Duplicate();
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
if (head == "internal_to_provider_heatmaplayer_configs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Internal_to_provider_heatmapLayer_configs")) variable.Value = ssInternal_to_provider_heatmapLayer_configs; else variable.Optimized = true;
variable.SetFieldName("internal_to_provider_heatmaplayer_configs");
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
if (key == IdInternal_to_provider_heatmapLayer_configs) {
return ssInternal_to_provider_heatmapLayer_configs;
}
if (key == IdUniqueId) {
return ssUniqueId;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInternal_to_provider_heatmapLayer_configs.Key.AsGuid) {
return ssInternal_to_provider_heatmapLayer_configs;
}
if (attributeKey == IdUniqueId.Key.AsGuid) {
return ssUniqueId;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssInternal_to_provider_heatmapLayer_configs.FillFromOther((IRecord) other.AttributeGet(IdInternal_to_provider_heatmapLayer_configs));
ssUniqueId = (string) other.AttributeGet(IdUniqueId);
}
} // ST_f2c047cd8082950bd1961446a5ec1949Structure
/// <summary>
/// RecordList type <code>Internal_HeatmapLayer_ConfigsList</code> that represents a record list of
///  <code>Internal_HeatmapLayer_Configs</code>
/// </summary>
public partial class RL_2040a40e62ae80fafc57cb81cae34851 : GenericRecordList<ST_f2c047cd8082950bd1961446a5ec1949Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_f2c047cd8082950bd1961446a5ec1949Structure GetElementDefaultValue() {
return new ST_f2c047cd8082950bd1961446a5ec1949Structure();
}

public T[] ToArray<T>(Func<ST_f2c047cd8082950bd1961446a5ec1949Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_2040a40e62ae80fafc57cb81cae34851 recordList, Func<ST_f2c047cd8082950bd1961446a5ec1949Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_2040a40e62ae80fafc57cb81cae34851(ST_f2c047cd8082950bd1961446a5ec1949Structure[] array) {
  RL_2040a40e62ae80fafc57cb81cae34851 result = new RL_2040a40e62ae80fafc57cb81cae34851();
result.InnerFromArray(array);
    return result;
}

public static RL_2040a40e62ae80fafc57cb81cae34851 ToList<T>(T[] array, Func <T, ST_f2c047cd8082950bd1961446a5ec1949Structure> converter) {
  RL_2040a40e62ae80fafc57cb81cae34851 result = new RL_2040a40e62ae80fafc57cb81cae34851();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_2040a40e62ae80fafc57cb81cae34851 FromRestList<T>(RestList<T> restList, Func <T, ST_f2c047cd8082950bd1961446a5ec1949Structure> converter) {
  RL_2040a40e62ae80fafc57cb81cae34851 result = new RL_2040a40e62ae80fafc57cb81cae34851();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_2040a40e62ae80fafc57cb81cae34851() : base() {
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
protected override OSList<ST_f2c047cd8082950bd1961446a5ec1949Structure> NewList() {
return new RL_2040a40e62ae80fafc57cb81cae34851();
}


} // RL_2040a40e62ae80fafc57cb81cae34851
}

