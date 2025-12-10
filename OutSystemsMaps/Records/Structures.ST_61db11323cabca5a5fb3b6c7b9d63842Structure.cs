namespace ssOutSystemsMaps {
/// <summary>
/// [Structure] Internal_DrawingTools_Configs (C3sGE_cfUUGRjdmIky4+Ew)
///  <code>ST_61db11323cabca5a5fb3b6c7b9d63842Structure</code> that represent
/// s <code>Internal_DrawingTools_Configs</code> <p>Description: Structure to handle internal
///  configurations associated with the Drawing Tools.</p>
/// </summary>
// Name: Internal_DrawingTools_Configs
public partial struct ST_61db11323cabca5a5fb3b6c7b9d63842Structure : ITypedRecord<ST_61db11323cabca5a5fb3b6c7b9d63842Structure> {
internal static readonly GlobalObjectKey IdInternal_to_provider_drawingTools_configs = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*OkKr_NVPhEieNmNxl2OjWg");
internal static readonly GlobalObjectKey IdUniqueId = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*lhlBzOrq40qqtP+R9Rgg6w");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Internal_to_provider_drawingTools_configs")]
public ST_3f16cd459ccd861deffd4483bc1bbac3Structure ssInternal_to_provider_drawingTools_configs;

[System.Xml.Serialization.XmlElement("UniqueId")]
public string ssUniqueId;


public BitArray OptimizedAttributes;

public ST_61db11323cabca5a5fb3b6c7b9d63842Structure() {
OptimizedAttributes = null;
ssInternal_to_provider_drawingTools_configs = new ST_3f16cd459ccd861deffd4483bc1bbac3Structure();
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
    ssInternal_to_provider_drawingTools_configs.OptimizedAttributes = value[0];
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
ssUniqueId = r.ReadText(index++, "Internal_DrawingTools_Configs.UniqueId", "");
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
public void ReadIM(ST_61db11323cabca5a5fb3b6c7b9d63842Structure r) {
this = r;
}


public static bool operator == (ST_61db11323cabca5a5fb3b6c7b9d63842Structure a, ST_61db11323cabca5a5fb3b6c7b9d63842Structure b) {
if (a.ssInternal_to_provider_drawingTools_configs != b.ssInternal_to_provider_drawingTools_configs) return false;
if (a.ssUniqueId != b.ssUniqueId) return false;
return true;
}

public static bool operator != (ST_61db11323cabca5a5fb3b6c7b9d63842Structure a, ST_61db11323cabca5a5fb3b6c7b9d63842Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_61db11323cabca5a5fb3b6c7b9d63842Structure)) return false;
return (this == (ST_61db11323cabca5a5fb3b6c7b9d63842Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssInternal_to_provider_drawingTools_configs.GetHashCode()
 ^ ssUniqueId.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssInternal_to_provider_drawingTools_configs.RecursiveReset();
}

public void InternalRecursiveSave() {
ssInternal_to_provider_drawingTools_configs.InternalRecursiveSave();
}


public ST_61db11323cabca5a5fb3b6c7b9d63842Structure Duplicate() {
ST_61db11323cabca5a5fb3b6c7b9d63842Structure t;
t.ssInternal_to_provider_drawingTools_configs = (ST_3f16cd459ccd861deffd4483bc1bbac3Structure)this.ssInternal_to_provider_drawingTools_configs.Duplicate();
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
if (head == "internal_to_provider_drawingtools_configs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Internal_to_provider_drawingTools_configs")) variable.Value = ssInternal_to_provider_drawingTools_configs; else variable.Optimized = true;
variable.SetFieldName("internal_to_provider_drawingtools_configs");
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
if (key == IdInternal_to_provider_drawingTools_configs) {
return ssInternal_to_provider_drawingTools_configs;
}
if (key == IdUniqueId) {
return ssUniqueId;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInternal_to_provider_drawingTools_configs.Key.AsGuid) {
return ssInternal_to_provider_drawingTools_configs;
}
if (attributeKey == IdUniqueId.Key.AsGuid) {
return ssUniqueId;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssInternal_to_provider_drawingTools_configs.FillFromOther((IRecord) other.AttributeGet(IdInternal_to_provider_drawingTools_configs));
ssUniqueId = (string) other.AttributeGet(IdUniqueId);
}
} // ST_61db11323cabca5a5fb3b6c7b9d63842Structure
/// <summary>
/// RecordList type <code>Internal_DrawingTools_ConfigsList</code> that represents a record list of
///  <code>Internal_DrawingTools_Configs</code>
/// </summary>
public partial class RL_6b78ac86ffea73d6add846eee29f8299 : GenericRecordList<ST_61db11323cabca5a5fb3b6c7b9d63842Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_61db11323cabca5a5fb3b6c7b9d63842Structure GetElementDefaultValue() {
return new ST_61db11323cabca5a5fb3b6c7b9d63842Structure();
}

public T[] ToArray<T>(Func<ST_61db11323cabca5a5fb3b6c7b9d63842Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_6b78ac86ffea73d6add846eee29f8299 recordList, Func<ST_61db11323cabca5a5fb3b6c7b9d63842Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_6b78ac86ffea73d6add846eee29f8299(ST_61db11323cabca5a5fb3b6c7b9d63842Structure[] array) {
  RL_6b78ac86ffea73d6add846eee29f8299 result = new RL_6b78ac86ffea73d6add846eee29f8299();
result.InnerFromArray(array);
    return result;
}

public static RL_6b78ac86ffea73d6add846eee29f8299 ToList<T>(T[] array, Func <T, ST_61db11323cabca5a5fb3b6c7b9d63842Structure> converter) {
  RL_6b78ac86ffea73d6add846eee29f8299 result = new RL_6b78ac86ffea73d6add846eee29f8299();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_6b78ac86ffea73d6add846eee29f8299 FromRestList<T>(RestList<T> restList, Func <T, ST_61db11323cabca5a5fb3b6c7b9d63842Structure> converter) {
  RL_6b78ac86ffea73d6add846eee29f8299 result = new RL_6b78ac86ffea73d6add846eee29f8299();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_6b78ac86ffea73d6add846eee29f8299() : base() {
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
protected override OSList<ST_61db11323cabca5a5fb3b6c7b9d63842Structure> NewList() {
return new RL_6b78ac86ffea73d6add846eee29f8299();
}


} // RL_6b78ac86ffea73d6add846eee29f8299
}

