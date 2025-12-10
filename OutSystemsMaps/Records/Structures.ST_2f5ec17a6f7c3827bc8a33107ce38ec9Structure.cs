namespace ssOutSystemsMaps {
/// <summary>
/// [Structure] Internal_Shape_Configs (epllmWmv0EKJoKsjGbC5lg)
///  <code>ST_2f5ec17a6f7c3827bc8a33107ce38ec9Structure</code> that represent
/// s <code>Internal_Shape_Configs</code> <p>Description: Structure to handle internal configurations
///  associated with Shapes.</p>
/// </summary>
// Name: Internal_Shape_Configs
public partial struct ST_2f5ec17a6f7c3827bc8a33107ce38ec9Structure : ITypedRecord<ST_2f5ec17a6f7c3827bc8a33107ce38ec9Structure> {
internal static readonly GlobalObjectKey IdInternal_to_provider_shape_configs = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*gL26pYm8gky+K_NDhe5NIA");
internal static readonly GlobalObjectKey IdUniqueId = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*KgDlcFkIIUyO+2HdRiROrQ");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Internal_to_provider_shape_configs")]
public ST_4d96f69748c4f35fb433f7995d061407Structure ssInternal_to_provider_shape_configs;

[System.Xml.Serialization.XmlElement("UniqueId")]
public string ssUniqueId;


public BitArray OptimizedAttributes;

public ST_2f5ec17a6f7c3827bc8a33107ce38ec9Structure() {
OptimizedAttributes = null;
ssInternal_to_provider_shape_configs = new ST_4d96f69748c4f35fb433f7995d061407Structure();
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
    ssInternal_to_provider_shape_configs.OptimizedAttributes = value[0];
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
ssUniqueId = r.ReadText(index++, "Internal_Shape_Configs.UniqueId", "");
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
public void ReadIM(ST_2f5ec17a6f7c3827bc8a33107ce38ec9Structure r) {
this = r;
}


public static bool operator == (ST_2f5ec17a6f7c3827bc8a33107ce38ec9Structure a, ST_2f5ec17a6f7c3827bc8a33107ce38ec9Structure b) {
if (a.ssInternal_to_provider_shape_configs != b.ssInternal_to_provider_shape_configs) return false;
if (a.ssUniqueId != b.ssUniqueId) return false;
return true;
}

public static bool operator != (ST_2f5ec17a6f7c3827bc8a33107ce38ec9Structure a, ST_2f5ec17a6f7c3827bc8a33107ce38ec9Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_2f5ec17a6f7c3827bc8a33107ce38ec9Structure)) return false;
return (this == (ST_2f5ec17a6f7c3827bc8a33107ce38ec9Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssInternal_to_provider_shape_configs.GetHashCode()
 ^ ssUniqueId.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssInternal_to_provider_shape_configs.RecursiveReset();
}

public void InternalRecursiveSave() {
ssInternal_to_provider_shape_configs.InternalRecursiveSave();
}


public ST_2f5ec17a6f7c3827bc8a33107ce38ec9Structure Duplicate() {
ST_2f5ec17a6f7c3827bc8a33107ce38ec9Structure t;
t.ssInternal_to_provider_shape_configs = (ST_4d96f69748c4f35fb433f7995d061407Structure)this.ssInternal_to_provider_shape_configs.Duplicate();
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
if (head == "internal_to_provider_shape_configs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Internal_to_provider_shape_configs")) variable.Value = ssInternal_to_provider_shape_configs; else variable.Optimized = true;
variable.SetFieldName("internal_to_provider_shape_configs");
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
if (key == IdInternal_to_provider_shape_configs) {
return ssInternal_to_provider_shape_configs;
}
if (key == IdUniqueId) {
return ssUniqueId;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInternal_to_provider_shape_configs.Key.AsGuid) {
return ssInternal_to_provider_shape_configs;
}
if (attributeKey == IdUniqueId.Key.AsGuid) {
return ssUniqueId;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssInternal_to_provider_shape_configs.FillFromOther((IRecord) other.AttributeGet(IdInternal_to_provider_shape_configs));
ssUniqueId = (string) other.AttributeGet(IdUniqueId);
}
} // ST_2f5ec17a6f7c3827bc8a33107ce38ec9Structure
/// <summary>
/// RecordList type <code>Internal_Shape_ConfigsList</code> that represents a record list of
///  <code>Internal_Shape_Configs</code>
/// </summary>
public partial class RL_45b1a00767a21a6d36e72bda469c2b5a : GenericRecordList<ST_2f5ec17a6f7c3827bc8a33107ce38ec9Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_2f5ec17a6f7c3827bc8a33107ce38ec9Structure GetElementDefaultValue() {
return new ST_2f5ec17a6f7c3827bc8a33107ce38ec9Structure();
}

public T[] ToArray<T>(Func<ST_2f5ec17a6f7c3827bc8a33107ce38ec9Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_45b1a00767a21a6d36e72bda469c2b5a recordList, Func<ST_2f5ec17a6f7c3827bc8a33107ce38ec9Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_45b1a00767a21a6d36e72bda469c2b5a(ST_2f5ec17a6f7c3827bc8a33107ce38ec9Structure[] array) {
  RL_45b1a00767a21a6d36e72bda469c2b5a result = new RL_45b1a00767a21a6d36e72bda469c2b5a();
result.InnerFromArray(array);
    return result;
}

public static RL_45b1a00767a21a6d36e72bda469c2b5a ToList<T>(T[] array, Func <T, ST_2f5ec17a6f7c3827bc8a33107ce38ec9Structure> converter) {
  RL_45b1a00767a21a6d36e72bda469c2b5a result = new RL_45b1a00767a21a6d36e72bda469c2b5a();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_45b1a00767a21a6d36e72bda469c2b5a FromRestList<T>(RestList<T> restList, Func <T, ST_2f5ec17a6f7c3827bc8a33107ce38ec9Structure> converter) {
  RL_45b1a00767a21a6d36e72bda469c2b5a result = new RL_45b1a00767a21a6d36e72bda469c2b5a();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_45b1a00767a21a6d36e72bda469c2b5a() : base() {
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
protected override OSList<ST_2f5ec17a6f7c3827bc8a33107ce38ec9Structure> NewList() {
return new RL_45b1a00767a21a6d36e72bda469c2b5a();
}


} // RL_45b1a00767a21a6d36e72bda469c2b5a
}

