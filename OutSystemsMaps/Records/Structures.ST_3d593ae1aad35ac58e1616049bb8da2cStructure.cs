namespace ssOutSystemsMaps {
/// <summary>
/// [Structure] Internal__Marker_Configs (+b9H8dXaw0u0siVFsb2YhA)
///  <code>ST_3d593ae1aad35ac58e1616049bb8da2cStructure</code> that represent
/// s <code>Internal__Marker_Configs</code> <p>Description: Structure to handle internal configurations
///  associated with the Markers.</p>
/// </summary>
// Name: Internal__Marker_Configs
public partial struct ST_3d593ae1aad35ac58e1616049bb8da2cStructure : ITypedRecord<ST_3d593ae1aad35ac58e1616049bb8da2cStructure> {
internal static readonly GlobalObjectKey IdInternal_to_provider_marker_configs = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*7xM9MWF_zEiiZFdYWcXWAQ");
internal static readonly GlobalObjectKey IdUniqueId = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*UovS45VKV0mKIocz91Zhyg");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Internal_to_provider_marker_configs")]
public ST_51ef6a78944132edc56aa7bf7c4ea240Structure ssInternal_to_provider_marker_configs;

[System.Xml.Serialization.XmlElement("UniqueId")]
public string ssUniqueId;


public BitArray OptimizedAttributes;

public ST_3d593ae1aad35ac58e1616049bb8da2cStructure() {
OptimizedAttributes = null;
ssInternal_to_provider_marker_configs = new ST_51ef6a78944132edc56aa7bf7c4ea240Structure();
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
    ssInternal_to_provider_marker_configs.OptimizedAttributes = value[0];
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
ssUniqueId = r.ReadText(index++, "Internal__Marker_Configs.UniqueId", "");
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
public void ReadIM(ST_3d593ae1aad35ac58e1616049bb8da2cStructure r) {
this = r;
}


public static bool operator == (ST_3d593ae1aad35ac58e1616049bb8da2cStructure a, ST_3d593ae1aad35ac58e1616049bb8da2cStructure b) {
if (a.ssInternal_to_provider_marker_configs != b.ssInternal_to_provider_marker_configs) return false;
if (a.ssUniqueId != b.ssUniqueId) return false;
return true;
}

public static bool operator != (ST_3d593ae1aad35ac58e1616049bb8da2cStructure a, ST_3d593ae1aad35ac58e1616049bb8da2cStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_3d593ae1aad35ac58e1616049bb8da2cStructure)) return false;
return (this == (ST_3d593ae1aad35ac58e1616049bb8da2cStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssInternal_to_provider_marker_configs.GetHashCode()
 ^ ssUniqueId.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssInternal_to_provider_marker_configs.RecursiveReset();
}

public void InternalRecursiveSave() {
ssInternal_to_provider_marker_configs.InternalRecursiveSave();
}


public ST_3d593ae1aad35ac58e1616049bb8da2cStructure Duplicate() {
ST_3d593ae1aad35ac58e1616049bb8da2cStructure t;
t.ssInternal_to_provider_marker_configs = (ST_51ef6a78944132edc56aa7bf7c4ea240Structure)this.ssInternal_to_provider_marker_configs.Duplicate();
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
if (head == "internal_to_provider_marker_configs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Internal_to_provider_marker_configs")) variable.Value = ssInternal_to_provider_marker_configs; else variable.Optimized = true;
variable.SetFieldName("internal_to_provider_marker_configs");
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
if (key == IdInternal_to_provider_marker_configs) {
return ssInternal_to_provider_marker_configs;
}
if (key == IdUniqueId) {
return ssUniqueId;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInternal_to_provider_marker_configs.Key.AsGuid) {
return ssInternal_to_provider_marker_configs;
}
if (attributeKey == IdUniqueId.Key.AsGuid) {
return ssUniqueId;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssInternal_to_provider_marker_configs.FillFromOther((IRecord) other.AttributeGet(IdInternal_to_provider_marker_configs));
ssUniqueId = (string) other.AttributeGet(IdUniqueId);
}
} // ST_3d593ae1aad35ac58e1616049bb8da2cStructure
/// <summary>
/// RecordList type <code>Internal__Marker_ConfigsList</code> that represents a record list of
///  <code>Internal__Marker_Configs</code>
/// </summary>
public partial class RL_1740c5fc4f19037173051d750651a4c3 : GenericRecordList<ST_3d593ae1aad35ac58e1616049bb8da2cStructure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_3d593ae1aad35ac58e1616049bb8da2cStructure GetElementDefaultValue() {
return new ST_3d593ae1aad35ac58e1616049bb8da2cStructure();
}

public T[] ToArray<T>(Func<ST_3d593ae1aad35ac58e1616049bb8da2cStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_1740c5fc4f19037173051d750651a4c3 recordList, Func<ST_3d593ae1aad35ac58e1616049bb8da2cStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_1740c5fc4f19037173051d750651a4c3(ST_3d593ae1aad35ac58e1616049bb8da2cStructure[] array) {
  RL_1740c5fc4f19037173051d750651a4c3 result = new RL_1740c5fc4f19037173051d750651a4c3();
result.InnerFromArray(array);
    return result;
}

public static RL_1740c5fc4f19037173051d750651a4c3 ToList<T>(T[] array, Func <T, ST_3d593ae1aad35ac58e1616049bb8da2cStructure> converter) {
  RL_1740c5fc4f19037173051d750651a4c3 result = new RL_1740c5fc4f19037173051d750651a4c3();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_1740c5fc4f19037173051d750651a4c3 FromRestList<T>(RestList<T> restList, Func <T, ST_3d593ae1aad35ac58e1616049bb8da2cStructure> converter) {
  RL_1740c5fc4f19037173051d750651a4c3 result = new RL_1740c5fc4f19037173051d750651a4c3();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_1740c5fc4f19037173051d750651a4c3() : base() {
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
protected override OSList<ST_3d593ae1aad35ac58e1616049bb8da2cStructure> NewList() {
return new RL_1740c5fc4f19037173051d750651a4c3();
}


} // RL_1740c5fc4f19037173051d750651a4c3
}

